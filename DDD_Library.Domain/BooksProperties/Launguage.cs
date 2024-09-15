using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Library.Domain.BooksProperties;

public record Launguage(int Index, string Name)
{
    public static Launguage Polish = new(1, "Polski");
    public static Launguage English = new(2, "Angielski");
    public static Launguage Espanol = new(3, "Hiszpański");
};
