using System.Collections.Generic;
using RestAspNet5.Model;

namespace RestAspNet5.Repository
{
    public interface IPersonRepository
    {
        List<Person> Get();

        Person GetById(long id);

        Person Create(Person person);

        Person Update(Person person);

        void Delete(long id);
    }
}