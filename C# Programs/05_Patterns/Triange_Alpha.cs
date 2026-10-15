using System;
public class Triangle_Alpha
{
    public static void Main(String[] args)
    {
        for(int i = 1; i <=5; i++)
        {
            char start=(char)('A'-1);
            for(int j = i; j <= 5; j++)
            {
                Console.Write("  ");
            }
            for(int k = 1; k <= i; k++)
            {
                start=(char)(start+1);
                Console.Write(start+" ");
            }
            for(int l = 2; l <= i; l++)
            {
                start=(char)(start-1);
                Console.Write(start+" ");
            }
            Console.WriteLine();
        }
    }
}