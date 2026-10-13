using System;
using System.Net;
public class Lin_tri
{
    public static void Main(String[] args)
    {
        int x=1;
        for(int i = 1; i <=5; i++)
        {
            int y=x;
            for(int j = x; j >=1; j--)
            {
                Console.Write(y);
                y-=1;
            }
            x+=1;
            Console.WriteLine();
        }
    }
}