using DataAccesLayer;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository: Repository<Category>, IRepository<Category>
    {
            public CategoryRepository()
        {
            entityList = new List<Category>();
            entityList = GetAll();
            dataManager = new SerializerForXml();

        }
        public override List<Category> GetAll()
        {
            entityList = new List<Category>();
            string[] categoriesArray = Directory.GetFiles(@"..\Debug\", "*.XML");
            foreach (string category in categoriesArray)
            {
                entityList.Add(new Category(Path.GetFileName(category).Split('.')[0])); 
            }
            return entityList;
        }
       
        public override void Append(Category category)
        {
            dataManager.SerializeCreate(category.Name + ".xml");
        }
        public void DeleteAllPodcasts()
        {
            foreach (Category category in entityList)
            {
                dataManager.SerializeCreate(category.Name + ".xml");
            }
        }
        public override void Delete(Category categoryToDelete)
        {
            for (int i = 0; i < entityList.Count(); i++)
            {
                if (categoryToDelete.Name.Equals(entityList[i].Name))
                {
                    entityList.RemoveAt(i);
                }
            }
            dataManager.DeleteFile(categoryToDelete.Name + ".xml");
        }

    }
}
