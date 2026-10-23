/*Method: ShowTrigValues(double angle)
Use: Math.Sin(), Math.Cos(), Math.Tan() (angle in radians)*/

using System;
public class Trig_Calc
{
    public static (double sin,double cos,double tan) ShowTrigValues(double angle)
    {
        double sin=Math.Sin(angle)*(Math.PI/180);
        double cos=Math.Cos(angle)*(Math.PI/180);
        double tan=Math.Tan(angle)*(Math.PI/180);
        return (sin,cos,tan);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the angle : ");
        double angle=Convert.ToDouble(Console.ReadLine());
        var (sin,cos,tan)=ShowTrigValues(angle);
        Console.WriteLine("The sin value is : "+sin);
        Console.WriteLine("The cos value is : "+cos);
        Console.WriteLine("The tan value is : "+tan);

    }
}