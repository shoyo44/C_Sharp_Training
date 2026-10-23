using System;
public class Class_A
{
    public void isArmstrong(int num)
    {
        
        int temp=num;
        int sum=0;
        while (temp > 0)
        {
            int rem=temp%10;
            sum+=(rem*rem*rem);
            temp/=10;
        }
        if(sum==num) Console.WriteLine("It is armstrong number");
        else Console.WriteLine("It is not a armstrong number");
        
    }
}

public class Class_B{
    public static void Main(String[] args)
    {
        Class_A obj=new Class_A();
        obj.isArmstrong(153);
        
    }
}