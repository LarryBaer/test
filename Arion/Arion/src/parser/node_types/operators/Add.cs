namespace Arion.NodeTypes.Operators; 

public class Add {
    private Token _one;
    private Token _two;
    public Add(Token one, Token two) {
        _one = one;
        _two = two;
    }

    public int Evaluate() {
        return int.Parse(_one.GetValue()) + int.Parse(_two.GetValue());
    }
}