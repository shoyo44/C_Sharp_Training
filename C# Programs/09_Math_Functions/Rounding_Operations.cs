using System;
public class Round_Diff
{
    public static (double ceil_value,double floor_value,double round_value) CalcValue(double number)
    {
        return (Math.Ceiling(number),Math.Floor(number),Math.Round(number));
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the number : ");
        double num=Convert.ToDouble(Console.ReadLine());
        var (ceil_value,floor_value,round_value)=CalcValue(num);
        Console.WriteLine("The Ceiling Value is : "+ceil_value);
        Console.WriteLine("The Floor Value is : "+floor_value);
        Console.WriteLine("The Round Value is : "+round_value);
    }
}