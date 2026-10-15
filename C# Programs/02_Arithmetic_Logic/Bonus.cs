using System;
public class Bonus
{
    public static void Main(String[] args)
    {
        Console.Write("Enter employee name : ");
        String name = Console.ReadLine();
        Console.Write("Enter employee salary : ");
        double salary = Convert.ToDouble(Console.ReadLine());

        double bonus;

        if (salary > 50000)
        {
            bonus = salary * 0.20;
            Console.WriteLine("Employee   : " + name);
            Console.WriteLine("Salary     : " + salary);
            Console.WriteLine("Bonus (20%): " + bonus);
            Console.WriteLine("Total CTC  : " + (salary + bonus));
        }
        else if (salary > 30000)
        {
            bonus = salary * 0.15;
            Console.WriteLine("Employee   : " + name);
            Console.WriteLine("Salary     : " + salary);
            Console.WriteLine("Bonus (15%): " + bonus);
            Console.WriteLine("Total CTC  : " + (salary + bonus));
        }
        else if (salary > 10000)
        {
            bonus = salary * 0.10;
            Console.WriteLine("Employee   : " + name);
            Console.WriteLine("Salary     : " + salary);
            Console.WriteLine("Bonus (10%): " + bonus);
            Console.WriteLine("Total CTC  : " + (salary + bonus));
        }
        else
        {
            Console.WriteLine("Employee   : " + name);
            Console.WriteLine("Salary     : " + salary);
            Console.WriteLine("No bonus applicable for salary below 10000.");
        }
    }
}
