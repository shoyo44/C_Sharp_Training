using System;
public class Country_Constructor
{
    public class Country
    {
        string country_name;
        public Country(string country_name)
        {
            this.country_name=country_name;
        }
        public void Capital(string country_capital)
        {
            Console.WriteLine("The capital of the country "+country_name+" is "+country_capital);
        }
        public void Language(string country_language)
        {
            Console.Write("The language of the country "+country_name+" is "+country_language);
        }
    }
    public class India : Country
    {
        public India(string name) : base(name)
        {
        }
    }
}