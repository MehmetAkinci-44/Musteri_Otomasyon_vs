using DataAccess.Context;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepositories<T> : IRepositories<T> where T : class
    {
        public void Add(T entity)
        {
            using var context = new context_musteri();
            context.Add(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new context_musteri();
            List<T> list = context.Set<T>().ToList();
            return list;
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            using var context = new context_musteri();
            List<T> list = context.Set<T>().Where(filter).ToList();
            return list;
        }

        public T GetById(int id)
        {
            using var context = new context_musteri();
            T entity = context.Set<T>().Find(id);
            return entity;
        }

        public void Remove(T entity)
        {
            using var context = new context_musteri();
            context.Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
           using var context = new context_musteri();
           context.Update(entity);
           context.SaveChanges();
        }
    }
}
