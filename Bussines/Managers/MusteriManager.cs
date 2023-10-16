using Bussines.Interfaces;
using DataAccess.Interfaces;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Managers
{
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _dal;

        public MusteriManager(IMusteriDal dal)
        {
            _dal = dal;
        }
        public void Add(Musteri entity)
        {
            _dal.Add(entity);
        }

        public List<Musteri> GetAll()
        {
             return _dal.GetAll();
        }

        public List<Musteri> GetAll(int id)
        {
            return _dal.GetAll(x => x.Id == id);
        }

        public Musteri GetbyId(int id)
        {
            return _dal.GetById(id);
        }

        public void Remove(Musteri entity)
        {
           _dal.Remove(entity);
        }

        public void update(Musteri entity)
        {
           _dal.Update(entity);
        }
    }
}
