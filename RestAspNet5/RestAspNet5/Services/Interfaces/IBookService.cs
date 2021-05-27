using System.Collections.Generic;
using RestAspNet5.Model;

namespace RestAspNet5.Service
{
    public interface IBookService
    {
        List<Book> Get();

        Book GetById(long id);

        Book Create(Book person);

        Book Update(Book person);

        void Delete(long id);
    }
}