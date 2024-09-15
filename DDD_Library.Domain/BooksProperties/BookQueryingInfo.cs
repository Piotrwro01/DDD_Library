namespace DDD_Library.Domain.BooksProperties;

public record BookQueryingInfo(
    bool IsPartOfSeries,
    string? SeriesName,
    //Ulid? SeriesUlid,
    Genre Genre);