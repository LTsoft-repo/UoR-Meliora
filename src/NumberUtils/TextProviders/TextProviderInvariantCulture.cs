using System.Globalization;

namespace NumberUtils.TextProviders;

public class TextProviderInvariantCulture<T> : ITextProvider<T>
{
    public virtual string GetText( T number )
    {
        var currentCultureInfo = Thread.CurrentThread.CurrentCulture;

        try
        {
            // Set the default culture for conversions (e.g., parsing, formatting).
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            return number?.ToString() ?? "";
        }
        finally
        {
            // Restore the default culture for conversions (e.g., parsing, formatting).
            Thread.CurrentThread.CurrentCulture = currentCultureInfo;
        }
    }
}