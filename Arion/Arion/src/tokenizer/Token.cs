namespace Arion;

public class Token {
    private string _type;
    private string _value;
    public Token(string type, string value) {
        _type = type;
        _value = value;
    }

    public string GetType() {
        return _type;
    }

    public string GetValue() {
        return _value;
    }
}