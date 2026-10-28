using System;
public class Method_Overloading
{
    public class Add
    {
        public int AddNumbers(int a,int b)
        {
            return a+b;
        }
        public int AddNumbers(int a,int b,int c)
        {
            return a+b+c;
        }
        public double AddNumbers(double a,double b)
        {
            return a+b;
        }
        public string AddNumbers(string a,string b,string c)
        {
            return a+b+c;
        }
    }
    public static void Main(String[] args)
    {
        Add obj=new Add();
        Console.WriteLine("Adiition of two integers : "+obj.AddNumbers(4,5));
        Console.WriteLine("Adiition of three integers : "+obj.AddNumbers(4,5,6));
        Console.WriteLine("Adiition of two double values : "+obj.AddNumbers(4.6,5.5));
        Console.WriteLine("Adiition of three strings : "+obj.AddNumbers("ab","bc","cd"));
    }

}