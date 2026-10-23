/*Generate random radius using Random, calculate area using Math.PI and Math.Pow()
*/

using System;
public class Calc_Area
{
    public static (double radius,double area) GetArea()
    {
        double radius=Random.Shared.NextDouble();
        return (radius,Math.PI*Math.Pow(radius,2));
    }
    public static void Main(String[] args)
    {
        var (radius,area)=GetArea();
        Console.WriteLine("The random radius is : "+radius);
        Console.WriteLine("The Area of the circle is : "+area);

    }
}