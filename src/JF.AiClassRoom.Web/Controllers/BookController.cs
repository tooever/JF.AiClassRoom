using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Controllers;
using JF.AiClassRoom.Books;
using JF.AiClassRoom.Books.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JF.AiClassRoom.Web.Controllers
{
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
        public async Task<ListResultDto<BookDto>> Get(int pageIndex, int pageSize)
        {
            return await _bookService.GetBookList(pageIndex, pageSize);
        }
    }
}