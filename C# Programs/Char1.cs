using System;
public class Char1
{
    public static void Main(String[] args)
    {
        char x='A';
        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(x+j);
            }
            Console.WriteLine();
        }

    }
}