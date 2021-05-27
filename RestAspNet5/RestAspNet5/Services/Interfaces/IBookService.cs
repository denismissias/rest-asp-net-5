using System.Collections.Generic;
using RestAspNet5.Resources;

namespace RestAspNet5.Service
{
    public interface IBookService
    {
        List<BookResource> Get();

        BookResource GetById(long id);

        BookResource Create(BookResource person);

        BookResource Update(BookResource person);

        void Delete(long id);
    }
}