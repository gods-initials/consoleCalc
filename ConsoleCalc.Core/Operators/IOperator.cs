namespace ConsoleCalc.Operators;

/// <summary>
/// mathematical operators representation
/// </summary>
public interface IOperator
{
    int Precedence { get; }     /// highter precedence = evaluated first
    static string Symbol { get; }
}