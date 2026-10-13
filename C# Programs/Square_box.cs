using System;
using System.Net;
public class Square_box
{
    public static void Main(String[] args)
    {

        for(int i = 1; i <=5; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            for(int k = (i + 1); k <= 5; k++)
            {
                Console.Write(k);
            }
            
            Console.WriteLine();
        }
    }
}