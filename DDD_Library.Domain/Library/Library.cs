using DDD_Library.Domain.Abstractions;
using DDD_Library.Domain.Books;

namespace DDD_Library.Domain.Library;

public sealed class Library : Entity
{
    private Library(
        Ulid id,
        Name name,
        Address address,
        DateOnly openedDate) 
        : base(id) 
    {
        Name = name;
        Address = address;
        OpenedDate = openedDate;
    }

    public Name Name { get; private set; } 

    public Address Address { get; private set; } 

    public List<Book> Books { get; private set; } = [];

    public DateOnly OpenedDate { get; private set; }

    public bool IsClosed { get; private set; } = false;

    public bool IsOpened => !IsClosed;


    public Result AddBooks()
    {
        throw new NotImplementedException();
    }

    public Result RemoveBooks()
    {
        throw new NotImplementedException();
    }






}
