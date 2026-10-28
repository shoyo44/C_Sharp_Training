/*2.	Electricity Bill Management System
Develop a program to calculate electricity bills for multiple customers.
•	Accept customer ID, name, and units consumed.
•	Calculate charges using different unit slabs.
•	Add fixed charges and any applicable surcharge.
•	Display the bill and payment category.
•	Process multiple customers using a loop.
•	At the end, display total revenue and the number of customers processed.*/
using System;
public class Electricity_Bill
{
    public static void Main(String[] args)
    {
        List<string> cust_id=new List<string>();
        List<string> cust_name=new List<string>();
        List<int> units_used=new List<int>();
        string add_record="yes";
        int total_customer=1;
        while (add_record.ToLower()=="yes")
        {
            Console.WriteLine("Enter the details of the Customer : "+total_customer);
            Console.Write("Enter the customer ID : ");
            string id=Console.ReadLine();
            cust_id.Add(id);
            Console.Write("Enter the customer name : ");
            string name=Console.ReadLine();
            cust_name.Add(name);
            Console.Write("Enter the units consumed : ");
            int units=Convert.ToInt32(Console.ReadLine());
            units_used.Add(units);
            Console.Write("Do you want to add another customer record[yes/no] : ");
            add_record=Console.ReadLine();
            if(add_record.ToLower()=="yes") total_customer++;
        }
        List<double> charges = new List<double>();
        List<double> sub_charge=new List<double>();
        for(int i = 0; i <units_used.Count();i++)
        {
            if(units_used[i]>=0 && units_used[i] <= 100)
            {
                charges.Add(1000);
                sub_charge.Add(1000*0.05);
            }
            else if(units_used[i]>100 && units_used[i] <= 150)
            {
                charges.Add(1500);
                sub_charge.Add(1000*0.10);
            }
            else
            {
                charges.Add(2000);   
                sub_charge.Add(1000*0.15);             
            }
        }
        int fixed_charge=200;
        List<double> total_charges=new List<double>();
        double total_amount=0;
        for(int i = 0; i < charges.Count(); i++)
        {
            total_amount+=(charges[i]+sub_charge[i]+fixed_charge);
            total_charges.Add(charges[i]+sub_charge[i]+fixed_charge);
        }

        Console.WriteLine("----Individual Customer Billing Report----");

        for(int i = 0; i < charges.Count(); i++)
        {
            Console.WriteLine("Customer Id : "+cust_id[i]);
            Console.WriteLine("Customer Name : "+cust_name[i]);
            Console.WriteLine("Total Units Consumed : "+units_used[i]);
            Console.WriteLine("Charges of the Units Consumed : "+charges[i]);
            Console.WriteLine("Subcharge for the Units Consumed : "+sub_charge[i]);
            Console.WriteLine("Fixed charges : "+fixed_charge);
            Console.WriteLine("Total charges : "+total_charges[i]);
        }
        Console.WriteLine("----Total Customer Report----");
        Console.WriteLine("Total Customers : "+total_customer);
        Console.WriteLine("Total amount collected : "+total_amount);
    }
}