using Microsoft.EntityFrameworkCore;
using EFmodel.entity;

namespace EFmodel.Db
{
    public class libraryDbcontext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<UserFavoriteBook> UserFavoriteBooks { get; set; }
        public DbSet<UserBookRentHistory> UserBookRentHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=localhost;Initial Catalog=LibraryDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFavoriteBook>()
                .HasKey(f => new { f.UserId, f.BookId });
        }
    }
}