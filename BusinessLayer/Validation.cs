using BusinessLayer.Exceptions;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public static class Validation
    {
        //På kategorinamnet används denna, och gör så att man måste skriva minst 3 tecken.
        public static bool TxtFilled(TextBox txtbox)
        {
            try
            {
                if (txtbox.Text.Length > 0)
                {
                    return true;
                }
                else throw new TextBoxIsNotFilledException();

            }
            catch (TextBoxIsNotFilledException e)
            {
                MessageBox.Show(e.Message);
                txtbox.Focus();
                return false;
            }
        }
        // gör så att man måste ha ifyllda comboboxar vid skapandet av podcast
        public static bool CbIsFilled(ComboBox cbfrequency, ComboBox cbCategory)
        {
            try
            {
                if (cbCategory.SelectedItem != null && cbfrequency.SelectedItem != null)
                {
                    return true;
                }
                else throw new ComboBoxFilledException();
            }
            catch (ComboBoxFilledException e)
            {
                MessageBox.Show(e.Message);

                return false;
            }
        }
        // Gör så att man inte kan byta namn eller skapa en kategori som har samma namn som en befintlig kategori.
        public static bool CategoryUnique(TextBox txtBoxCat, List<Category> catList)
        {
            try
            {
                foreach (var category in catList)
                {
                    if (txtBoxCat.Text == category.Name)
                    {
                        throw new IsUniqueException("Category");

                    }
                } return true;
            } catch (IsUniqueException e)
            {
                MessageBox.Show(e.Message);
                txtBoxCat.Focus();
                return false;
            }


        }
        // validerar URL:en
        public static bool ValidateURL(string url)
        {
            try
            {
                SyndicationFeed feed = UrlManager.GetFeed(url);
                if (feed == null)
                {
                    throw new BrokenFeedException();
                }
                return true;
            }
            catch (BrokenFeedException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        // Man måste selektera en podcast i ListViewen för att göra ändringar eller ta bort.
        public static bool ListViewIsSelected(ListView listView)
        {
            try
            {
                if (listView.SelectedItems[0] == null)
                {
                    throw new SelectedItemExistsException();
                }
                return true;
            }
            catch (SelectedItemExistsException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        // Man måste selektera en podcast i ListBoxen för att göra ändringar eller ta bort.
        public static bool ListBoxIsSelected(ListBox listBox)
        {
            try {
                if (listBox.SelectedItem == null)
                {
                    throw new SelectedItemExistsException();
                }
                return true;
            }catch(SelectedItemExistsException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            }

        // För att veta om en kategori innehåller podcats innan den tas bort.
        public static bool IsCateGoryEmpty(string categoryName, List<Podcast> entityList)
        {
            foreach (Podcast podcast in entityList)
            {
                if (podcast.Category.Name.Equals(categoryName))
                {
                    return false;
                }
            }
            return true;
        }





        // Gruppering av metoder för tydligare kod
        public static bool ValidateCategory(TextBox txtboxNameCat, List<Category> catList)
        {
            if (TxtFilled(txtboxNameCat))
            {
                if (CategoryUnique(txtboxNameCat, catList))
                {
                    return true;
                }
            }
            return false;
        }


        public static bool ValidateSaveCategory(TextBox txtboxNameCat, List<Category> catList, ListBox listBoxCat)
        {
            if (TxtFilled(txtboxNameCat))
            {
                if (CategoryUnique(txtboxNameCat, catList))
                {
                    if (ListBoxIsSelected(listBoxCat))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public static bool ValidateChanges(ListView listviewPod, TextBox txtboxNamePod)
        {
            if (ListViewIsSelected(listviewPod))
            {
                if (TxtFilled(txtboxNamePod))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsPodcastSelected(ListView listViewPodcast)
        {
            return ListViewIsSelected(listViewPodcast);
        }

        public static bool ValidateRemoveIsSelected(ListBox listBox)
        {
            return ListBoxIsSelected(listBox);
        }

        public static bool ValidateCreatePodcast(ComboBox cbfrequency, ComboBox cbCategory, TextBox txtBox)
        {
            return (CbIsFilled(cbfrequency, cbCategory) && TxtFilled(txtBox));
            
        }
    }


    }