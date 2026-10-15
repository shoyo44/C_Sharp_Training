using System;
using System.Transactions;
public class Table
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the number for multiplication table calculation : ");
        int num=Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i+" * "+num+" = "+(i*num));
        }
    }
}