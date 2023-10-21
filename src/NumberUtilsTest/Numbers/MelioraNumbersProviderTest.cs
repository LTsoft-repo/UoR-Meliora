using NumberUtils.Numbers;
using NumberUtils.TextProviders;

namespace NumberUtilsTest.Numbers;

public class MelioraNumbersProviderTest
{
    [ Theory ]
    [ InlineData( 1, 2, new[] { "1", "2" } ) ]
    [ InlineData( 1, 5, new[] { "1", "2", "Nursing", "4", "5" } ) ]
    [ InlineData( 15, 10, new[] { "Nursing", "Meliora", "13", "Nursing", "11", "10" } ) ]
    [ InlineData( -5, 1, new[] { "-5", "-4", "Nursing", "-2", "-1", "Nursing Meliora", "1" } ) ]
    [ InlineData( 0, 1, new[] { "Nursing Meliora", "1" } ) ]
    [ InlineData( 0, -2, new[] { "Nursing Meliora", "-1", "-2" } ) ]
    public void GetRange_StartNumberEndNumber_Successfully( int startNumber, int endNumber, string[] expected )
    {
        // Arrange
        var numberProvider = new NumbersProvider();
        var multipleChecker = new MultipleCheckerSupportingZero();
        var textProvider = new MelioraTextProvider( multipleChecker );
        INumbersProvider<string> NumberUtils = new MelioraNumbersProvider( numberProvider, textProvider );

        // Act
        var result = NumberUtils.GetRange( startNumber, endNumber );
        var resultArray = result.ToArray();

        // Assert
        resultArray.Should().NotBeEmpty();
        resultArray.Should().HaveCount( expected.Length );
        resultArray.Should().Contain( expected );
    }

    [ Fact ]
    public void GetRange_GetChallengeRange_Successfully()
    {
        // Arrange
        // List of numbers from 1 to 50 as string
        var numbers = Enumerable.Range( 1, 50 ).ToArray();

        var expected = numbers.Select( number =>
            {
                var value = number.ToString();

                // Multiples of 3 and 7.
                if( new[] { 21, 42 }.Contains( number ) )
                {
                    value = "Nursing Meliora";
                }
                // Multiples of 7.
                else if( new[] { 7, 14, 21, 28, 35, 42, 49 }.Contains( number ) )
                {
                    value = "Meliora";
                }
                // Multiples of 3.
                else if( new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48 }.Contains( number ) )
                {
                    value = "Nursing";
                }

                return value;
            } )
            .ToArray();

        var numberProvider = new NumbersProvider();
        var multipleChecker = new MultipleCheckerSupportingZero();
        var textProvider = new MelioraTextProvider( multipleChecker );
        INumbersProvider<string> NumberUtils = new MelioraNumbersProvider( numberProvider, textProvider );

        // Act
        var result = NumberUtils.GetRange( 1, 50 );
        var resultArray = result.ToArray();

        // Assert
        resultArray.Should().NotBeEmpty();
        resultArray.Should().HaveCount( expected.Length );
        resultArray.Should().Contain( expected );
    }
}