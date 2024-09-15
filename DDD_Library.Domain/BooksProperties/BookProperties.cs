using DDD_Library.Domain.Abstractions;

namespace DDD_Library.Domain.BooksProperties;

public sealed class BookProperties  : Entity
{
    private BookProperties (Ulid id) : base (id)
    {
    }

    public string ISBNNumber { get; private set; }

    public List<string> Authors { get; private set; } = [];
    public string Title { get; private set; }
    public string CoverUrl { get; private set; }
    public string Description { get; private set; }

    public BookLevel BookLevel { get; private set; }
    public string Launguage { get; private set; }
    public int EditionNumber { get; private set; }
    public string Publisher { get; private set; }
    public DateOnly PublicationDate { get; private set; }
    public bool IsPartOfSeries { get; private set; }
    public string? SeriesName { get; private set; }
    public string Genre { get; private set; }

}
