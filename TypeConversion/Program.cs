using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        //Getting inputs from user
        Console.Write("Enter your name : ");
        string name = Console.ReadLine();
        Console.Write("Enter age : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1 : ");
        float subject1 = float.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        float subject2 = float.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3 : ");
        float subject3 = float.Parse(Console.ReadLine());
        Console.Write("Enter Grade : ");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("enter mobile number : ");
        long mobile = Convert.ToInt64(Console.ReadLine());
        Console.Write("Enter Email : ");
        string email = Console.ReadLine();
        float total = subject1+subject2+subject3;
        float avarage = total/3;

        //printing in console
        Console.WriteLine("Trainee Datails are :");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Age : {age}");
        Console.WriteLine($"Mobile : {mobile}");
        Console.WriteLine($"Marks1 : {subject1}");
        Console.WriteLine($"Marks2 : {subject2}");
        Console.WriteLine($"Marks3 : {subject3}");
        Console.WriteLine($"Total : {total}");
        Console.WriteLine($"Average : {avarage}");
        Console.WriteLine($"Grade : {grade}");
        Console.WriteLine($"Email : {email}" );

    }
}