namespace ConsoleCalc.Operators;

public class DivisionOperator : IBinaryOperator
{
    public static string Symbol => "/";
    public int Precedence => 2;
    public decimal Calculate(decimal left, decimal right) => left / right;
}