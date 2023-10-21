using Counter.TextProviders;

namespace CounterTest.TextProviders;

public class TextProviderTest
{
    [ Theory ]
    [ InlineData( 1, "1" ) ]
    [ InlineData( 3, "3" ) ]
    [ InlineData( -25, "-25" ) ]
    public void GetText_Integer_Successfully( int number, string expected )
    {
        // Arrange
        ITextProvider textProvider = new TextProviderInvariantCulture();

        // Act
        var result = textProvider.GetText( number );

        // Assert
        result.Should().Be( expected );
    }

    [ Theory ]
    [ InlineData( 1.2, "1.2" ) ]
    [ InlineData( -.5, "-0.5" ) ]
    [ InlineData( 0, "0" ) ]
    public void GetText_Double_Successfully( double number, string expected )
    {
        // Arrange
        ITextProvider textProvider = new TextProviderInvariantCulture();

        // Act
        var result = textProvider.GetText( number );

        // Assert
        result.Should().Be( expected );
    }

    [ Theory ]
    [ InlineData( "Hello", "Hello" ) ]
    [ InlineData( "", "" ) ]
    [ InlineData( null, "" ) ]
    public void GetText_String_Successfully( string? number, string expected )
    {
        // Arrange
        ITextProvider textProvider = new TextProviderInvariantCulture();

        // Act
        var result = textProvider.GetText( number );

        // Assert
        result.Should().Be( expected );
    }
}