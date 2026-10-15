using System;
public class Calc
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the first number : ");
        int num1=Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the second number : ");
        int num2=Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the operator number(+,-,*,/): ");
        char oper=Convert.ToChar(Console.ReadLine());
        switch (oper)
        {
            case '+':
            Console.WriteLine("The addition of the numbers : "+(num1+num2));
            break;
            case '-':
            Console.WriteLine("The subtraction of the numbers : "+((num1>num2)?(num1-num2):(num2-num1)));
            break;
            case '*':
            Console.WriteLine("The multiplication of the numbers : "+(num1*num2));
            break;
            case '/':
            Console.WriteLine("The addition of the numbers : "+((num1==0 || num2==0)?0:(num1/num2)));
            break;
            default:
            Console.WriteLine("Enter the valid operator");
            break;
        }

    }
}