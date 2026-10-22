using System;
using System.Net.NetworkInformation;
using Microsoft.Win32.SafeHandles;
public class Digit_Rem
{
    public static string remove_digit(string name)
    {
        string alpha="";
        for(int i = 0; i < name.Length; i++)
        {
            if(!char.IsDigit(name[i])) alpha+=name[i];
        }
        return alpha;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the string : ");
        string name=Console.ReadLine();
        Console.WriteLine("The modified string with alphabets only: "+remove_digit(name));
    }
}