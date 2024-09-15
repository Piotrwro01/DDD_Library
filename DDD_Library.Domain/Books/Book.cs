using DDD_Library.Domain.Abstractions;
using DDD_Library.Domain.Shared;

namespace DDD_Library.Domain.Books;

public sealed class Book : Entity
{
    private Book(Ulid id) : base(id)
    {
    }

    public EditionProperties EditionProperties { get; private set; } 

    public decimal Rating { get; private set; }
    public bool IsAvailable { get; private set; }

    public DateTime RentalStartDate { get; private set; }
    public DateTime? RentalPlanedEndDate { get; private set; }
    public DateTime RentalEndDate { get; private set; }

    public int HowManyTimesRented { get; private set; }






}
