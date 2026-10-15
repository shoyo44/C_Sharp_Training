using System;
using System.Net;
public class Odd_rep
{
    public static void Main(String[] args)
    {

        for(int i = 5; i >=1; i--)
        {
            int x=1;
            for(int j = 1; j <= i; j++)
            {
                Console.Write(x);
                x+=2;
            }
            Console.WriteLine();
        }
    }
}