using System;
using System.Net.NetworkInformation;
using Microsoft.Win32.SafeHandles;
public class Conv_Special
{
    public static string conv_change(string name)
    {
        char[] arr=name.ToCharArray();
        for(int i = 0; i < arr.Length; i++)
        {
            if(char.IsDigit(arr[i])) arr[i]='*';
        }

        return string.Join("",arr);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the string to remove digits : ");
        string name=Console.ReadLine();
        Console.WriteLine("The converted string is : "+conv_change(name));
    }
}