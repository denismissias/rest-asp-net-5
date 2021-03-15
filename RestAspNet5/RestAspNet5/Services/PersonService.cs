using System.Collections.Generic;
using RestAspNet5.Model;

namespace RestAspNet5.Service
{
    public class PersonService : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> Get()
        {
            throw new System.NotImplementedException();
        }

        public Person GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}