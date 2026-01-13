namespace ConsoleCalc.Operators;

public static class BinaryOperatorRegistry
{
    public static readonly Dictionary<string, IBinaryOperator> Operators = new()
    {
        {AdditionOperator.Symbol, new AdditionOperator()},
        {SubtractionOperator.Symbol, new SubtractionOperator()},
        {MultiplicationOperator.Symbol, new MultiplicationOperator()},
        {DivisionOperator.Symbol, new DivisionOperator()}
    };
}

public static class UnaryOperatorRegistry
{
    public static readonly Dictionary<string, IUnaryOperator> Operators = new()
    {
        {NegativeOperator.Symbol, new NegativeOperator()},
        {PositiveOperator.Symbol, new PositiveOperator()}
    };
}