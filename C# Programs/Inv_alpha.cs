using System;
using System.Runtime.InteropServices;
using System.Threading.Channels;
public class Inv_alpha
{
    public static void Main(String[] args)
    {
        char x=(char)('a'-1);
        for(int i = 4; i >= 1; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                char b=(char)(x+j);
                Console.Write(b);
            }
            Console.WriteLine();
        }
    }
}