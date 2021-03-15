using System.Collections.Generic;
using RestAspNet5.Model;

namespace RestAspNet5.Service
{
    public interface IPersonService
    {
        List<Person> Get();

        Person GetById(long id);

        Person Create(Person person);

        Person Update(Person person);

        void Delete(long id);
    }
}