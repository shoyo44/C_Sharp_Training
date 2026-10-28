using System;
public class Payment_factory
{
    public interface IPayement
    {
        public void amount(double amount);
    }
    public class UPI : IPayement
    {
        public void amount(double amount)
        {
            Console.WriteLine("The amount Rs: "+amount+" credited via UPI");
        }
    }
    public class Card : IPayement
    {
        public void amount(double amount)
        {
            Console.WriteLine("The amount Rs: "+amount+" credited via Cridit card");
        }
    }
    public class Cash : IPayement
    {
        public void amount(double amount)
        {
            Console.WriteLine("The amount Rs: "+amount+" credited via cash");
        }
    }
    public class AmountFactory
    {
        public static IPayement GetPaymentType(string paymenttype)
        {
            if(paymenttype=="UPI") return new UPI();
            else if(paymenttype=="Credit card") return new Card();
            else if(paymenttype=="Cash") return new Cash();
            else return null;
        }
    }
    public static void Main(String[] args)
    {
        IPayement obj1=AmountFactory.GetPaymentType("UPI");
        obj1.amount(2000);
    }
}
