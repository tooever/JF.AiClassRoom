using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JF.AiClassRoom.Books.IRepositories
{
    public interface IBookRepository : IRepository<Book>
    {
        public Task<IEnumerable<Book>> GetBookList();
        public Task CreateBook(Book book);
    }
}
