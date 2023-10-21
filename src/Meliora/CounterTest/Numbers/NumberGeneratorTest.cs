using Counter.Numbers;

namespace CounterTest.Numbers;

public class NumberGeneratorTest
{
    [ Fact ]
    public void Generate_NoLastNumber_Successfully()
    {
        // Arrange
        INumberGenerator numberGenerator = new NumberGenerator();

        // Act
        var result = numberGenerator.Generate();

        // Assert
        result.Should().Be( 1 );
    }

    [ Theory ]
    [ InlineData( 1, 2 ) ]
    [ InlineData( 0, 1 ) ]
    [ InlineData( -3, -2 ) ]
    public void Generate_WithLastNumber_Successfully( int last, int expected )
    {
        // Arrange
        INumberGenerator numberGenerator = new NumberGenerator();

        // Act
        var result = numberGenerator.Generate( last );

        // Assert
        result.Should().Be( expected );
    }
}