using System.Collections.Generic;
using RestAspNet5.Model;
using RestAspNet5.Model.Context;
using System.Linq;
using RestAspNet5.Repository;

namespace RestAspNet5.Service
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _bookRepository;

        public BookService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book Create(Book book)
        {
            return _bookRepository.Create(book);
        }

        public void Delete(long id)
        {
            _bookRepository.Delete(id);
        }

        public List<Book> Get()
        {
            return _bookRepository.Get();
        }

        public Book GetById(long id)
        {
            return _bookRepository.GetById(id);
        }

        public Book Update(Book book)
        {
            return _bookRepository.Update(book);
        }
    }
}