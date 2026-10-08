using System;
using System.Runtime.InteropServices;
public class Grade
{
    public static void Main(String[] args)
    {
        Console.Write("Enter your marks : ");
        int obtained_marks=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the total marks : ");
        int total_marks=Convert.ToInt32(Console.ReadLine());
        double percentage=((double)obtained_marks/total_marks)*100;
        if(percentage>=90) Console.WriteLine("S grade");
        else if(percentage>=80 && percentage<90) Console.WriteLine("A grage");
        else if(percentage>=70 && percentage<80) Console.WriteLine("B grade");
        else if(percentage>=60 && percentage<70) Console.WriteLine("C grade");
        else if(percentage>=50 && percentage<60) Console.WriteLine("D grade");
        else Console.WriteLine("Fail");
    }
}