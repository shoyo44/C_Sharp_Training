using System;
public class All_even
{
    public static void Main(String[] args)
    {
        for(int i = 1; i <= 50; i++)
        {
            if(i%2==0) Console.Write(i+((i<50)?(" "):("")));
        }
    }
}