using AutoMapper;
using BookStore.Application.BookOperations.Commands;
using BookStore.Application.BookOperations.Queries;
using BookStore.Application.GenreOperations.Queries;
using BookStore.Entities;

namespace BookStore.Common;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateBookCommand.CreateBookModel, Book>(); //CreateBookModel objesi, book objesine maplenebilir olsun
        
        CreateMap<Book, GetBookDetailQuery.BookDetailViewModel>()
            .ForMember(
                dest => dest.Genre,opt => opt.MapFrom(src=> src.Genre.Name)); //Enum eşleştirme ayarı
        
        CreateMap<Book, GetBooksQuery.BooksViewModel>()
            .ForMember(
                dest => dest.Genre,opt => opt.MapFrom(src=> src.Genre.Name)); //Enum eşleştirme ayarı
        
        CreateMap<Genre, GenresViewModel>();
        CreateMap<Genre, GenreDetailViewModel>();
            
        CreateMap<Author, GetAuthorsQuery.AuthorsViewModel>();
        CreateMap<Author, GetAuthorDetailQuery.AuthorDetailViewModel>();
    }
}