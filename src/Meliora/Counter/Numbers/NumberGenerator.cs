namespace Counter.Numbers;

public class NumberGenerator : INumberGenerator
{
    public virtual int Generate( int last = 0 ) => ++last;
}