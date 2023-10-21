namespace Counter.Numbers;

public interface INumberCounter<TOutput>
{
    IEnumerable<TOutput> Count( int start, int end );
}