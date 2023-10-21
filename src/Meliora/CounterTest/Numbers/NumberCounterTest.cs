using Counter.Numbers;

namespace CounterTest.Numbers;

public class NumberCounterTest
{
    [ Theory ]
    [ InlineData( 1, 1, new[] { 1 } ) ]
    [ InlineData( 1, 2, new[] { 1, 2 } ) ]
    [ InlineData( 1, 5, new[] { 1, 2, 3, 4, 5 } ) ]
    [ InlineData( 5, 1, new[] { 5, 4, 3, 2, 1 } ) ]
    [ InlineData( -5, 1, new[] { -5, -4, -3, -2, -1, 0, 1 } ) ]
    [ InlineData( 0, 1, new[] { 0, 1 } ) ]
    [ InlineData( 0, -2, new[] { 0, -1, -2 } ) ]
    public void Count_StartNumberEndNumber_Successfully( int startNumber, int endNumber, int[] expected )
    {
        // Arrange
        INumberCounter<int> counter = new NumberCounter();

        // Act
        var result = counter.Count( startNumber, endNumber );
        var resultArray = result.ToArray();

        // Assert
        resultArray.Should().NotBeEmpty();
        resultArray.Should().HaveCount( expected.Length );
        resultArray.Should().Contain( expected );
    }
}