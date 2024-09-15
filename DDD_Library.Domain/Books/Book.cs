using DDD_Library.Domain.Abstractions;
using DDD_Library.Domain.BooksProperties;

namespace DDD_Library.Domain.Books;

public sealed class Book : Entity
{
    private Book(Ulid id, BookProperties bookProperties) 
        : base(id)
    {
        BookProperties = bookProperties;
    }

    public BookProperties BookProperties { get; private set; }

    public decimal Rating { get; private set; }
    public bool IsAvailable { get; private set; }

    public DateTime RentalStartDate { get; private set; }
    public DateTime? RentalPlanedEndDate { get; private set; }
    public DateTime RentalEndDate { get; private set; }

    public int HowManyTimesRented { get; private set; }






}
