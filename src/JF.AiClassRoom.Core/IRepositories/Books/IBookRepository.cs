using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JF.AiClassRoom.Books.DbEntity.Books;

namespace JF.AiClassRoom.Books.IRepositories.Books
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<IEnumerable<Book>> GetBookList(int pageIndex, int pageSize);
        Task<IEnumerable<Book>> GetBookByName(string bookName);
        Task<IEnumerable<Book>> GetBookById(int id);
        Task UpdateBook(Book book);
        Task CreateBook(Book book);
        Task DeleteBookById(Book book);
        Task DeleteBookWithParam(Book book);
    }
}
