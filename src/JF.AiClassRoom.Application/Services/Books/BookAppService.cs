using JF.AiClassRoom.Books.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using JF.AiClassRoom.Books.DbEntity.Books;
using JF.AiClassRoom.Books.IRepositories.Books;
using JF.AiClassRoom.Common;
using JF.AiClassRoom.Dtos.Books;
using JF.AiClassRoom.Validation;

namespace JF.AiClassRoom.Services.Books
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
            await _bookRepository.DeleteBookById(ObjectMapper.Map<Book>(new BookDto { Id = id }));
            return new CommResult<bool> { Data = true, Msg = "删除书籍信息成功", Code = ErrorCode.Success };
        }

        public async Task<CommResult<bool>> DeleteBook(string bookName, string author)
        {
            BookDto customer = new BookDto { BookName = "1" };
            BookDtoValidator validator = new BookDtoValidator();

            ValidationResult result = validator.Validate(customer);

            await _bookRepository.DeleteBookWithParam(ObjectMapper.Map<Book>(new BookDto { BookName = bookName,Author = author}));
            return new CommResult<bool> { Data = true, Msg = "删除书籍信息成功", Code = ErrorCode.Success };
        }
    }
}
