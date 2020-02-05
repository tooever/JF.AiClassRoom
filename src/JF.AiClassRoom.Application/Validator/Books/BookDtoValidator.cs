using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dependency;
using FluentValidation;
using JF.AiClassRoom.Dtos.Books;

namespace JF.AiClassRoom.Validation
{
    public class BookDtoValidator: AbstractValidator<BookDto>
    {
        public BookDtoValidator()
        {
            RuleFor(x => x.BookName).NotEmpty().WithMessage("请输入书籍名称");
            RuleFor(x => x.Author).NotEmpty().WithMessage("请输入书籍作者");
        }
    }
}
