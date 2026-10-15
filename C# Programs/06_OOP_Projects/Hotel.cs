using System;
using System.ComponentModel;
using System.Runtime;
public class Hotel
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the name of the customer : ");
        string name=Console.ReadLine();
        Console.Write("Is membership included [yes/no]: ");
        string membership=Console.ReadLine();
        membership=membership.ToLower();
        Console.Write("Please select the room type [Standard,Deluxe,Suite]");
        string room_type=Console.ReadLine();
        Console.Write("Enter the number of days of your visit : ");
        int days=Convert.ToInt32(Console.ReadLine());
        room_type=room_type.ToLower();
        switch (room_type)
        {
            case "suite":
                if (membership == "yes")
                {
                    double amount=days*2000;
                    double membership_amount=amount*.05;
                    amount-=membership_amount*.05;
                    double food_charge=days*500;
                    amount=food_charge+amount;
                    double GST=amount*0.12;
                    amount=amount+GST;
                    Console.WriteLine("---Billing Receipt---");
                    Console.WriteLine("Name of the Customer : "+name);
                    Console.WriteLine("Membership Included");
                    Console.WriteLine("Room type : Suite");
                    Console.WriteLine("Number of days : "+days);
                    Console.WriteLine("Food charge : "+food_charge);
                    Console.WriteLine("Amount excluded for membership : "+membership_amount);
                    Console.WriteLine("Total GST amount : "+GST);
                    Console.WriteLine("Total amount including GST,Food charge and discount : "+amount);
                }
                else
                {
                    double amount=days*2000;
                    double food_charge=days*500;
                    amount=food_charge+amount;
                    double GST=amount*0.12;
                    amount=amount+GST;
                    Console.WriteLine("---Billing Receipt---");
                    Console.WriteLine("Name of the Customer : "+name);
                    Console.WriteLine("Membership Not Included");
                    Console.WriteLine("Room type : Suite");
                    Console.WriteLine("Number of days : "+days);
                    Console.WriteLine("Food charge : "+food_charge);
                    Console.WriteLine("Total GST amount : "+GST);
                    Console.WriteLine("Total amount including GST,Food charge and discount : "+amount);
                }
                break;
            case "deluxe":
                if (membership == "yes")
                {
                    double amount=days*1500;
                    double membership_amount=amount*.05;
                    amount-=membership_amount*.05;
                    double food_charge=days*500;
                    amount=food_charge+amount;
                    double GST=amount*0.12;
                    amount=amount+GST;
                    Console.WriteLine("---Billing Receipt---");
                    Console.WriteLine("Name of the Customer : "+name);
                    Console.WriteLine("Membership Included");
                    Console.WriteLine("Room type : Deluxe");
                    Console.WriteLine("Number of days : "+days);
                    Console.WriteLine("Food charge : "+food_charge);
                    Console.WriteLine("Amount excluded for membership : "+membership_amount);
                    Console.WriteLine("Total GST amount : "+GST);
                    Console.WriteLine("Total amount including GST,Food charge and discount : "+amount);
                }
                else
                {
                    double amount=days*1500;
                    double food_charge=days*500;
                    amount=food_charge+amount;
                    double GST=amount*0.12;
                    amount=amount+GST;
                    Console.WriteLine("---Billing Receipt---");
                    Console.WriteLine("Name of the Customer : "+name);
                    Console.WriteLine("Membership Not Included");
                    Console.WriteLine("Room type : Deluxe");
                    Console.WriteLine("Number of days : "+days);
                    Console.WriteLine("Food charge : "+food_charge);
                    Console.WriteLine("Total GST amount : "+GST);
                    Console.WriteLine("Total amount including GST,Food charge and discount : "+amount);
                }
                break;
                case "standard":
                if (membership == "yes")
                {
                    double amount=days*1000;
                    double membership_amount=amount*.05;
                    amount-=membership_amount*.05;
                    double food_charge=days*500;
                    amount=food_charge+amount;
                    double GST=amount*0.12;
                    amount=amount+GST;
                    Console.WriteLine("---Billing Receipt---");
                    Console.WriteLine("Name of the Customer : "+name);
                    Console.WriteLine("Membership Included");
                    Console.WriteLine("Room type : Standard");
                    Console.WriteLine("Number of days : "+days);
                    Console.WriteLine("Food charge : "+food_charge);
                    Console.WriteLine("Amount excluded for membership : "+membership_amount);
                    Console.WriteLine("Total GST amount : "+GST);
                    Console.WriteLine("Total amount including GST,Food charge and discount : "+amount);
                }
                else
                {
                    double amount=days*1000;
                    double food_charge=days*500;
                    amount=food_charge+amount;
                    double GST=amount*0.12;
                    amount=amount+GST;
                    Console.WriteLine("---Billing Receipt---");
                    Console.WriteLine("Name of the Customer : "+name);
                    Console.WriteLine("Membership Not Included");
                    Console.WriteLine("Room type : Standard");
                    Console.WriteLine("Number of days : "+days);
                    Console.WriteLine("Food charge : "+food_charge);
                    Console.WriteLine("Total GST amount : "+GST);
                    Console.WriteLine("Total amount including GST,Food charge and discount : "+amount);
                }
                break;
            default:
            Console.WriteLine("Please enter the valid details!");
            break;
        }
    }
}