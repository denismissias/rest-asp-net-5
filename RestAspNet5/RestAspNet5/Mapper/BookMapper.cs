using System.Collections.Generic;
using System.Linq;
using RestAspNet5.Model;
using RestAspNet5.Resources;

namespace RestAspNet5.Mapper
{
    public class BookMapper<From, To> : IMapper<BookResource, Book>, IMapper<Book, BookResource>
    {
        public Book Map(BookResource from)
        {
            if (from == null) return null;

            return new Book
            {
                Id = from.Id,
                Title = from.Title,
                Author = from.Author,
                Price = from.Price,
                LaunchDate = from.LaunchDate
            };
        }

        public List<Book> Map(List<BookResource> from)
        {
            if (from == null) return null;

            return from.Select(item => Map(item)).ToList();
        }

        public BookResource Map(Book from)
        {
            if (from == null) return null;

            return new BookResource
            {
                Id = from.Id,
                Title = from.Title,
                Author = from.Author,
                Price = from.Price,
                LaunchDate = from.LaunchDate
            };
        }

        public List<BookResource> Map(List<Book> from)
        {
            if (from == null) return null;

            return from.Select(item => Map(item)).ToList();
        }
    }
}