using System;
using System.Data;
public class Order
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the Product Name [Watch,Stationary,Dress] : ");
        string name=Console.ReadLine();
        name=name.ToLower();
        Console.Write("Enter the quantity of the product : ");
        int quantity=Convert.ToInt32(Console.ReadLine());
        string[] coupon=["wat001","sat002","dre003"];
        switch (name)
        {
            case "watch":
            Console.Write("Enter the coupon code (if applicable else enter NA) : ");
            string coupon_code=Console.ReadLine();
                if (coupon_code == coupon[0])
                {
                    Console.WriteLine("Product Name : "+name);
                    if (quantity < 5) quantity=5;
                    Console.WriteLine("Quantity : "+quantity);
                    double amount=5000*quantity;
                    double coupon_amount=amount*.15;
                    amount-=coupon_amount;
                    Console.WriteLine("Coupon code deduced amount : "+coupon_amount);
                    Console.WriteLine("Total Amount : "+amount);

                }
                else
                {
                    Console.WriteLine("Product Name : "+name);
                    if (quantity < 5) quantity=5;
                    Console.WriteLine("Quantity : "+quantity);
                    double amount=5000*quantity;
                    Console.WriteLine("Total Amount : "+amount);
                }
            break;
            case "stationary":
            Console.Write("Enter the coupon code (if applicable else enter NA) : ");
            string coupon_code1=Console.ReadLine();
                if (coupon_code1 == coupon[1])
                {
                    Console.WriteLine("Product Name : "+name);
                    if (quantity < 5) quantity=5;
                    Console.WriteLine("Quantity : "+quantity);
                    double amount=3000*quantity;
                    double coupon_amount=amount*.15;
                    amount-=coupon_amount;
                    Console.WriteLine("Coupon code deduced amount : "+coupon_amount);
                    Console.WriteLine("Total Amount : "+amount);

                }
                else
                {
                    Console.WriteLine("Product Name : "+name);
                    if (quantity < 5) quantity=5;
                    Console.WriteLine("Quantity : "+quantity);
                    double amount=3000*quantity;
                    Console.WriteLine("Total Amount : "+amount);
                }
            break;
            case "dress":
            Console.Write("Enter the coupon code (if applicable else enter NA) : ");
            string coupon_code2=Console.ReadLine();
                if (coupon_code2 == coupon[2])
                {
                    Console.WriteLine("Product Name : "+name);
                    if (quantity < 5) quantity=5;
                    Console.WriteLine("Quantity : "+quantity);
                    double amount=8000*quantity;
                    double coupon_amount=amount*.15;
                    amount-=coupon_amount;
                    Console.WriteLine("Coupon code deduced amount : "+coupon_amount);
                    Console.WriteLine("Total Amount : "+amount);

                }
                else
                {
                    Console.WriteLine("Product Name : "+name);
                    if (quantity < 5) quantity=5;
                    Console.WriteLine("Quantity : "+quantity);
                    double amount=8000*quantity;
                    Console.WriteLine("Total Amount : "+amount);
                }
            break;
            default:
            Console.WriteLine("Please enter the valid product!");
            break;


            
        }
        
        
    }
}