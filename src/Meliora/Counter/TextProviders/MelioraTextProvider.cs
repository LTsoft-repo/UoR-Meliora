using Counter.Numbers;

namespace Counter.TextProviders;

public class MelioraTextProvider : TextProviderInvariantCulture<int>
{
    private readonly IMultipleChecker multipleChecker;

    public MelioraTextProvider( IMultipleChecker multipleChecker )
    {
        this.multipleChecker = multipleChecker;
    }

    public override string GetText( int number )
    {
        var isMultipleOf3 = multipleChecker.IsMultiple( number, 3 );
        var isMultipleOf7 = multipleChecker.IsMultiple( number, 7 );

        var specialTextList = Enumerable.Empty<string>().ToList();

        if( isMultipleOf3 )
        {
            specialTextList.Add( "Nursing" );
        }

        if( isMultipleOf7 )
        {
            specialTextList.Add( "Meliora" );
        }

        return specialTextList.Any() ? string.Join( " ", specialTextList ) : base.GetText( number );
    }
}