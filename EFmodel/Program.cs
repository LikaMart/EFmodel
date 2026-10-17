using EFmodel.Db;
using EFmodel.entity;

using var db = new libraryDbcontext();

var user = new User
{
    FirstName = "ნინო",
    LastName = "ბერიძე",
    PersonalNumber = "01001012345",
    BirthDate = new DateTime(2000, 5, 10),
    Gender = "F",
    Email = "nino@mail.ge",
    PhoneNumber = "555123456",
    City = "თბილისი",
    Address = "რუსთაველის 1",
    UserName = "nino",
    PasswordHash = "123",
    LibraryCardNumber = "LC001"
};
db.Users.Add(user);
db.SaveChanges();

var book = db.Books.First();   // ბაზაში უკვე არსებული პირველი წიგნი
db.UserFavoriteBooks.Add(new UserFavoriteBook { UserId = user.Id, BookId = book.Id, Rating = 5, Note = "საუკეთესო!" });
db.SaveChanges();

Console.WriteLine("ფავორიტი დაემატა!");