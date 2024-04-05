using System;
using System.ComponentModel;
using System.Diagnostics;
namespace MethodAssignment;
class Program{
    public static void Main(string[] args)
    {
        string process="";
        do{
            Console.Write("Enter the number 1 : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the number 2 : ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Addtion\n2.Subtraction\n3.Multiplication\n4.Division");
            Console.Write("Select Option : ");
            int option=int.Parse(Console.ReadLine());
            switch(option){
                case 1:{
                    Console.WriteLine(Add(number1,number2));
                    break;
                }
                case 2:{
                    Console.WriteLine(Sub(number1,number2));
                    break;
                }
                case 3:{
                    Console.WriteLine(Mul(number1,number2));
                    break;
                }
                case 4:{
                    Console.WriteLine(Div(number1,number2));
                    break;
                }

            }
            Console.Write("Do you want repeat this process yes/no  : ");
             process = Console.ReadLine();
        }while(process=="yes");
        int Add(int x,int y){
            int result = (x+y);
            return result;
        }
        int Sub(int x,int y){
            int result = (x-y);
            return result;
        }
        int Mul(int x,int y){
            int result = (x*y);
            return result;
        }
        int Div(int x,int y){
            int result = (x/y);
            return result;            
        }



    }
}



