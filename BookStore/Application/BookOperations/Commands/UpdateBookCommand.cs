using BookStore.DbOperations;

namespace BookStore.Application.BookOperations.Commands;

public class UpdateBookCommand
{
    private readonly BookStoreDbContext _dbContext;
    public int BookId { get; set; }
    public UpdateBookViewModel Model { get; set; }
    
    public UpdateBookCommand(BookStoreDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Handle()
    {
        var book = _dbContext.Books.SingleOrDefault(x => x.Id == BookId);
        if (book is null)
        {
            throw new InvalidOperationException("Güncellenecek Kitap Bulunamadı!");
        }

        book.GenreID = Model.GenreID != default ? Model.GenreID : book.GenreID;
        //If updatedBook's GenreID has changed, change it. If not changed, use default value
        book.Title = Model.Title != default ? Model.Title : book.Title;
        _dbContext.SaveChanges();
    }
    
    public class UpdateBookViewModel
    {
        public string Title { get; set; }
        public int GenreID { get; set; }
        public int AuthorId { get; set; }
    }
    
}