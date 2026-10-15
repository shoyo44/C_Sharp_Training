using System;
using System.Globalization;
using System.Reflection;
public class Right_Triangle_Alpha
{
    public static void Main(String[] args)
    {
        char alpha='B';
        Console.WriteLine('A');
        for(int i = 2; i <= 5; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                char temp;
                if((i<=5) && (j==2)) temp=alpha;
                Console.Write(alpha+" ");
                alpha=(char)(alpha+1);
            }
            Console.WriteLine();
        }
    }
}