using System;
public class List_Table
{
    public static void table(int num)
    {
        Console.WriteLine("--Table Representation of number "+num+"--");
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i+" * "+num+" = "+(i*num));
        }
        Console.WriteLine();
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("Tables of 1 to 5");
        for(int i = 1; i <= 5; i++)
        {
            table(i);
        }
        
    }
}