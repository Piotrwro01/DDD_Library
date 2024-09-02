using DDD_Library.Domain.Abstractions;

namespace DDD_Library.Domain.Books;

public sealed class Book : Entity
{
    private Book(Ulid id) : base(id)
    {
    }

    public string ISBNNumber { get; private set; }

    public string Author { get; private set; }
    public string Title { get; private set; }
    public string CoverUrl { get; private set; }
    public string Description { get; private set; }

    public string Form { get; private set; }
    public string Launguage { get; private set; }
    public int EditionNumber { get; private set; }
    public string Publisher { get; private set; }
    public DateOnly PublicationDate  { get; private set;}
    public bool IsPartOfSeries { get; private set; }
    public string? SeriesName { get; private set; }
    public string Genre { get; private set; }

    public decimal Rating { get; private set; }
    public bool IsAvailable { get; private set; }

    public DateTime RentalStartDate { get; private set; }
    public DateTime? RentalPlanedEndDate { get; private set; }
    public DateTime RentalEndDate { get; private set; }

    public int HowManyTimesRented { get; private set; }






}
