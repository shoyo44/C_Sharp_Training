using System;
using System.Diagnostics;
using System.Runtime;
using System.Threading.Tasks.Dataflow;
public class Hospital
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the patient name : ");
        string name=Console.ReadLine();
        Console.Write("Enter the Patient age : ");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of days the patient admitted : ");
        int days=Convert.ToInt32(Console.ReadLine());
        double general_charge=500;
        double private_charge=2000;
        double ICU_charge=5000;
        double consultation=800;
        Console.WriteLine("Enter the room type [General,Private,ICU] : ");
        string ward_type=Console.ReadLine();
        ward_type=ward_type.ToLower();
        switch (ward_type)
        {
            case "general":
                if (age >= 50)
                {
                    general_charge*=days;
                    general_charge+=consultation;
                    general_charge-=general_charge*.05;
                    Console.WriteLine("---Patient Billing Receipt---");
                    Console.WriteLine("Patient name : "+name);
                    Console.WriteLine("Patient age : "+age);
                    Console.WriteLine("senior Citizen discount 5% included");
                    Console.WriteLine("Room type : General");
                    Console.WriteLine("Total Billing Amount : "+general_charge);
                }
                else
                {
                    general_charge*=days;
                    general_charge+=consultation;
                    Console.WriteLine("---Patient Billing Receipt---");
                    Console.WriteLine("Patient name : "+name);
                    Console.WriteLine("Patient age : "+age);
                    Console.WriteLine("Room type : General");
                    Console.WriteLine("Total Billing Amount : "+general_charge);
                }
                break;
            case "private":
                if (age >= 50)
                {
                    private_charge*=days;
                    private_charge+=consultation;
                    private_charge-=private_charge*.05;
                    Console.WriteLine("---Patient Billing Receipt---");
                    Console.WriteLine("Patient name : "+name);
                    Console.WriteLine("Patient age : "+age);
                    Console.WriteLine("senior Citizen discount 5% included");
                    Console.WriteLine("Room type : Private");
                    Console.WriteLine("Total Billing Amount : "+private_charge);
                }
                else
                {
                    private_charge*=days;
                    private_charge+=consultation;
                    Console.WriteLine("---Patient Billing Receipt---");
                    Console.WriteLine("Patient name : "+name);
                    Console.WriteLine("Patient age : "+age);
                    Console.WriteLine("Room type : General");
                    Console.WriteLine("Total Billing Amount : "+private_charge);
                }
                break;
            case "icu":
            if (age >= 50)
                {
                    ICU_charge*=days;
                    ICU_charge+=consultation;
                    ICU_charge-=ICU_charge*.05;
                    Console.WriteLine("---Patient Billing Receipt---");
                    Console.WriteLine("Patient name : "+name);
                    Console.WriteLine("Patient age : "+age);
                    Console.WriteLine("senior Citizen discount 5% included");
                    Console.WriteLine("Room type : ICU");
                    Console.WriteLine("Total Billing Amount : "+ICU_charge);
                }
                else
                {
                    ICU_charge*=days;
                    ICU_charge+=consultation;
                    Console.WriteLine("---Patient Billing Receipt---");
                    Console.WriteLine("Patient name : "+name);
                    Console.WriteLine("Patient age : "+age);
                    Console.WriteLine("Room type : General");
                    Console.WriteLine("Total Billing Amount : "+ICU_charge);
                }
            break;
            default:
            Console.WriteLine("Please enter the valid details!");
            break;


        }

    }
}