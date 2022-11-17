namespace Arion.NodeTypes.Statements; 


// could make a statement class with an array of arguments. then go from there.
public class Log : ExecuteableCode{
    private Token _value;

    public Log(Token value) {
        _value = value;
    }

    public void Run() {
        Console.WriteLine(_value.GetValue());
    }
}