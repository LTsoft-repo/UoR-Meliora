namespace NumberUtils.TextProviders;

public interface ITextProvider<T>
{
    string GetText( T number );
}