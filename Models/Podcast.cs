using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{
    public class Podcast
    {
        public string URL { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int Frequency { get; set; }
        public List<Episode> episodes;
        public Podcast(string name, string description, Category category, int frequency, List<Episode> episodes, string url)
        {
            Name = name;
            Description = description;
            Category = category;
            Frequency = frequency;
            this.episodes = episodes;
            URL = url;
        }

        public Podcast()
        {

        }
        public string Display()
        {
            return Description;
        }
    }
}