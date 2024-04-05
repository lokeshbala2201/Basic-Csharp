using System;
namespace IfCondition;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Mark : ");
        int mark = int.Parse(Console.ReadLine());
        if(mark >80 && mark<=100)
        {
            Console.WriteLine("Grade A");
        }
        else if(61 <= mark && mark<= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if(36<=mark && mark<=60)
        {
            Console.WriteLine("Grade C");
        }
        else if(mark<36 && mark >=0)
        {Console.WriteLine("Grade D");
        }
        else{
            Console.WriteLine("Invalid Input");
            }
    }
}
