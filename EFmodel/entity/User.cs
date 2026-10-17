using System;
using Microsoft.EntityFrameworkCore;

namespace EFmodel.entity
{
    public class User
    {
        public int Id { get; set; }

        // პირადი მონაცემები
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

        // კონტაქტი
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        // ანგარიში
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public DateTime? LastLoginDate { get; set; }

        // ბიბლიოთეკისთვის
        public string LibraryCardNumber { get; set; }
        public int BorrowedBooksCount { get; set; }

        [Precision(18, 2)]
        public decimal Balance { get; set; }
        public List<UserFavoriteBook> FavoriteBooks { get; set; } = new List<UserFavoriteBook>();
        public List<UserBookRentHistory> RentHistories { get; set; } = new List<UserBookRentHistory>();
    }
}