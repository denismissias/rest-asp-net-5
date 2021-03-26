using System.Collections.Generic;
using RestAspNet5.Model;
using RestAspNet5.Model.Context;
using System.Linq;

namespace RestAspNet5.Service
{
    public class PersonService : IPersonService
    {
        MySQLContext _context;

        public PersonService(MySQLContext context)
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
            catch (System.Exception ex)
            {
                throw ex;
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
            catch (System.Exception ex)
            {
                throw ex;
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
            catch (System.Exception ex)
            {
                throw ex;
            }

            return person;
        }

        private Person GetPersonById(long id)
        {
            return _context.People.SingleOrDefault(p => p.Id == id);
        }
    }
}