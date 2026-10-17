using System;
using System.Collections.Generic;

namespace EFmodel.entity
{
    public class BookCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }              // მაგ: "რომანი", "პოეზია", "ისტორია"
        public string Description { get; set; }       // აღწერა
        public bool IsActive { get; set; } = true;    // აქტიურია თუ არა
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public List<Book> Books { get; set; } = new List<Book>();   // ამ კატეგორიის წიგნები
    }
}