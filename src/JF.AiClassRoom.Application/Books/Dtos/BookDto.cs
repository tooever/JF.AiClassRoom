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
            CreateMap<BookDto, Book>().ForMember(dto => dto.Name, opt => opt.MapFrom(info => info.BookName));
        }
    }

    [AutoMapFrom(typeof(Book))]
    public class BookDto
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string BookName { get; set; }
        public int Id { get; set; }
    }
}
