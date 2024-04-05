using System;
namespace SwitchCase;
class Program{
    public static void Main(string[] args)
    {
        // getting input from user
        Console.Write("Enter the number1 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the  number2 : ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("+ (addition)\n- (subtraction) \n* (Multiplication) \n/ (Division) \n% (Modulus) ");
        Console.Write("Enter the option : ");
        string option = Console.ReadLine();
        switch(option){
            case "+":
            {
              Console.WriteLine(num1+num2);
              break;  
            }
            case "-" :
            {
                Console.WriteLine(num1-num2);
                break;
            }
            case "*":
            {
                Console.WriteLine(num1*num2);
                break;
            }
            case "/":
            {
                Console.WriteLine(num1/num2);
                break;
            }
            case "%":
            {
                Console.WriteLine(num1%num2);
                break;
            }default:
            {
                Console.WriteLine("Invalid Operation");
                break;
            }

        }
    }
}
