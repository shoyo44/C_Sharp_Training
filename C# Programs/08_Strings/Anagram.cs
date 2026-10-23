using System;
public class Anagram
{
    public static Boolean check_anagram(string a,string b)
    {
        a=a.ToLower();
        b=b.ToLower();
        char[] a_arr=a.ToCharArray();
        char[] b_arr=b.ToCharArray();
        Array.Sort(a_arr);
        Array.Sort(b_arr);
        if(a_arr.SequenceEqual(b_arr)) return true;
        return false;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter String 1 : ");
        string name1=Console.ReadLine();
        Console.Write("Enter String 2 : ");
        string name2=Console.ReadLine();
        if (check_anagram(name1, name2))
        {
            Console.WriteLine("The strings are anagram");
        }
        else Console.WriteLine("The strings are not an anagram");
    }
}