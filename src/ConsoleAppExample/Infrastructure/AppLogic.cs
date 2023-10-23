using JetBrains.Annotations;
using NumberUtils.Numbers;

namespace ConsoleAppExample.Infrastructure;

public class AppLogic
{
    private readonly INumbersProvider<string> numberProvider;

    public AppLogic( INumbersProvider<string> numberProvider )
    {
        this.numberProvider = numberProvider;
    }

    [ UsedImplicitly ]
    public Task RunAsync( string[] args )
    {
        var numbers = numberProvider.GetRange( 1, 50 );

        Console.WriteLine( "Numbers from 1 to 50:" );
        var count = 1;

        foreach( var number in numbers )
        {
            Console.WriteLine( $"\t{count} - {number}" );
            count++;
        }

        return Task.CompletedTask;
    }
}