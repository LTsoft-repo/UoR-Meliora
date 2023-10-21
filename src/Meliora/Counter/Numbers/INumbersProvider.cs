namespace Counter.Numbers;

public interface INumbersProvider<TOutput>
{
    IEnumerable<TOutput> GetRange( int start, int end );
}