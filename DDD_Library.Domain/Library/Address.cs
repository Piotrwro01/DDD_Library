namespace DDD_Library.Domain.Library;

public record Address(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street);