using System.Collections.Generic;
using RestAspNet5.Model;
using RestAspNet5.Repository;
using RestAspNet5.Mapper;
using RestAspNet5.Resources;

namespace RestAspNet5.Service
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _personRepository;

        private readonly IMapper<PersonResource, Person> _resourceToModelMapper;

        private readonly IMapper<Person, PersonResource> _modelToResourceMapper;

        public PersonService(IRepository<Person> personRepository, IMapper<PersonResource, Person> resourceToModelMapper, IMapper<Person, PersonResource> modelToResourceMapper)
        {
            _personRepository = personRepository;
            _resourceToModelMapper = resourceToModelMapper;
            _modelToResourceMapper = modelToResourceMapper;
        }

        public PersonResource Create(PersonResource person)
        {
            return _modelToResourceMapper.Map(_personRepository.Create(_resourceToModelMapper.Map(person)));
        }

        public void Delete(long id)
        {
            _personRepository.Delete(id);
        }

        public List<PersonResource> Get()
        {
            return _modelToResourceMapper.Map(_personRepository.Get());
        }

        public PersonResource GetById(long id)
        {
            return _modelToResourceMapper.Map(_personRepository.GetById(id));
        }

        public PersonResource Update(PersonResource person)
        {
            return _modelToResourceMapper.Map(_personRepository.Update(_resourceToModelMapper.Map(person)));
        }
    }
}