using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Syndication;

namespace DataAccessLayer.Repositories
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Delete(T entity);
        void SaveChanges();
        List<T> GetAll();
    }
}       