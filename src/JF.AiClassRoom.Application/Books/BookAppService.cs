using Abp.Application.Services.Dto;
using JF.AiClassRoom.Books.Dtos;
using JF.AiClassRoom.Books.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JF.AiClassRoom.Books
{
    public class BookAppService : AiClassRoomAppServiceBase, IBookAppService
    {
        private readonly IBookRepository _bookRepository;
        public BookAppService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<ListResultDto<BookDto>> GetBookList()
        {
            var bookList = await _bookRepository.GetBookList();
            return new ListResultDto<BookDto>(ObjectMapper.Map<List<BookDto>>(bookList));
        }

        public async Task CreateBook(BookDto book)
        {
            await _bookRepository.CreateBook(ObjectMapper.Map<Book>(book));
        }
    }
}
