namespace Counter.Numbers;

public class NumberCounter : INumberCounter<int>
{
    public IEnumerable<int> Count( int start, int end )
    {
        var size = end - start;
        var count = Math.Abs( size ) + 1;
        var step = Math.Sign( size );

        return Enumerable.Range( 0, count ).Select( i => start + i * step );
    }
}