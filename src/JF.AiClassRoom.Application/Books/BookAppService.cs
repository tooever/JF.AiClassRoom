using Abp.Application.Services.Dto;
using JF.AiClassRoom.Books.Dtos;
using JF.AiClassRoom.Books.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JF.AiClassRoom.Common;

namespace JF.AiClassRoom.Books
{
    public class BookAppService : AiClassRoomAppServiceBase, IBookAppService
    {
        private readonly IBookRepository _bookRepository;
        public BookAppService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<CommResult<List<BookDto>>> GetBookList(int pageIndex, int pageSize)
        {
            var bookList = await _bookRepository.GetBookList(pageIndex, pageSize);
            return new CommResult<List<BookDto>> { Data = ObjectMapper.Map<List<BookDto>>(bookList), Msg = "获取数据成功", Code = ErrorCode.Success };
        }
        public async Task<CommResult<List<BookDto>>> GetBookByName(string bookName)
        {
            var bookList = await _bookRepository.GetBookByName(bookName);
            return new CommResult<List<BookDto>> { Data = ObjectMapper.Map<List<BookDto>>(bookList), Msg = "获取数据成功", Code = ErrorCode.Success };
        }
        public async Task<CommResult<List<BookDto>>> GetBookById(int id)
        {
            var bookList = await _bookRepository.GetBookById(id);
            return new CommResult<List<BookDto>> { Data = ObjectMapper.Map<List<BookDto>>(bookList), Msg = "获取数据成功", Code = ErrorCode.Success };
        }
        public async Task<CommResult<bool>> CreateBook(BookDto book)
        {
            await _bookRepository.CreateBook(ObjectMapper.Map<Book>(book));
            return new CommResult<bool> { Data = true, Msg = "添加书籍信息成功", Code = ErrorCode.Success };
        }
        public async Task<CommResult<bool>> UpdateBookAll(BookDto book)
        {
            await _bookRepository.UpdateBook(ObjectMapper.Map<Book>(book));
            return new CommResult<bool> { Data = true, Msg = "更新书籍全部信息成功", Code = ErrorCode.Success };
        }
        public async Task<CommResult<bool>> UpdateBookParts(BookDto book)
        {
            await _bookRepository.UpdateBook(ObjectMapper.Map<Book>(book));
            return new CommResult<bool> { Data = true, Msg = "更新书籍部分信息成功", Code = ErrorCode.Success };
        }
        public async Task<CommResult<bool>> DeleteBookById(int id)
        {
            await _bookRepository.DeleteBook(ObjectMapper.Map<Book>(new BookDto { Id = id }));
            return new CommResult<bool> { Data = true, Msg = "删除书籍信息成功", Code = ErrorCode.Success };
        }

        public async Task<CommResult<bool>> DeleteBook(string bookName, string author)
        {
            await _bookRepository.DeleteBook(bookName, author);
            return new CommResult<bool> { Data = true, Msg = "删除书籍信息成功", Code = ErrorCode.Success };
        }
    }
}
