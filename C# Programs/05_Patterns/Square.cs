using System;
public class Square
{
    public static void Main(String[] args)
    {
        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= 4; j++)
            {
                Console.Write("*"+((j<4)?(" "):("")));
            }
            Console.WriteLine();
        }
    }
}