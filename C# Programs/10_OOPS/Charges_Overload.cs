using System;
public class Charges_Overload
{
    public class Charges
    {
        public double total_charges(double distance)
        {
            return distance*50;
        }
        public double total_charges(double distance,double weight)
        {
            return total_charges(distance)+(weight*10);
        }
        public double total_charges(double distance,double weight,string express_status)
        {
            return total_charges(distance,weight)+200;
        }
    }
    public static void Main(String[] args)
    {
        Charges obj=new Charges();
        Console.Write("Enter the distance : ");
        double distance=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the wieght : ");
        double weight=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the express delivery status : ");
        string express_status=Console.ReadLine();
        Console.WriteLine("Total Charges calculated using distance : "+obj.total_charges(distance));
        Console.WriteLine("Total Charges calculated using distance and weight : "+obj.total_charges(distance,weight));
        Console.WriteLine("Total Charges calculated using distance,weight and express status : "+obj.total_charges(distance,weight,express_status));


    }
}