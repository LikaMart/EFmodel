using System;
using Microsoft.EntityFrameworkCore;

namespace EFmodel.entity
{
    public class UserBookRentHistory
    {
        public int Id { get; set; }

        // ვინ აიღო
        public int UserId { get; set; }
        public User User { get; set; }

        // რომელი წიგნი
        public int BookId { get; set; }
        public Book Book { get; set; }

        // თარიღები
        public DateTime RentDate { get; set; } = DateTime.Now;   // როდის აიღო
        public DateTime DueDate { get; set; }                    // როდემდე უნდა დააბრუნოს
        public DateTime? ReturnDate { get; set; }                // როდის დააბრუნა (ცარიელი = ჯერ არ დაუბრუნებია)

        // სტატუსი და გადახდა
        public bool IsReturned { get; set; } = false;            // დაბრუნებულია თუ არა
        public string Status { get; set; }                       // "Active", "Returned", "Overdue"

        [Precision(18, 2)]
        public decimal RentPrice { get; set; }                   // ქირის ფასი

        [Precision(18, 2)]
        public decimal Fine { get; set; }                        // ჯარიმა დაგვიანებისთვის

        public string Note { get; set; }                         // შენიშვნა
    }
}