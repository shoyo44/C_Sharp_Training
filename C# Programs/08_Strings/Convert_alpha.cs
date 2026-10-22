using System;
using System.Net.NetworkInformation;
using Microsoft.Win32.SafeHandles;
public class Convert_alpha
{
    public static string conv(string name)
    {
        char[] arr=name.ToCharArray();
        string final="";
        for(int i = 0; i < arr.Length; i++)
        {
            if (char.IsUpper(arr[i]))
            {
                final+=char.ToLower(arr[i]);
            }
            else
            {
                final+=char.ToUpper(arr[i]);
            }
        }
        

        return final;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the name to convert the cases : ");
        string name=Console.ReadLine();
        Console.WriteLine("The converted string is : "+conv(name));
    }
}