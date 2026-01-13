namespace ConsoleCalc.Operators;

public interface IBinaryOperator : IOperator
{
    decimal Calculate(decimal left, decimal right);
}