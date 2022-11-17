namespace Arion;
using System.Collections;
public class Tokenizer {
    // TODO: create seperate methods to process numbers and letters
    public static TokenList Tokenize(string input) {
        var current = 0;
        var tokens = new TokenList();

        
        while (current < input.Length) {
            var c = input[current];
            if (c == '(') {
                var paren = new Token("paren", "(");
                tokens.Add(paren);
                current++;
                continue;
            }
            
            if (c == ')') {
                var paren = new Token("paren", ")");
                tokens.Add(paren);
                current++;
                continue;
            }
            
            if (c == '{') {
                var paren = new Token("curly_brace", "{");
                tokens.Add(paren);
                current++;
                continue;
            }
            
            if (c == '}') {
                var paren = new Token("curly_brace", "}");
                tokens.Add(paren);
                current++;
                continue;
            }
            
            if (Char.IsWhiteSpace(c)) {
                current++;
                continue;
            }
            
            if (Char.IsDigit(c)) {
                var value = "";
                value += c;
                while (Char.IsDigit(c) && current + 1 < input.Length) {
                    current++;
                    c = input[current];
                }

                var number = new Token("number", value);
                tokens.Add(number);
                continue;
            }

            if (Char.IsLetter(c)) {
                var value = "";
                while (Char.IsLetter(c)) {
                    value += c;
                    current++;
                    c = input[current];
                }

                var text = new Token("name", value);
                tokens.Add(text);
                continue;
            }

            if (c == '+') {
                var add = new Token("add", "+");
                tokens.Add(add);
                current++;
                continue;
            }
            
            if (c == '=') {
                var add = new Token("equals", "=");
                tokens.Add(add);
                current++;
                continue;
            }
            
            // create error obj here instead. 
            Console.WriteLine("This:::" + c);
            throw new Exception("Error in tokenizer");
            
        }
        
        return tokens;
    }
}