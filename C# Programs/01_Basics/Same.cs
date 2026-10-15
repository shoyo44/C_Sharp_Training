using System;
using System.Net;
public class Same
{
    public static void Main(String[] args)
    {
        int x=3;
        for(int i = 1; i <=4; i++)
        {

            for(int j = 1; j <= i; j++)
            {
                Console.Write(x);
            }
            x+=1;
            Console.WriteLine();
        }
    }
}