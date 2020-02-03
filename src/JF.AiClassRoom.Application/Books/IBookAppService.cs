using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JF.AiClassRoom.Books.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace JF.AiClassRoom.Books
{
    public interface IBookAppService : IApplicationService
    {
        [HttpGet]
        Task<ListResultDto<BookDto>> GetBookList();

        [HttpPost]
        Task CreateBook(BookDto book);
    }
}
