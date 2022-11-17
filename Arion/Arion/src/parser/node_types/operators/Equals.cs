namespace Arion.NodeTypes.Operators; 

public class Equals {
    private Token _one;
    private Token _two;
    public Equals(Token one, Token two) {
        _one = one;
        _two = two;
    }

    public bool Run() {
        return int.Parse(_one.GetValue()) == int.Parse(_two.GetValue());
    }
}