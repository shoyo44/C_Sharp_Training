using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class Birds_Constructor
{
    public class Birds
    {
        string bird_name;

        public Birds(string name)
        {
            bird_name=name;

            Console.WriteLine("The name of the bird is : "+name);
            
        }
        public void make_sound(string sound)
        {
            Console.WriteLine("The sound of the brid is : "+sound);
        }
    }
    public class Parrot : Birds
    {
        public Parrot(string name) : base(name)
        {
            make_sound("kichkich");
        }
        
    }
    public class Sparrow: Birds
    {
        public Sparrow(string name) : base(name)
        {
            make_sound("kookoo");
        }
        
    }
    public static void Main(String[] args)
    {
        Parrot obj= new Parrot("Parrot");
        Sparrow obj1=new Sparrow("Sparrow");
        
    }
}