/*Find Distance Between Two Points
Method: GetDistance(double x1, double y1, double x2, double y2)
Formula: Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))*/
/*Method: CalculateBMI(double weight, double height)
Formula: weight / Math.Pow(height, 2)*/
using System;
public class Calc_Dist
{
    public static double GetDistance(double x1,double y1,double x2,double y2)
    {
        return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the x1 coordinate : ");
        double x1=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the y1 coordinate : ");
        double y1=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the x2 coordinate : ");
        double x2=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the y2 coordinate : ");
        double y2=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("The Euclidian Distance for the coordinates is : "+GetDistance(x1,y1,x2,y2));

    }
}