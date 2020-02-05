using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using JF.AiClassRoom.Common;
using JF.AiClassRoom.Dtos.Books;

namespace JF.AiClassRoom.Services.Books
{
    public interface IBookAppService : IApplicationService
    {
        /// <summary>
        /// 获取书籍数据
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<CommResult<List<BookDto>>> GetBookList(int pageIndex, int pageSize);
        /// <summary>
        /// 通过数据名称获取书籍书籍
        /// </summary>
        /// <param name="bookName"></param>
        /// <returns></returns>
        Task<CommResult<List<BookDto>>> GetBookByName(string bookName);
        /// <summary>
        /// 通过数据名称获取书籍书籍
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CommResult<List<BookDto>>> GetBookById(int id);
        /// <summary>
        /// 添加书籍书籍
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        Task<CommResult<bool>> CreateBook(BookDto book);
        /// <summary>
        /// 更新书籍全部信息
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        Task<CommResult<bool>> UpdateBookAll(BookDto book);
        /// <summary>
        /// 更新书籍部分信息
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        Task<CommResult<bool>> UpdateBookParts(BookDto book);
        /// <summary>
        /// 通过id删除书籍信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CommResult<bool>> DeleteBookById(int id);
        /// <summary>
        /// 通过多个条件删除书籍信息
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="author"></param>
        /// <returns></returns>
        Task<CommResult<bool>> DeleteBook(string bookName,string author);
    }
}
