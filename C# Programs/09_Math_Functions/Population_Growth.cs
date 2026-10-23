/*Find Exponential Growth
Method: PopulationGrowth(double initial, double rate, int years)
Formula: initial * Math.Exp(rate * years)*/
using System;
public class Calc_Exp
{
    public static double PopulationGrowth(double initial, double rate,int years)
    {
        return initial*Math.Exp(rate*years);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the initial population : ");
        double initial=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the rate of increase : ");
        double rate=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the year : ");
        int years=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The Exponential Population Growth is : "+PopulationGrowth(initial,rate,years));

    }
}