using DDD_Library.Domain.Abstractions;

namespace DDD_Library.Domain.BooksProperties;

public abstract class BookLevel : Enumeration<BookLevel>
{
    public static readonly BookLevel GlobalLevel = new GlobalLevelBook();
    public static readonly BookLevel ResearchLevel = new ResearchLevelBook();
    public static readonly BookLevel OnlyOnSiteLevel = new OnlyOnSiteLevelBook();

    private readonly double deductionDayliAmountMultiplayer;

    protected BookLevel(int value, string name) 
        : base(value, name) 
    {
    }

    // deduction amount based on BookLevel / per day of delay
    public abstract double DeductionDayliAmountMultiplayer { get; }


    // hardcoded enums-like classes with parameters into constructors
    private sealed class GlobalLevelBook : BookLevel
    {        
        private new readonly double deductionDayliAmountMultiplayer = 1.0d;

        public GlobalLevelBook()
            : base(1, "GlobalLevel")
        {
        }

        public override double DeductionDayliAmountMultiplayer
            => deductionDayliAmountMultiplayer;
    }

    private sealed class ResearchLevelBook : BookLevel
    {
        private new readonly double deductionDayliAmountMultiplayer = 4.0d;

        public ResearchLevelBook()
            : base(2, "ResearchLevel")
        {
        }

        public override double DeductionDayliAmountMultiplayer
            => deductionDayliAmountMultiplayer;
    }

    private sealed class OnlyOnSiteLevelBook : BookLevel
    {
        private new readonly double deductionDayliAmountMultiplayer = 10.0d;

        public OnlyOnSiteLevelBook()
            : base(3, "OnlyOnSiteLevel")
        {
        }

        public override double DeductionDayliAmountMultiplayer
            => deductionDayliAmountMultiplayer;
    }


}