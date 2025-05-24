public class ScriptureEntry
{
    private Reference _reference;
    private string _text;

    public ScriptureEntry(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public string GetText()
    {
        return _text;
    }

}
