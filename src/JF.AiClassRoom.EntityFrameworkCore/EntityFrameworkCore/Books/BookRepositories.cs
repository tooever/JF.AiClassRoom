using Abp.Dapper.Repositories;
using JF.AiClassRoom.Books;
using JF.AiClassRoom.Books.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JF.AiClassRoom.EntityFrameworkCore.Books
{
    public class BookRepository : IBookRepository
    {
        private readonly IDapperRepository<Book> _bookDapperRepository;
        public BookRepository(IDapperRepository<Book> bookDapperRepository)
        {
            _bookDapperRepository = bookDapperRepository;
        }

        public Task<IEnumerable<Book>> GetBookList()
        {
            var bookList = _bookDapperRepository.QueryAsync<Book>("select * from book LIMIT 10");
            return bookList;
        }
        public Task CreateBook(Book book)
        {
            return _bookDapperRepository.InsertAsync(book);
        }
        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Book entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Book FirstOrDefault(int id)
        {
            throw new NotImplementedException();
        }

        public Book FirstOrDefault(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Book> FirstOrDefaultAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> FirstOrDefaultAsync(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Book> GetAllIncluding(params Expression<Func<Book, object>>[] propertySelectors)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllList()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllList(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllListAsync(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Book Insert(Book entity)
        {
            throw new NotImplementedException();
        }

        public int InsertAndGetId(Book entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAndGetIdAsync(Book entity)
        {
            throw new NotImplementedException();
        }

        public Task<Book> InsertAsync(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book InsertOrUpdate(Book entity)
        {
            throw new NotImplementedException();
        }

        public int InsertOrUpdateAndGetId(Book entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertOrUpdateAndGetIdAsync(Book entity)
        {
            throw new NotImplementedException();
        }

        public Task<Book> InsertOrUpdateAsync(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book Load(int id)
        {
            throw new NotImplementedException();
        }

        public long LongCount()
        {
            throw new NotImplementedException();
        }

        public long LongCount(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<long> LongCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<long> LongCountAsync(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Query<T>(Func<IQueryable<Book>, T> queryMethod)
        {
            throw new NotImplementedException();
        }

        public Book Single(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Book> SingleAsync(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book Update(int id, Action<Book> updateAction)
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateAsync(Book entity)
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateAsync(int id, Func<Book, Task> updateAction)
        {
            throw new NotImplementedException();
        }
    }
}
