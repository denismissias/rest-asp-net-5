using System.Collections.Generic;
using RestAspNet5.Model;
using RestAspNet5.Resources;

namespace RestAspNet5.Service
{
    public interface IPersonService
    {
        List<PersonResource> Get();

        PersonResource GetById(long id);

        PersonResource Create(PersonResource person);

        PersonResource Update(PersonResource person);

        void Delete(long id);
    }
}