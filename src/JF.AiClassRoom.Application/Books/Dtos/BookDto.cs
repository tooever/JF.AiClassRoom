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
            CreateMap<Book, BookDto>().ForMember(dto => dto.BookName, opt => opt.MapFrom(info => info.Name))
                                      .ForMember(dto => dto.Author, opt => opt.MapFrom(info => info.Writer));

            CreateMap<BookDto, Book>().ForMember(dto => dto.Name, opt => opt.MapFrom(info => info.BookName))
                                      .ForMember(dto => dto.Writer, opt => opt.MapFrom(info => info.Author));
        }
    }

    [AutoMapFrom(typeof(Book))]
    public class BookDto
    {
        public int Id { get; set; }
        /// <summary>
        /// 书名
        /// </summary>
        public string BookName { get; set; }
        /// <summary>
        /// 书作者
        /// </summary>
        public  string Author { get; set; }
    }
}
