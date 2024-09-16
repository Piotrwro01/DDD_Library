
using DDD_Library.Domain.Abstractions;
using DDD_Library.Domain.Books;

namespace DDD_Library.Domain.Borrows;

public sealed class Borrow : Entity
{
    public Ulid BookId {  get; private set; }
    
    public Ulid LibraryId { get; private set; }

    public DateRange Duration { get; private set; }

    public BorrowStatus Status { get; private set; }

    public DateTime CreatedOnUtc { get; private set; }

    public DateTime? ConfirmedOnUtc { get; private set; }

    public DateTime? RejectedOnUtc { get; private set; }

    public DateTime? CompletedOnUtc { get; private set; }

    public DateTime? CancelledOnUtc { get; private set; }

    private Borrow(
        Ulid id,
        Book book) 
        : base(id)
    {

    }

}