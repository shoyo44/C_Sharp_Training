using System;
using System.ComponentModel;
public class Abstract_class
{
    public abstract class Cacl
    {
        public abstract void add(int a,int b);
        public abstract void sub(int a,int b);
        public void mul(int a,int b)
        {
            Console.WriteLine("The multiplication of the numbers "+a+" and "+b+" is : "+(a*b));
        }
        public void div(int a,int b)
        {
            Console.WriteLine("The division of the numbers "+a+" and "+b+" is : "+(a/b));
        }
    }
    public class A1 : Cacl
    {
    
        public override void add(int a,int b)
        {
            Console.WriteLine("The additon of the numbers "+a+" and "+b+" is : "+(a+b));
        }
        public override void sub(int a,int b)
        {
            Console.WriteLine("The subtraction of the numbers "+a+" and "+b+" is : "+(a+b));
        }    
    }
    public static void Main(String[] args)
    {
        A1 obj=new A1();
        obj.add(2,4);
        obj.div(10,2);
    }
}