namespace DDD_Library.Domain.BooksProperties;

public record BookPublicationDetails
    (string CoverUrl,
    Launguage Launguage,
    int EditionNumber,
    string Publisher,
    DateOnly PublicationDate)
{
    // later to make it prompt only rome numbers
    public int GetRomeEditionNumber => EditionNumber;
}
