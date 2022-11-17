namespace Arion; 



// TODO: CREATE A SKIP TOKEN METHOD



public class TokenList {
    private List<Token> _tokenList;
    private int _current;

    public TokenList() {
        _current = 0;
        _tokenList = new List<Token>();
    }

    public void Add(Token token) {
        _tokenList.Add(token);
    }
    
    public Token GetCurrentToken() {
        return _tokenList[_current];
    }
    
    public Token GetNextToken() {
        _current++;
        return _tokenList[_current];
    }
    
    public Token PeekNextToken() {
        return _tokenList[_current + 1];
    }

    public bool HasNextToken() {
        return _tokenList.ElementAtOrDefault(_current + 1) != null;
    }
    
    public int GetLength() {
        return _tokenList.Count;
    }
    
    public void PrintTokenList() {
        foreach (Token token in _tokenList) {
            Console.WriteLine(token.GetValue());
        }
    }
}