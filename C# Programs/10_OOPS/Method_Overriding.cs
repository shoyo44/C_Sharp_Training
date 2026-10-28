using System;
public class Method_Overriding
{
    public class Subtract
    {
        public virtual void AddNumbers(int a,int b)
        {
            Console.WriteLine("The subtraction of two numbers : "+(a-b));
        }
    }
    public class AddNum:Subtract
    {
        public override void AddNumbers(int a, int b)
        {
            base.AddNumbers(a, b);
            Console.WriteLine("The addition of two numbers : "+(a+b));
        }
    
  
    }
        
    public static void Main(String[] args)
    {
        AddNum obj=new AddNum();
        obj.AddNumbers(4,5);
    
    }

}