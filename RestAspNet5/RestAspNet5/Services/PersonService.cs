using System.Collections.Generic;
using RestAspNet5.Model;
using RestAspNet5.Model.Context;
using System.Linq;
using RestAspNet5.Repository;

namespace RestAspNet5.Service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Create(Person person)
        {
            return _personRepository.Create(person);
        }

        public void Delete(long id)
        {
            _personRepository.Delete(id);
        }

        public List<Person> Get()
        {
            return _personRepository.Get();
        }

        public Person GetById(long id)
        {
            return _personRepository.GetById(id);
        }

        public Person Update(Person person)
        {
            return _personRepository.Update(person);
        }
    }
}