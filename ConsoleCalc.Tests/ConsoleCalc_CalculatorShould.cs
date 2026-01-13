using ConsoleCalc.Calculators;

namespace ConsoleCalc.Tests;

public class ConsoleCalc_CalculatorShould
{
    [Theory]
    [InlineData("1+1", 2)]
    [InlineData("1+2*3", 7)]
    [InlineData("10-2*3", 4)]
    [InlineData("8/2+3", 7)]
    [InlineData("8/(2+2)", 2)]
    [InlineData("2*3+4*5", 26)]
    [InlineData("10-3-2", 5)]
    [InlineData("100/10/2", 5)]
    [InlineData("20/5*2", 8)]
    [InlineData("(1+2)*3", 9)]
    [InlineData("2*(3+(4*5))", 46)]
    [InlineData("((1+1)+1)*2", 6)]
    [InlineData("10*(2+(3-1))", 40)]
    [InlineData("-1+2", 1)]
    [InlineData("1+-2", -1)]
    [InlineData("-(2+3)", -5)]
    [InlineData("-(-5)", 5)]
    [InlineData("2*-3", -6)]
    [InlineData(" 1 + 2 ", 3)]
    [InlineData("2*   3", 6)]
    [InlineData(" ( 1 + 2 ) * 3 ", 9)]
    [InlineData("0+0", 0)]
    [InlineData("0*100", 0)]
    [InlineData("10-0", 10)]
    [InlineData("0-10", -10)]
    [InlineData("1+2*3-4/2", 5)]
    [InlineData("3*(2+1)-4/2", 7)]
    [InlineData("10/(2+3)*4", 8)]
    [InlineData("5+-(3*2)", -1)]
    //[InlineData("--1", 1)]
    //[InlineData("+-1", -1)]
    //[InlineData("-+-1", 1)]
    public void Calculator_ShitExpressionEvaluatedCorrectly(string expr, decimal expected)
    {
        var calc = new Calculator();
        decimal result = calc.Calculate(expr);

        Assert.Equal(expected, result);
    }
}
