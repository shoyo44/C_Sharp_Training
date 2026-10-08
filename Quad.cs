using System;
public class Quad
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the X value : ");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Y value : ");
        int y=Convert.ToInt32(Console.ReadLine());


        String quadrant=(x==0 && y==0)?("Origin"):(x>0 && y>0)
        ?("First Quadrant"):(x<0&&y>0)?("Second Quadrant"):(x<0&&y<0)?("Third Quadrant"):("Fourth Quadrant");
        Console.WriteLine("The X value "+x+" and the Y value "+y+" is in the "+quadrant);
    }
}