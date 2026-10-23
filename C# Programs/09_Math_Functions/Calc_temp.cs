/*Temperature Conversion with Rounding
Method: ConvertTemp(double celsius) → (celsius * 9/5) + 32
Round result using Math.Round()*/
using System;
public class Calc_Temp
{
    public static double ConvertTemp(double celsius)
    {
        return Math.Round((celsius*9/5)+32);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the celsius : ");
        double celsius=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("The Temperature is : "+ConvertTemp(celsius));

    }
}