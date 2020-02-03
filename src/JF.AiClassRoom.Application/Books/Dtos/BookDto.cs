using Abp.AutoMapper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace JF.AiClassRoom.Books.Dtos
{
    class BookMapperProfile : Profile
    {
        public BookMapperProfile()
        {
            CreateMap<Book, BookDto>().ForMember(dto => dto.BookName, opt => opt.MapFrom(info => info.Name));
        }
    }

    [AutoMapFrom(typeof(Book))]
    public class BookDto
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string BookName { get; set; }
    }
}
