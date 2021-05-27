using System.Collections.Generic;
using RestAspNet5.Model;

namespace RestAspNet5.Repository
{
    public interface IRepository<T> where T : Entity
    {
        List<T> Get();

        T GetById(long id);

        T Create(T entity);

        T Update(T entity);

        void Delete(long id);
    }
}