﻿using NumberUtils.Numbers;
using NumberUtils.TextProviders;

namespace NumberUtilsTest.TextProviders;

public class MelioraTextProviderTest
{
    [ Theory ]
    [ InlineData( 0, "Nursing Meliora" ) ]
    [ InlineData( 1, "1" ) ]
    [ InlineData( 6, "Nursing" ) ]
    [ InlineData( 14, "Meliora" ) ]
    [ InlineData( 21, "Nursing Meliora" ) ]
    [ InlineData( 41, "41" ) ]
    [ InlineData( -42, "Nursing Meliora" ) ]
    public void GetText_Successfully( int number, string expected )
    {
        // Arrange
        IMultipleChecker multipleChecker = new MultipleCheckerSupportingZero();
        ITextProvider<int> textProvider = new MelioraTextProvider( multipleChecker );

        // Act
        var result = textProvider.GetText( number );

        // Assert
        result.Should().Be( expected );
    }
}