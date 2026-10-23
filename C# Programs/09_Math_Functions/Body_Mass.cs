/*Method: CalculateBMI(double weight, double height)
Formula: weight / Math.Pow(height, 2)*/
using System;
public class Calc_Body_Mass
{
    public static double CalculateBMI(double weight, double height)
    {
        return weight/Math.Pow(height,2);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the weight : ");
        double weight=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height : ");
        double height=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("The Body Mass Index is : "+CalculateBMI(weight,height));

    }
}