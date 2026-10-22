using System;
using System.Net.NetworkInformation;
using Microsoft.Win32.SafeHandles;
public class Count_vowels
{
    public static (int vowel_count,int consonent_count) count_vow(string name)
    {
        
        int vowel_count=0;
        int consonent_count=0;
        name=name.ToLower();

        char[] vowels=['a','e','i','o','u'];
        int val=vowel_count;
        foreach(char i in name)
        {
            foreach(char vow in vowels)
            {
                if(i==vow){
                    vowel_count++;
                    break;
                }
            }
            if (val == vowel_count) consonent_count++;
            else val=vowel_count;
        }
        

        return (vowel_count,consonent_count);
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the string to check the vowels and consonant count : ");
        string name=Console.ReadLine();
        var (vowel_count,consonent_count)=count_vow(name);
        Console.WriteLine("The string has vowels : "+vowel_count+" and consonant : "+consonent_count);
    }
}