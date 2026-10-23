/*Solve Quadratic Equation Roots
Method: FindQuadraticRoots(double a, double b, double c)
Formula:
root1, root2=−b±b2−4ac2a\text{root1, root2} = \frac{-b \pm \sqrt{b^2 - 4ac}}{2a}root1, root2=2a−b±b2−4ac​​ 
→ use Math.Sqrt() and handle imaginary case.*/
using System;
public class Calc_Quad
{
    public static (double root1,double root2) FindQuadraticRoots(double a,double b,double c)
    {
        double root1=-b+Math.Sqrt((Math.Pow(b,2)-(4*a*c))/2*a);
        double root2=-b-Math.Sqrt((Math.Pow(b,2)-(4*a*c))/2*a);
        return (root1,root2);

    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the 'a' value : ");
        double a=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the 'b' value : ");
        double b=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the 'c' value : ");
        double c=Convert.ToDouble(Console.ReadLine());
        var (root1,root2)=FindQuadraticRoots(a,b,c);
        Console.WriteLine("The roots are :"+root1+" , "+root2);
    } 
}