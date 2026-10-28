using System;
public class Heirarchical_Inheritance{
public class College
{

    public void ShowCollegeInformation()
    {
        Console.WriteLine("College name : Kalasalingam College");
        Console.WriteLine("College address : KrishnanKovil,VirudhuNagar");
        Console.WriteLine("Principal name : RajaSubramanian");
        Console.WriteLine("Established year : 1983");
    }
}
public class Student : College
{
    public void ShowStudentDetails(string name,int age,string dept,int roll_number)
    {
        Console.WriteLine("Student name : "+name);
        Console.WriteLine("Student age : "+age);
        Console.WriteLine("Department of the student : "+dept);
        Console.WriteLine("Registration number of the student : "+roll_number);
    }
}
public class Professor : College
{
    public void ShowProfessorDetails(string name,int age,string dept,int roll_number)
    {
        Console.WriteLine("Professor name : "+name);
        Console.WriteLine("Professor age : "+age);
        Console.WriteLine("Department of the Professor : "+dept);
        Console.WriteLine("Experience of the professor : "+roll_number);
    }
}
public static void Main(String[] args)
{
    Console.Write("Enter Choice 1 for student or 2 for Faculty : ");
    int choice=Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.Write("Enter the student name : ");
        string name=Console.ReadLine();
        Console.Write("Enter the age of the student : ");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the department of the student : ");
        string dept=Console.ReadLine();
        Console.Write("Enter the registration number  of the student : ");
        int reg_no=Convert.ToInt32(Console.ReadLine());
        Student obj=new Student();
        obj.ShowStudentDetails(name,age,dept,reg_no);
        obj.ShowCollegeInformation();
    }
    else if (choice == 2)
    {
        Console.Write("Enter the Faculty name : ");
        string name=Console.ReadLine();
        Console.Write("Enter the age of the Professor : ");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the department of the Professor : ");
        string dept=Console.ReadLine();
        Console.Write("Enter the experience of the professor : ");
        int exp=Convert.ToInt32(Console.ReadLine());
        Professor obj=new Professor();
        obj.ShowProfessorDetails(name,age,dept,exp);
        obj.ShowCollegeInformation();
    }
    else
        {
           Console.WriteLine("Please enter the vaild choice!"); 
        }
}
}