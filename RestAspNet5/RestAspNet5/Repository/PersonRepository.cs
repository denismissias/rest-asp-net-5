using System.Collections.Generic;
using RestAspNet5.Model;
using RestAspNet5.Model.Context;
using System.Linq;

namespace RestAspNet5.Repository
{
    public class PersonRepository : IPersonRepository
    {
        MySQLContext _context;

        public PersonRepository(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }

            return person;
        }

        public void Delete(long id)
        {
            try
            {
                Person currentPerson = GetPersonById(id);

                if (currentPerson != null)
                {
                    _context.People.Remove(currentPerson);
                    _context.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public List<Person> Get()
        {
            return _context.People.ToList();
        }

        public Person GetById(long id)
        {
            return GetPersonById(id);
        }

        public Person Update(Person person)
        {
            try
            {
                Person currentPerson = GetPersonById(person.Id);

                if (currentPerson == null)
                    return null;

                _context.Entry(currentPerson).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }

            return person;
        }

        private Person GetPersonById(long id)
        {
            return _context.People.SingleOrDefault(p => p.Id == id);
        }
    }
}