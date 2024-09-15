namespace DDD_Library.Domain.BooksProperties;

public record BookBasicInfo(
    List<Author> Authors, 
    string Title,
    string Description);
