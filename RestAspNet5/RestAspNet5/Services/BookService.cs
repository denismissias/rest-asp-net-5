using System.Collections.Generic;
using RestAspNet5.Model;
using RestAspNet5.Model.Context;
using System.Linq;
using RestAspNet5.Repository;
using RestAspNet5.Mapper;
using RestAspNet5.Resources;

namespace RestAspNet5.Service
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _bookRepository;

        private readonly IMapper<BookResource, Book> _resourceToModelMapper;

        private readonly IMapper<Book, BookResource> _modelToResourceMapper;

        public BookService(IRepository<Book> bookRepository, IMapper<BookResource, Book> resourceToModelMapper, IMapper<Book, BookResource> modelToResourceMapper)
        {
            _bookRepository = bookRepository;
            _resourceToModelMapper = resourceToModelMapper;
            _modelToResourceMapper = modelToResourceMapper;
        }

        public BookResource Create(BookResource book)
        {
            return _modelToResourceMapper.Map(_bookRepository.Create(_resourceToModelMapper.Map(book)));
        }

        public void Delete(long id)
        {
            _bookRepository.Delete(id);
        }

        public List<BookResource> Get()
        {
            return _modelToResourceMapper.Map(_bookRepository.Get());
        }

        public BookResource GetById(long id)
        {
            return _modelToResourceMapper.Map(_bookRepository.GetById(id));
        }

        public BookResource Update(BookResource book)
        {
            return _modelToResourceMapper.Map(_bookRepository.Update(_resourceToModelMapper.Map(book)));
        }
    }
}