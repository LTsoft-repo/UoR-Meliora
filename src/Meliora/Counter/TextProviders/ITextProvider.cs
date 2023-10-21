using System.Globalization;

namespace Counter.TextProviders;

public interface ITextProvider
{
    string GetText<T>( T number );
}

public class TextProviderInvariantCulture : ITextProvider
{
    public virtual string GetText<T>( T number )
    {
        // Set the default culture for conversions (e.g., parsing, formatting).
        var currentCultureInfo = CultureInfo.DefaultThreadCurrentCulture;
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        var text = number?.ToString() ?? "";

        // Restore the default culture for conversions (e.g., parsing, formatting).
        CultureInfo.DefaultThreadCurrentCulture = currentCultureInfo;

        return text;
    }
}