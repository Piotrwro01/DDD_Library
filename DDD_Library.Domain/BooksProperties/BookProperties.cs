using DDD_Library.Domain.Abstractions;

namespace DDD_Library.Domain.BooksProperties;

public sealed class BookProperties  : Entity
{
    private BookProperties (Ulid id) : base (id)
    {
    }

    public ISBN InternationalStandardBookNumber { get; private set; }

    public BookLevel BookLevel { get; private set; }

    public BookBasicInfo BookBasicInfo { get; private set; }

    public BookPublicationDetails BookPublicationDetails { get; private set; }

    public BookQueryingInfo BookQueryingInfo { get; private set; }

}
