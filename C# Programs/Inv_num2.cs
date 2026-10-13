using System;
using System.Net;
public class Inv_num2
{
    public static void Main(String[] args)
    {
        int x=1;


        for(int i = 5; i >=1; i--)
        {
            int end=5;
            for(int j = x; j <= end; j++)
            {
                Console.Write(j);
            }
            x+=1;
            Console.WriteLine();
        }
    }
}