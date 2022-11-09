using DataAccessLayer;
using DataAccessLayer.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using DataAccesLayer;

namespace BusinessLayer
{
    public class PodcastController
    {
        public PodcastRepository podcastRepository;
        public CategoryRepository categoryreposity;
        List<Timer> timerList = new List<Timer>();

        public PodcastController()
        {
            categoryreposity = new CategoryRepository();
            podcastRepository = new PodcastRepository(categoryreposity);
        }

        public async Task CreatePodcast(string URL, int frequency, Category category)
        {
            SyndicationFeed feed = await Task.Run(() => UrlManager.GetFeed(URL));
            string podcastTitle = feed.Title.Text;
            string podcastDescription = feed.Description.Text;
            List<Episode> episodes = UrlManager.GetEpisodes(URL);
            Podcast newPodcast = new Podcast(podcastTitle, podcastDescription, category, frequency, episodes, URL);
            podcastRepository.Create(newPodcast);
            
        }
        public void ChangePodcast(string URL, int frequency, Category category, string newName,Podcast podcast)
        {
            DeletePodcast(podcast);
            SyndicationFeed feed = UrlManager.GetFeed(URL);
            string podcastDescription = feed.Description.Text;
            List<Episode> episodes = UrlManager.GetEpisodes(URL);
            Podcast newPodcast = new Podcast(newName, podcastDescription, category, frequency, episodes, URL);
            podcastRepository.Create(newPodcast);
            //foreach (var item in episodes)
            //{
            //    results += item.Title + " " + item.Description + "\n";
            //}
            //MessageBox.Show(results);
        }

        public List<Podcast> GetAllPodcasts()
        {
            return podcastRepository.GetAll();
        }
        public Podcast GetPodcastByName(string name)
        {
            foreach (Podcast podcast in GetAllPodcasts())
            {
                if (podcast.Name.Equals(name))
                {
                    return podcast;
                }
            }
            return null;
        }   
        public List<Podcast> GetPodcastsByCategory(string categoryName)
        {
            return (from Podcast podcast in GetAllPodcasts()
                    where podcast.Category.Name.Equals(categoryName)
                    select podcast).ToList();

            
        }

        public void ShowEpisodes(Podcast podcast)
        {
            string listBoxContent = "";
            foreach (Episode episode in podcast.episodes)
            {
                listBoxContent += episode.Title + "\n";
            }
           
        }
        
        public void CreateCategory(string categoryName)
        {
            Category newCategory = new Category(categoryName);
            categoryreposity.Create(newCategory);

        }
        public Category GetCategoryByName(string name)
        {
            Category returnedCategory = null;
            foreach (var category in GetAllCategories().Where(category => category.Name.Equals(name))
            //LAMBDA?
            )
            {
                returnedCategory = category;
            }

            return returnedCategory;
        }

        public List<Category> GetAllCategories()
        {
            return categoryreposity.GetAll();
        }

        public void ChangeCategory(Category categoryToChange, string newName)
        {
            CreateCategory(newName);
            SetNewCategoryOnPodcasts(categoryToChange.Name, newName);
            categoryreposity.Delete(categoryToChange);
            podcastRepository.SaveChanges();
        }
        public void SetNewCategoryOnPodcasts(string oldName, string newName)
        {
            foreach (Podcast podcast in GetAllPodcasts())
            {
                
                if (podcast.Category.Name.Equals(oldName))
                {
                    podcastRepository.SetNewCategory(podcast, GetCategoryByName(newName));
                }

            }
        }

        public void DeletePodcast(Podcast podcast)
        {
            podcastRepository.Delete(podcast);

        }
        public void DeleteCategory(Category category)
        {
            if (!Validation.IsCateGoryEmpty(category.Name, podcastRepository.entityList))
            {
                var answer = MessageBox.Show("This category contains podcasts which will also be deleted",
                                     "Do you want to delete?",
                                     MessageBoxButtons.YesNo);
                if(answer == DialogResult.Yes)
                {
                    categoryreposity.Delete(category);
                }
            }
            else
            {
                categoryreposity.Delete(category);
            }
        }
        public string GetEpisodeDescriptionByName(string name, Podcast podcast)
        {
            foreach (var episode in from Episode episode in podcast.episodes
                                    where episode.Title.Equals(name)
                                    select episode)
            {
                return episode.Description;
            }

            return null;
    
        }

        public void CreateTimer(Podcast podcast)
        {
            Timer myTimer = new Timer();
            myTimer.Interval = podcast.Frequency * 1000;
            myTimer.Tick += (sender, e) => ChangePodcast(podcast.URL, podcast.Frequency, podcast.Category, podcast.Name, podcast);
            //minTimer.Tick += (sender, e) => updateFeed();
            myTimer.Start();
            //Gör en funktion som kör en foreach på varje podcast i entityListen som körs vid initialize och vid varje save/add osv sov?
            timerList.Add(myTimer);
        }

        public void InitializeTimers()
        {
            foreach(Timer timer in timerList)
            {
                timer.Dispose();
            }
            foreach(var item in GetAllPodcasts())
            {
                CreateTimer(item);
            }
        }
        //public void minTimer_Tick(object sender, EventArgs e)
        //{
        //    UrlManager.GetFeed(enPodcast.URL);
        //}

    }
}