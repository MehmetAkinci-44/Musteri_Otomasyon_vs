using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface IGenericServices<T> where T : class
    {
        public void Add(T entity);
        public void Remove(T entity);
        public void update(T entity);
        public T GetbyId(int id);
        public List<T> GetAll();
        public List<T> GetAll(int id);

    }
}
