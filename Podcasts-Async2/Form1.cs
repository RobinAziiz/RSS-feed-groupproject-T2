using BusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcasts_Async2
{
    public partial class Form1 : Form
    {
        PodcastController podcastController = new PodcastController();
        Podcast selectedPodcast;
        Category selectedCategory;
        public Form1()
        {
            InitializeComponent();
            FillCategoryComboBox();
            //podcastController.InitializeTimer();
            podcastController.InitializeTimers();


        }
        public void ClearInputs()
        {
            txtBoxURL.Text = "";
            txtBoxName.Text = "";
            //cbFrequency.Text = "";
            //cbCategory.Text = "";
        }
        private void UpdateCategoriers()
        {
            listBoxCat.Items.Clear();
            FillCategoryComboBox();

            foreach (Category category in podcastController.GetAllCategories())
            {
                listBoxCat.Items.Add(category.Name);
            }
            int count = podcastController.GetAllCategories().Count();
            //MessageBox.Show(count.ToString());
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.ValidateCreatePodcast(cbFrequency, cbCategory, txtBoxURL))
                {
                    await CreatePodcastAsync();
                    podcastController.InitializeTimers();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("fel bre");
            }
        }

        private async Task CreatePodcastAsync()
        {
            string URL = txtBoxURL.Text;
            if (Validation.ValidateURL(URL))
            {
                int frequency = Convert.ToInt32(cbFrequency.SelectedItem);
                Category category = (Category)cbCategory.SelectedValue;
                await podcastController.CreatePodcast(URL, frequency, category);
                FillAllPodcasts();
            }
            
        }





        private void btnCreateCat_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateCategory(txtBoxCat, podcastController.GetAllCategories()))
            {
                string categoryName = txtBoxCat.Text;
                podcastController.CreateCategory(categoryName);
                txtBoxCat.Text = "";
                UpdateCategoriers();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCategoriers();
            FillAllPodcasts();
        }
        private void FillAllPodcasts()
        {
            listViewPodcasts.Items.Clear();
            foreach (Podcast podcast in podcastController.GetAllPodcasts())
            {
                string[] array = 
                 { 
                    podcast.episodes.Count().ToString(),
                    podcast.Name,
                    podcast.Frequency.ToString(),
                    podcast.Category.Name
                };
                ListViewItem lvi = new ListViewItem(array);
                //lvi.SubItems.Add(podcast.episodes.Count().ToString());
                //lvi.SubItems.Add(podcast.Name);
                //lvi.SubItems.Add(podcast.Frequency.ToString());
                //lvi.SubItems.Add(podcast.Category.Name);
                listViewPodcasts.Items.Add(lvi);

            }
        }
        private void FillPodcastByCategory(Category category)
        {
            listViewPodcasts.Items.Clear();
            foreach (Podcast podcast in podcastController.GetAllPodcasts())
            {
                if (podcast.Category.Name.Equals(category.Name))
                {
                    string[] array =
                     {
                    podcast.episodes.Count().ToString(),
                    podcast.Name,
                    podcast.Frequency.ToString(),
                    podcast.Category.Name
                };
                    ListViewItem lvi = new ListViewItem(array);
                    //lvi.SubItems.Add(podcast.episodes.Count().ToString());
                    //lvi.SubItems.Add(podcast.Name);
                    //lvi.SubItems.Add(podcast.Frequency.ToString());
                    //lvi.SubItems.Add(podcast.Category.Name);
                    listViewPodcasts.Items.Add(lvi);
                }

            }
        }
        private void FillCategoryComboBox()
        {
            cbCategory.DataSource = podcastController.GetAllCategories();
            cbCategory.DisplayMember = "Name";
        }

        private void listViewPodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewPodcasts.SelectedItems.Count > 0) {
                Podcast selectedPodcast = podcastController.GetPodcastByName(listViewPodcasts.SelectedItems[0].SubItems[1].Text);

                cbCategory.SelectedIndex = cbCategory.FindStringExact(selectedPodcast.Category.Name);
                cbFrequency.SelectedIndex = cbFrequency.FindStringExact(selectedPodcast.Frequency.ToString());
                txtBoxName.ReadOnly = false;
                txtBoxName.Text = listViewPodcasts.SelectedItems[0].SubItems[1].Text;
                listBoxEpisodes.Items.Clear();
                foreach (Episode episode in selectedPodcast.episodes)
                {
                    listBoxEpisodes.Items.Add(episode.Title);
                }

            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            try {
                if (Validation.ValidateChanges(listViewPodcasts, txtBoxName))
                {
            selectedPodcast = podcastController.GetPodcastByName(listViewPodcasts.SelectedItems[0].SubItems[1].Text);
            podcastController.DeletePodcast(selectedPodcast);
            string newName = txtBoxName.Text;
            int newFrequency = Convert.ToInt32(cbFrequency.SelectedItem);
            Category newCategory = (Category)cbCategory.SelectedValue;
            podcastController.ChangePodcast(selectedPodcast.URL, newFrequency, newCategory, newName, selectedPodcast);
                FillAllPodcasts();
                podcastController.InitializeTimers();

            }
            }
            catch (Exception err)
            {
                MessageBox.Show("Please select a podcast");
            }
            finally
            {
                ClearInputs();
            }

        }

        private void listBoxEpisodes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewPodcasts.SelectedItems.Count > 0)
            {
                Podcast selectedPodcast = podcastController.GetPodcastByName(listViewPodcasts.SelectedItems[0].SubItems[1].Text);
                string episodeName = listBoxEpisodes.SelectedItem.ToString();
                webBrowserEpisodes.DocumentText = podcastController.GetEpisodeDescriptionByName(episodeName, selectedPodcast);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.IsPodcastSelected(listViewPodcasts))
                {
                    selectedPodcast = podcastController.GetPodcastByName(listViewPodcasts.SelectedItems[0].SubItems[1].Text);
                    podcastController.DeletePodcast(selectedPodcast);
                    podcastController.InitializeTimers();
                    ClearInputs();
                    FillAllPodcasts();
                }
            }
            catch
            {
                MessageBox.Show("Please select a podcast");
            }
        }

        private void listBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCat.SelectedItem == null) return;
            try
            {
                selectedCategory = podcastController.GetCategoryByName(listBoxCat.SelectedItem.ToString());
                txtBoxCat.Text = selectedCategory.Name;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
            
        {
            //if (listBoxCat.SelectedItem == null) return;
            
                try
                {
                if (Validation.ValidateSaveCategory(txtBoxCat, podcastController.GetAllCategories(), listBoxCat))
                {
                    selectedCategory = podcastController.GetCategoryByName(listBoxCat.SelectedItem.ToString());
                    string newCategoryName = txtBoxCat.Text;
                    podcastController.ChangeCategory(selectedCategory, newCategoryName);
                    FillAllPodcasts();
                    UpdateCategoriers();
                    podcastController.InitializeTimers();
                    txtBoxCat.Text = "";
                }
                }
                catch (Exception)
                {

                    throw;
                }
            
           
        }

        private void btnRemoveCat_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateRemoveIsSelected(listBoxCat))
            {
                selectedCategory = podcastController.GetCategoryByName(listBoxCat.SelectedItem.ToString());
                podcastController.DeleteCategory(selectedCategory);
                podcastController.InitializeTimers();
                UpdateCategoriers();
                FillAllPodcasts();
            }
        }

        private void btnSortBy_Click(object sender, EventArgs e)
        {
            if (Validation.ListBoxIsSelected(listBoxCat))
            {
                selectedCategory = podcastController.GetCategoryByName(listBoxCat.SelectedItem.ToString());
                FillPodcastByCategory(selectedCategory);
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillAllPodcasts();
        }
    }
}
