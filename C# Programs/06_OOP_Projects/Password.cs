using System;
using System.Reflection.Metadata;
public class Password
{
    public static void Main(String[] args)
    {
        Console.Write("Enter your username : ");
        string user_name=Console.ReadLine();
        Console.Write("Enter your password : ");
        string password=Console.ReadLine();
        String user="Dhanush";
        String pass="Prince@530";
        if (user_name == user)
        {
            if(password==pass) Console.WriteLine("Login successful "+user);
            else Console.WriteLine("Please enter the correct password");
        }
        else Console.WriteLine("Please enter the valid username");
    String valid=(user_name==user && password==pass)?("Login Successfu"):("Login failed");
    Console.WriteLine(valid);
    }
}