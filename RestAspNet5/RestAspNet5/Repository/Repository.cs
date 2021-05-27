using System.Collections.Generic;
using RestAspNet5.Model;
using RestAspNet5.Model.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RestAspNet5.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        MySQLContext _context;

        private DbSet<T> dataset;

        public Repository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public T Create(T entity)
        {
            try
            {
                dataset.Add(entity);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }

            return entity;
        }

        public void Delete(long id)
        {
            try
            {
                T currentEntity = GetEntityById(id);

                if (currentEntity != null)
                {
                    dataset.Remove(currentEntity);
                    _context.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public List<T> Get()
        {
            return dataset.ToList();
        }

        public T GetById(long id)
        {
            return GetEntityById(id);
        }

        public T Update(T entity)
        {
            try
            {
                T currentEntity = GetEntityById(entity.Id);

                if (currentEntity == null)
                    return null;

                _context.Entry(currentEntity).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }

            return entity;
        }

        private T GetEntityById(long id)
        {
            return dataset.SingleOrDefault(p => p.Id == id);
        }
    }
}