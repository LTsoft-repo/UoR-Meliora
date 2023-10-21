namespace NumberUtils.Numbers;

public interface INumbersProvider<TOutput>
{
    IEnumerable<TOutput> GetRange( int start, int end );
}