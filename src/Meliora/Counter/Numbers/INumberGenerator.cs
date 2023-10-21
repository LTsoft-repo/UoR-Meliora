namespace Counter.Numbers;

public interface INumberGenerator
{
    int Generate( int last = 0 );
}