namespace Kalkulačka;

public class Pocet
{
    public static double provedeni(double x, double y, string operace)
    {
        switch (operace)
        {
            case "+":
            {
                return x + y;
            }
            case "/":
            {
                return x / y;
            }
            case "-":
            {
                return x - y;
            }
            case "*":
            {
                return x * y;
            }
            default:
            {
                return 0;
            }
        }
    }
}