using MkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MkCodeFirst.Repository
{
    public class Repository<S> : IRepository<S> where S : class
    {

        private EmployeeContext entities = null;
        //IObjectSet<S> _objectSet;
        IDbSet<S> _objectSet;

        public Repository(EmployeeContext _entities)
        {

            entities = _entities;

            //_objectSet = entities.CreateObjectSet<S>();

            _objectSet = entities.Set<S>();





        }

        

        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<S> GetAll()
        {
            return _objectSet.AsEnumerable();
        }

        public S GetById(object Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(S obj)
        {
            _objectSet.Add(obj);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(S obj)
        {
            throw new NotImplementedException();
        }
    }
}