using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public List<T> entityList { get; set; }
       internal SerializerForXml dataManager;
        public virtual void Create(T entity)
        {
            entityList.Add(entity);
            Append(entity);
        }
        public virtual void Delete(T entity) { }
        public virtual List<T> GetAll()
        {
            return entityList;
        }
        public virtual void SaveChanges() { 
            //dataManager.SerializeAppend(entityList, )
        }
        public virtual void Append(T entity)
        {

        }
    }
}
