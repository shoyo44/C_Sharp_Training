using System;
public class Rectangle
{
    public static void Main(String[] args)
    {
        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= 6; j++)
            {
                Console.Write("*"+((j<6)?(" "):("")));
            }
            Console.WriteLine();
        }
    }
}