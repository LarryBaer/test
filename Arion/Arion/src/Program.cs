using System.Collections;
using Arion;
using Arion.NodeTypes;

public class Program {
    static void Main(string[] args) {
        var codeInput = GetCodeInput();
        var tokens = Tokenizer.Tokenize(codeInput);
        
        var parser = new Parser(tokens);
        var executeableCode = parser.Parse();
        CodeGenerator.GenerateCode(executeableCode);
    }

    private static string GetCodeInput() {
        var filePath = @"C:\Users\lbaer\OneDrive\Desktop\Arion\Arion\tests\test1.txt";
        var codeInput = "";
        try {
            codeInput = File.ReadAllText(filePath);
        }
        catch {
            Console.WriteLine("Incorrect file path.");
            Environment.Exit(0);
        }

        return codeInput;
    }
}