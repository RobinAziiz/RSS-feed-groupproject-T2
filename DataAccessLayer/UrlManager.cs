using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DataAccessLayer
{
    public static class UrlManager
    {
        public static SyndicationFeed GetFeed(string URL)
        {
            try
            {
                XmlReader reader = XmlReader.Create(URL);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                Debug.WriteLine(URL + " Hämtad från GetFeed()" + DateTime.UtcNow + " " + (new StackTrace()).GetFrame(1).GetMethod().Name);
                return feed;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public static List<Episode> GetEpisodes(string URL)
        {
            return (from SyndicationItem item in GetFeed(URL).Items
                    select new Episode(item.Title.Text, item.Summary.Text)).ToList();

        }
    }

}