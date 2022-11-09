using DataAccesLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Diagnostics;

namespace DataAccessLayer.Repositories
{
    public class PodcastRepository : Repository<Podcast>, IRepository<Podcast>
    {
        
        CategoryRepository categoryRepository;

        public PodcastRepository(CategoryRepository existingCategories)
        {
            dataManager = new SerializerForXml();
            entityList = new List<Podcast>();
            categoryRepository = existingCategories;
            entityList = GetAll();

        }

        //public override void Create(Podcast podcast)
        //{
        //    listOfPodcasts.Add(podcast);
        //    Append(podcast);
        //    //SaveChanges();
        //}
        public override void Append(Podcast podcast)
        {
            List<Podcast> temporaryList = new List<Podcast>();
            foreach (Podcast podcastt in entityList)
            {
                //Debug.WriteLine(podcast.Category.Name, podcastt.Category.Name);
                if (podcast.Category.Name.Equals(podcastt.Category.Name))
                {
                    temporaryList.Add(podcastt);
                    
                }
                
            }
            dataManager.SerializeAppend(temporaryList, podcast.Category.Name + ".xml");
        }

        public override void Delete(Podcast podcast)
        {
            for (int i = 0; i < entityList.Count(); i++)
            {
                if (podcast.Name.Equals(entityList[i].Name) && podcast.Category.Name.Equals(entityList[i].Category.Name))
                {
                    entityList.RemoveAt(i);
                }
            }
            if (entityList.Count() == 0)
            {
                categoryRepository.DeleteAllPodcasts();
            }
            SaveChanges();
        }

        public override List<Podcast> GetAll()
        {
            try
            {
                List<Podcast> temporaryList = new List<Podcast>();
                List<Podcast> returnList = new List<Podcast>();
                foreach (Category category in categoryRepository.GetAll())
                {
                        temporaryList = dataManager.Deserialize(category.Name + ".xml");
                        foreach (var podcast in temporaryList)
                        {
                            podcast.Category = category;
                            returnList.Add(podcast);
                        }
                }
                return returnList;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            return entityList;
        }


        public void SetNewCategory(Podcast podcast, Category newCategory)
        {
            foreach (Podcast podcastt in entityList)
            {
                if(podcast.Name == podcastt.Name)
                {
                    podcastt.Category = newCategory;
                }
            }
        }
        public override void SaveChanges()
        {

            foreach (Category category in categoryRepository.entityList)
            {
                List<Podcast> tempList = new List<Podcast>();
                foreach (Podcast podcast in entityList)
                {
                    if (podcast.Category.Name.Equals(category.Name))
                    {
                        tempList.Add(podcast);
                    }
                }
                dataManager.SerializeAppend(tempList, category.Name + ".xml");
            }
        }

        
    }
}