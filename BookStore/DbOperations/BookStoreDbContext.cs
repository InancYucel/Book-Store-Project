using BookStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DbOperations;

public class BookStoreDbContext : DbContext
{
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
    {
    }
    public DbSet<Book> Books { get; set; } //Book Entity'si. Book Class'ından database'da Books tablosunu işaret ettik
    public DbSet<Genre> Genres { get; set; }
}