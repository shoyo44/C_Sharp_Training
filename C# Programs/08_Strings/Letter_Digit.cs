using System;
using System.Net.NetworkInformation;
using Microsoft.Win32.SafeHandles;
public class Letter_Digit
{
    public static string remove_special_characters(string name)
    {
        string final="";
        for(int i = 0; i < name.Length; i++)
        {
            if(char.IsLetterOrDigit(name[i])) final+=name[i];
        }
        

        return final;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the name to remove special characters : ");
        string name=Console.ReadLine();
        Console.WriteLine("The modified string is : "+remove_special_characters(name));
    }
}