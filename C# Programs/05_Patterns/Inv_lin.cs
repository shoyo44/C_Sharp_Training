using System;
using System.Net;
public class Inv_lin
{
    public static void Main(String[] args)
    {
        int x=7;

        for(int i = x; i >=1; i-=2)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}