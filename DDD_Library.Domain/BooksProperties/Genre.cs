namespace DDD_Library.Domain.BooksProperties;

public record Genre(
    int Index,
    string Value)
{
    static Genre Action = new(1, "Akcji");
    static Genre Fiction = new(2, "Fikcja");
    static Genre Romance = new(3, "Romans");

}
