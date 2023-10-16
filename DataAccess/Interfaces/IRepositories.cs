using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IRepositories<T> where T : class
    {
        public void Add(T entity);
        public void Remove(T entity);
        public void Update(T entity);
        public T GetById(int id);
        public List<T> GetAll();
        public List<T> GetAll(Expression<Func<T, bool>> filter);
    }
}
