using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JF.AiClassRoom.Books.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using JF.AiClassRoom.Common;

namespace JF.AiClassRoom.Books
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
        /// 添加书籍书籍
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        Task CreateBook(BookDto book);
        /// <summary>
        /// 删除书籍书籍
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteBook(int id);
    }
}
