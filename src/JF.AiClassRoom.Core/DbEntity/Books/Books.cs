using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JF.AiClassRoom.Books.DbEntity.Books
{
    [Table("book")]
    public class Book : Entity
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 书作者
        /// </summary>
        public string Writer { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public int Price { get; set; }

    }
}
