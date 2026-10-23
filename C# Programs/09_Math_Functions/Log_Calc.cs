/*Find Logarithm (Base 10 and Base e)
Method: FindLogs(double num) → use Math.Log10() and Math.Log()
Trigonometric Calculator*/
using System;
public class Log_Calc
{
    public static (double base_e,double base_10) FindLogs(double num)
    {
        return (Math.Log(num),Math.Log10(num));
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        double number=Convert.ToDouble(Console.ReadLine());
        var (base_e,base_10)=FindLogs(number);
        Console.WriteLine("The log base with 'e' value is : "+base_e);
        Console.WriteLine("The log base with 10 value is : "+base_10);

    }
}