using AutoMapper;
using BookStore.BookOperations.GetBookDetail;
using BookStore.BookOperations.CreateBook;
using BookStore.BookOperations.GetBooks;

namespace BookStore.Common;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateBookCommand.CreateBookModel, Book>(); //CreateBookModel objesi, book objesine maplenebilir olsun
        CreateMap<Book, GetBookDetailQuery.BookDetailViewModel>()
            .ForMember(
                dest => dest.Genre,opt => opt.MapFrom(src=> ((GenreEnum)src.GenreID).ToString())); //Enum eşleştirme ayarı
        CreateMap<Book, GetBooksQuery.BooksViewModel>()
            .ForMember(
                dest => dest.Genre,opt => opt.MapFrom(src=> ((GenreEnum)src.GenreID).ToString())); //Enum eşleştirme ayarı
    }
}