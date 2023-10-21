namespace Counter.Numbers;

public class MultipleChecker : IMultipleChecker
{
    public bool IsMultiple( int number, int multiple ) => number % multiple == 0;
}