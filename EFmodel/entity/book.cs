using System.Collections.Generic;

namespace EFmodel.entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        // ავტორი
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        // კატეგორია
        public int? BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }

        // ვის უყვარს ეს წიგნი
        public List<UserFavoriteBook> FavoritedBy { get; set; } = new List<UserFavoriteBook>();

        // ქირაობის ისტორია
        public List<UserBookRentHistory> RentHistories { get; set; } = new List<UserBookRentHistory>();
    }
}