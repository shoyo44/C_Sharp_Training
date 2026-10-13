using System;
public class Hallow_triange
{
    public static void Main(String[] args)
    {
        for(int i = 1; i <= 3; i++)
        {
            for(int j = 5; j <= 5; j++)
            {
                if((i==3 && j<=5)||(i==3 && j==3)||((j==2||j==4)&&(i==2))) Console.Write("*");
            }
        }
    }
}