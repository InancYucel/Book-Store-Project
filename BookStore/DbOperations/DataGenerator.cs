using Microsoft.EntityFrameworkCore;

namespace BookStore.DbOperations;

public class DataGenerator
{
    public static void
        Initialize(IServiceProvider serviceProvider) //Uygulama ayağa kalktığında hep çalışacak bir yapı kurmaya çalışıyoruz. Program.cs'den çağıracağız
    {
        using (var context =
               new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
        {
            if (context.Books.Any()) //Eğer zaten veri varsa hiç çalıştırma
            {
                return;
            }

            context.Books.AddRange(
                new Book
                {
                    Title = "Lean Startup",
                    GenreID = 1, // Personal Growth
                    PageCount = 200,
                    PublishDate = new DateTime(2001, 06, 12)
                },
                new Book
                {
                    Title = "Herland",
                    GenreID = 1, // Science Fiction
                    PageCount = 250,
                    PublishDate = new DateTime(2010, 05, 23)
                },
                new Book
                {
                    Title = "Dune",
                    GenreID = 1, // Science Fiction
                    PageCount = 540,
                    PublishDate = new DateTime(2001, 12, 21)
                });
            context.SaveChanges();
        }
    }
}