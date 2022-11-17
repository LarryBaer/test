using Arion.NodeTypes;
using Arion.NodeTypes.Operators;
using Arion.NodeTypes.Statements;

namespace Arion;
using System.Collections;
// TODO: create a syntax checker
// TODO: separate each of these into methods. like call number() and do the code there. 
public class Parser {
    private TokenList tokens_;

    public Parser(TokenList tokens) {
        tokens_ = tokens;
    }
    public  List<ExecuteableCode> Parse() {
        var executeableCode = new List<ExecuteableCode>();
        while (tokens_.HasNextToken()) {
            executeableCode.Add(ParseHelper());
        }
        return executeableCode;
    }

    private ExecuteableCode ParseHelper() {
        var current = tokens_.GetCurrentToken();
        if (current.GetValue() == "log") {
                // Skip paren
                tokens_.GetNextToken();
                var log = new Log(tokens_.GetNextToken());
                // Skip paren
                tokens_.GetNextToken();
                tokens_.GetNextToken();
                return log;
        }

        if (current.GetValue() == "if") {
                var ec = new List<ExecuteableCode>();
                var expression = new List<Token>();
                
                // Skip '('
                tokens_.GetNextToken();
                
                current = tokens_.GetNextToken();
                while (current.GetValue() != ")") {
                    expression.Add(current);
                    current = tokens_.GetNextToken();
                }

                // Skip ) and {
                current = tokens_.GetNextToken();
                current = tokens_.GetNextToken();

                // tokens_.GetNextToken();
                var ifStatement = new If(ec);
                for (var i = 0; i < expression.Count; i++) {
                    // if (expression[i].GetValue() == "+") {
                    //     var add = new Add(expression[i - 1], expression[i++]);
                    // }
                    
                    
                    if (expression[i].GetValue() == "=") {
                        //instead of getting the number on each side, use a stack of expressions and pop them off?
                        var equals = new Equals(expression[i - 1], expression[i + 1]);
                        var t = equals.Run();
                        ifStatement.boolean = true;
                    }
                }

                while (tokens_.HasNextToken() && tokens_.PeekNextToken().GetValue() != "}") {
                        ec.Add(ParseHelper());
                }
                
                return ifStatement;
        }


        if (tokens_.PeekNextToken().GetValue() == "}") {
            tokens_.GetNextToken();
        }

            
        Console.WriteLine("Parser error" + current.GetValue());
        return null;
    }
}