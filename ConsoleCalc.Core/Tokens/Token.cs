using System.Text;
using ConsoleCalc.Operators;

namespace ConsoleCalc.Tokens;

public class Token
{
    public TokenType Type { get; }
    public string Value { get; }
    public Token(TokenType type, string value)
    {
        this.Type = type;
        this.Value = value;
    }
}