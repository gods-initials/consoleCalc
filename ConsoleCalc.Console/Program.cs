using SysConsole = System.Console;
using ConsoleCalc.Calculators;

namespace ConsoleCalc.Console;
public class ConsoleCalc
{
    public static void Main(string[] args)
    {
        var calc = new Calculator();
        SysConsole.WriteLine("Type \"end\" to exit.");
        string? expr = "";
        while (expr != "end")
        {
            SysConsole.Write("Input the expression: ");
            expr = SysConsole.ReadLine();
            SysConsole.Write("Result: ");
            try
            {
                SysConsole.WriteLine(calc.Calculate(expr));
            }
            catch (Exception e)
            {
                SysConsole.WriteLine(e.Message);
            }
        }
    }
}