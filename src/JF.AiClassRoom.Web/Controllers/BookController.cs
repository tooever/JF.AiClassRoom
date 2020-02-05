using Abp.AspNetCore.Mvc.Controllers;
using JF.AiClassRoom.Books;
using JF.AiClassRoom.Books.Dtos;
using JF.AiClassRoom.Common;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JF.AiClassRoom.Web.Controllers
{
    [IgnoreAntiforgeryToken]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : AbpController
    {
        private readonly IBookAppService _bookService;
        public BookController(IBookAppService bookAppService)
        {
            _bookService = bookAppService;
        }

        /// <summary>
        /// 获取书籍列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<CommResult<List<BookDto>>> Get(int pageIndex, int pageSize)
        {
            return await _bookService.GetBookList(pageIndex, pageSize);
        }
        /// <summary>
        /// 通过书籍名称获取书籍列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetBookByName/{booName}")]
        public async Task<CommResult<List<BookDto>>> Get(string booName)
        {
            return await _bookService.GetBookByName(booName);
        }
        /// <summary>
        /// 通过书籍id获取书籍列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<CommResult<List<BookDto>>> Get(int id)
        {
            return await _bookService.GetBookById(id);
        }

        /// <summary>
        /// 新增书籍书籍
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<CommResult<bool>> Post(BookDto book)
        {
            //InsertAndGetIdAsync 添加数据并返回主键
            return await _bookService.CreateBook(book);
        }

        /// <summary>
        ///PUT 修改书籍全部数据(主键不变)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<CommResult<bool>> Put(BookDto book)
        {
            return await _bookService.UpdateBookAll(book);
        }

        /// <summary>
        /// Pathch 修改书籍分属性(主键不变)
        /// </summary>
        /// <returns></returns>
        [HttpPatch]
        public async Task<CommResult<bool>> Pathch(BookDto book)
        {
            return await _bookService.UpdateBookParts(book);
        }

        /// <summary>
        /// 通过id删除书籍书籍
        /// </summary>
        /// <returns></returns>
        [HttpDelete("DeleteBookById/{id}")]
        public async Task<CommResult<bool>> DeleteBookById(int id)
        {
            return await _bookService.DeleteBookById(id);
        }
        /// <summary>
        /// 通过书籍名称和作者删除书籍
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="author"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<CommResult<bool>> Delete(string bookName, string author)
        {
            return await _bookService.DeleteBook(bookName, author);
        }
    }
}