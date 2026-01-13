namespace ConsoleCalc.Operators;

public interface IUnaryOperator : IOperator
{
    decimal Calculate(decimal operand);
}