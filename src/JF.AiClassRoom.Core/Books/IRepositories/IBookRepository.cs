using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JF.AiClassRoom.Books.IRepositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<IEnumerable<Book>> GetBookList(int pageIndex, int pageSize);
        Task<IEnumerable<Book>> GetBookByName(string bookName);
        Task<IEnumerable<Book>> GetBookById(int id);
        Task UpdateBook(Book book);
        Task CreateBook(Book book);
        Task DeleteBook(Book book);
        Task DeleteBook(string name,string writer);
    }
}
