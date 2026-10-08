using System;
public class String_calc
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the first number : ");
        int num1=Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the second number : ");
        int num2=Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the operator name(Addition,subtraction,mulitplication,divison): ");
        string oper=Console.ReadLine();
        oper=oper.ToLower();
        switch (oper)
        {
            case "addition":
            Console.WriteLine("The addition of the numbers : "+(num1+num2));
            break;
            case "subtraction":
            Console.WriteLine("The subtraction of the numbers : "+((num1>num2)?(num1-num2):(num2-num1)));
            break;
            case "multiplication":
            Console.WriteLine("The multiplication of the numbers : "+(num1*num2));
            break;
            case "division":
            Console.WriteLine("The addition of the numbers : "+((num1==0 || num2==0)?0:(num1/num2)));
            break;
            default:
            Console.WriteLine("Enter the valid operator");
            break;
        }

    }
}