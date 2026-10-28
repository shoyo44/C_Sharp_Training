using System;
using System.Globalization;
using System.Runtime.CompilerServices;
public class Interface_class
{
    public interface A1
    {
        public void add(int a,int b);
        public void sub(int a,int b);
    }
    public interface A2
    {
        public void div(int a,int b);
        public void mul(int a,int b);
    }
    public class A3 : A1,A2
    {
        public void add(int a,int b)
        {
            Console.WriteLine("The addtion of the numbers "+a+" and "+b+" is : "+(a+b));
        }
        public void sub(int a,int b)
        {
            Console.WriteLine("The subtraction of the numbers "+a+" and "+b+" is : "+(a-b));
        }
        public void mul(int a,int b)
        {
            Console.WriteLine("The multiplication of the numbers "+a+" and "+b+" is : "+(a*b));
        }
        public void div(int a,int b)
        {
            Console.WriteLine("The division of the numbers "+a+" and "+b+" is : "+((double)(a/b)));
        }
    }
    public static void Main(String[] args)
    {
        A3 obj=new A3();
        obj.add(2,4);
        obj.sub(2,4);
        obj.mul(2,4);
        obj.div(2,4);

    }
}