namespace NumberUtils.Numbers;

public class MultipleChecker : IMultipleChecker
{
    public virtual bool IsMultiple( int number, int multiple ) => number % multiple == 0;
}