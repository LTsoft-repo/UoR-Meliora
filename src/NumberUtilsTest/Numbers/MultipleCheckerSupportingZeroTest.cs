using NumberUtils.Numbers;

namespace NumberUtilsTest.Numbers;

public class MultipleCheckerSupportingZeroTest
{
    [ Theory ]
    [ InlineData( 1, 1, true ) ]
    [ InlineData( 3, 1, true ) ]
    [ InlineData( 5, 1, true ) ]
    [ InlineData( 7, 7, true ) ]
    [ InlineData( 8, 7, false ) ]
    [ InlineData( 3, 5, false ) ]
    [ InlineData( 5, 5, true ) ]
    [ InlineData( 0, 0, true ) ]
    [ InlineData( 3, 0, false ) ]
    public void IsMultiple_MultipleOfNumber_Successfully( int number, int multiple, bool expected )
    {
        // Arrange
        IMultipleChecker multipleChecker = new MultipleCheckerSupportingZero();

        // Act
        var result = multipleChecker.IsMultiple( number, multiple );

        // Assert
        result.Should().Be( expected );
    }
}