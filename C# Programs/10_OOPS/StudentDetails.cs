using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
public class StudentDetails
{
    public void ShowStudentDetails(string name,int age,string dept,int roll_number)
    {
        Console.WriteLine("Student name : "+name);
        Console.WriteLine("Student age : "+age);
        Console.WriteLine("Department of the student : "+dept);
        Console.WriteLine("Registration number of the student : "+roll_number);
    }
    public int  CalculateTotal(int  eng_mark,int  maths_mark,int physics_mark,int chem_mark,int tamil_mark,int cs_mark)
    {
        int total_marks=eng_mark+maths_mark+physics_mark+chem_mark+tamil_mark+cs_mark;
        return total_marks;
    }
    public double CalculateAverage(int total_marks,int total_sub,int total_mark_alloted_per_subject)
    {
       
        double avg=(double)total_marks/(total_sub*total_mark_alloted_per_subject)*100;
        return avg;
    }
    public void DisplayGrade(double avg)
    {
        string grade=(avg>=90?("Garde S"):(avg>=80 && avg<90)?("Grade A"):(avg>=70 && avg<80)?("Garde B"):(avg>=50 && avg<70)?("Garde C"):(avg>=40 && avg<50)?("Garde D"):("Sorry you are Fail!"));
        Console.WriteLine("Your grade is : "+grade);
    }

    public static void Main(String[] args)
    {
        Console.Write("Enter the student name : ");
        string name=Console.ReadLine();
        Console.Write("Enter the age of the student : ");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the department of the student : ");
        string dept=Console.ReadLine();
        Console.Write("Enter the registration number  of the student : ");
        int reg_no=Convert.ToInt32(Console.ReadLine());
        string[] arr=["Tamil","English","Mathematics","Physics","Chemistry","Computer Science"];
        int[] marks=new int[6];
        for(int i=0;i<6;i++)
        {
            Console.Write("Enter your "+arr[i]+" Marks : ");
            int mark=Convert.ToInt32(Console.ReadLine());
            marks[i]=mark;
        }
        int total_sub=6;
        int marks_allotted=100;
        StudentDetails obj=new StudentDetails();
        obj.ShowStudentDetails(name,age,dept,reg_no);
        int total=obj.CalculateTotal(marks[0],marks[1],marks[2],marks[3],marks[4],marks[5]);
        Console.WriteLine("Total marks : "+total);
        double avg=obj.CalculateAverage(total,total_sub,marks_allotted);
        Console.WriteLine("The average marks is :"+avg);
        obj.DisplayGrade(avg);
    }
}