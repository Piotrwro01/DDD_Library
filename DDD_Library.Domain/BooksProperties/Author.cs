namespace DDD_Library.Domain.BooksProperties;


// later connection to db.Authors
public record Author(Ulid Index, string Name, string Surname);
