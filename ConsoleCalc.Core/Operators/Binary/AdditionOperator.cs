namespace ConsoleCalc.Operators;

public class AdditionOperator : IBinaryOperator
{
    public static string Symbol => "+";
    public int Precedence => 1;
    public decimal Calculate(decimal left, decimal right) => left + right;
}