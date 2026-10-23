using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

/*Power of a Number
Method: FindPower(double baseNum, double exponent) → use Math.Pow(baseNum, exponent)
Absolute Value Finder
Method: GetAbsolute(int num) → use Math.Abs(num)
Find Maximum and Minimum
Method: FindMaxMin(int a, int b) → use Math.Max(a,b) and Math.Min(a,b)
Round a Number
Method: RoundValue(double num) → use Math.Round(num)
*/
public class Basic_Math_Functions
{
    public static double FindPower(double base_number,double exponent)
    {
        return Math.Pow(base_number,exponent);
    }
    public static int GetAbsolute(int num)
    {
        return Math.Abs(num);
    }
    public static (int max_number,int min_number) FindMaxMin(int a,int b)
    {
        int max_number=Math.Max(a,b);
        int min_number=Math.Min(a,b);
        return (max_number,min_number);
    }
    public static double Roundvalue(double num)
    {
        return Math.Round(num);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the first number : ");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number : ");
        int num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Power: "+FindPower(num1,num2));
        Console.WriteLine("Absolute : "+GetAbsolute(num1));
        var (max_number,min_number)=FindMaxMin(num1,num2);
        Console.WriteLine("Max : "+max_number+" ,Min : "+min_number);
        Console.WriteLine("Rounded value : "+Roundvalue(num1));
        
        
    }
}