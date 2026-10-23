/*Calculate Compound Interest
Method: CalculateCompoundInterest(double principal, double rate, int time)
Formula: principal * Math.Pow((1 + rate/100), time) - principal
*/
using System;
public class Interest_Compound
{
    public static double CalculateCompoundInterest(double principal, double rate, int time)
    {
        return Math.Round(principal*Math.Pow((1+rate/100),time)-principal);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the principal amount : ");
        double principal=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the rate percentage : ");
        double rate=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the time : ");
        int time=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The compount Interest is : "+CalculateCompoundInterest(principal,rate,time));

    }
}