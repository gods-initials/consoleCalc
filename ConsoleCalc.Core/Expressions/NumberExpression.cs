using ConsoleCalc.Operators;

namespace ConsoleCalc.Expressions;

/// <summary>
/// leaf node, a numeric constant
/// </summary>
public class NumberExpression : Expression
{
    public decimal Value { get; }
    public NumberExpression(decimal value) => Value = value;

    public override decimal Evaluate() => Value;
}