using System.Text;
using ConsoleCalc.Operators;

namespace ConsoleCalc.Tokens;

public enum TokenType
{
    Newline,
    Number,
    BinaryOperator,
    UnaryOperator,
    LeftParen,
    RightParen
}