using System.Collections.Generic;
using System.Linq;
using RestAspNet5.Model;
using RestAspNet5.Resources;

namespace RestAspNet5.Mapper
{
    public class PersonMapper<From, To> : IMapper<PersonResource, Person>, IMapper<Person, PersonResource>
    {
        public Person Map(PersonResource from)
        {
            if (from == null) return null;

            return new Person
            {
                Id = from.Id,
                FirstName = from.FirstName,
                LastName = from.LastName,
                Address = from.Address,
                Gender = from.Gender
            };
        }

        public List<Person> Map(List<PersonResource> from)
        {
            if (from == null) return null;

            return from.Select(item => Map(item)).ToList();
        }

        public PersonResource Map(Person from)
        {
            if (from == null) return null;

            return new PersonResource
            {
                Id = from.Id,
                FirstName = from.FirstName,
                LastName = from.LastName,
                Address = from.Address,
                Gender = from.Gender
            };
        }

        public List<PersonResource> Map(List<Person> from)
        {
            if (from == null) return null;

            return from.Select(item => Map(item)).ToList();
        }
    }
}