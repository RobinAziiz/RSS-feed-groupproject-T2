using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Windows.Forms;

namespace DataAccesLayer
{
    internal class SerializerForXml
    {
        public void SerializeCreate (string fileName)
        {
            try
            {
                using (FileStream outFile = new FileStream(fileName, FileMode.Create))
                {
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void SerializeAppend<T>(List<T> entityList, string fileName)
        {
            try
            {
                DeleteFile(fileName);
                XmlSerializer xmlSerializer = new XmlSerializer(entityList.GetType());
                using (FileStream outFile = new FileStream(fileName, FileMode.Create,
                    FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, entityList);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<Podcast> Deserialize(string fileName)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream(fileName, FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Podcast>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                List<Podcast> hej = new List<Podcast>();
                return hej;
            }
        }
        public void DeleteFile(string path)
        {
            File.Delete(path);
        }
     }
}