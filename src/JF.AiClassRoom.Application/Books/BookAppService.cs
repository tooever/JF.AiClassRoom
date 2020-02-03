using Abp.Application.Services.Dto;
using JF.AiClassRoom.Books.Dtos;
using JF.AiClassRoom.Books.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JF.AiClassRoom.Common;

namespace JF.AiClassRoom.Books
{
    [IgnoreAntiforgeryToken]
    public class BookAppService : AiClassRoomAppServiceBase, IBookAppService
    {
        private readonly IBookRepository _bookRepository;
        public BookAppService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<CommResult<List<BookDto>>> GetBookList(int pageIndex, int pageSize)
        {
            var bookList = await _bookRepository.GetBookList();
            return new CommResult<List<BookDto>> { Data = ObjectMapper.Map<List<BookDto>>(bookList) ,Msg = "获取数据成功",Code=ErrorCode.Success};
        }
        public async Task CreateBook(BookDto book)
        {
            await _bookRepository.CreateBook(ObjectMapper.Map<Book>(book));
        }
        public async Task DeleteBook(int id)
        {
            await _bookRepository.DeleteBook(ObjectMapper.Map<Book>(new BookDto { Id = id }));
        }
    }
}
