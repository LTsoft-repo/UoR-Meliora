﻿namespace NumberUtils.Numbers;

public class NumbersProvider : INumbersProvider<int>
{
    public virtual IEnumerable<int> GetRange( int start, int end )
    {
        var size = end - start;
        var count = Math.Abs( size ) + 1;
        var step = Math.Sign( size );

        return Enumerable.Range( 0, count ).Select( i => start + i * step );
    }
}