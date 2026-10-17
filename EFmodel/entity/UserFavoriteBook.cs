using System;

namespace EFmodel.entity
{
    public class UserFavoriteBook
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public DateTime AddedDate { get; set; } = DateTime.Now;  // როდის დაამატა ფავორიტებში
        public int Rating { get; set; }                          // შეფასება 1-5
        public string Note { get; set; }                         // კომენტარი
    }
}