namespace Counter.Numbers;

public class NumberGenerator : INumberGenerator
{
    public int Generate( int last = 0 ) => ++last;
}