namespace NumberUtils.Numbers;

public class MultipleCheckerSupportingZero : MultipleChecker
{
    public override bool IsMultiple( int number, int multiple )
    {
        if( multiple == 0 )
        {
            return number == 0;
        }

        return base.IsMultiple( number, multiple );
    }
}