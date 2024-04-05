using System;
namespace DoWhile;
class Program{
    public static void Main(string[] args)
    {
        bool temp = false;
        do
        {   Console.Write("Enter the number : ");
            int number = int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine($"{number} is Even");

            }else{
                Console.WriteLine($"{number} is ODD");
            }
            Console.Write("Do you want repeat the process with another no : yes / no ");
            string YesNo = Console.ReadLine();
            if(YesNo != "yes" && YesNo!="no"){
                Console.Write("Invalid input : Enter valid input : ");
                YesNo = Console.ReadLine();
            }
            if(YesNo=="yes"){
                temp=true;
            }else{
                temp=false;
            }
        }while(temp);
    }
}