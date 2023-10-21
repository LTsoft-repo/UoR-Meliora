using Counter.TextProviders;

namespace Counter.Numbers;

public class MelioraNumbersProvider : INumbersProvider<string>
{
    private readonly INumbersProvider<int> numberProvider;
    private readonly ITextProvider<int> textProvider;

    public MelioraNumbersProvider( INumbersProvider<int> numberProvider, ITextProvider<int> textProvider )
    {
        this.numberProvider = numberProvider;
        this.textProvider = textProvider;
    }

    public virtual IEnumerable<string> GetRange( int start, int end ) => numberProvider.GetRange( start, end ).Select( textProvider.GetText );
}