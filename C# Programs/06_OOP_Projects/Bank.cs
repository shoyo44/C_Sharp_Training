//1)ATM pin number ,balance ,cjoice deposit or withdrawal using gpay,netbanking,amount shaould be 
//lesser than withdrawal
using System;
public class Bank
{
    public static void Main(String[] args)
    {
        int pin=102005;
        double balance=1000;
        Console.Write("Enter your PIN Number : ");
        int user_pin=Convert.ToInt32(Console.ReadLine());
        if (user_pin == pin)
        {
             Console.Write("Willing to do withdrawal,deposit or balance checking: ");
             string mode_type=Console.ReadLine();
             mode_type=mode_type.ToLower();
            if (mode_type == "withdrawal")
            {
                Console.Write("Enter the withdrawal amount : ");
                double withdrawal_amount=Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your PIN Number : ");
                int pr_pin=Convert.ToInt32(Console.ReadLine());
                if (withdrawal_amount < balance && pr_pin==pin)
                {
                    Console.WriteLine("Amount "+withdrawal_amount+" successfully withdrawed");
                    balance=(double)balance-withdrawal_amount;
                    Console.WriteLine("Current balance RS: "+balance);

                }
                else
                {
                    Console.WriteLine("The withdrawal amount Rs "+withdrawal_amount+" is greater than the balance "+balance);
                }
            }
            else if(mode_type=="deposit")
            {
                Console.Write("Enter the deposit amount : ");
                double deposit_amount=Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your PIN Number : ");
                int pr_pin=Convert.ToInt32(Console.ReadLine());
                if(pr_pin==pin){
                balance=balance+deposit_amount;
                Console.WriteLine("The current balance is : "+balance);
                }
            }
            else if(mode_type=="balance")
            {
                Console.WriteLine("Balance Checking");
                Console.Write("Enter the pin number : ");
                int pr_pin=Convert.ToInt32(Console.ReadLine());
                if(pr_pin==pin) Console.WriteLine("The current balance is Rs : "+balance);
                
            }
            else Console.WriteLine("Please enter the valid details and PIN number!");
        }
        else Console.WriteLine("Please enter the valid details and PIN number!");
    }
}