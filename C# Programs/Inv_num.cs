using System;
using System.Net;
public class Inv_num
{
    public static void Main(String[] args)
    {
        int[] arr={15,10,6,3,1};
        int x=15;
        for(int i = 5; i >=1; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(x+" ");
                x-=1;
            }
            Console.WriteLine();
        }
    }
}