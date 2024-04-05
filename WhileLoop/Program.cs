using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        int i=0;
        while(i<=25)
        {
            if(i%2==0){
                Console.WriteLine(i);
            }
            i++;
        }


        Console.Write("Ener The number : ");
        int number;
        bool check = int.TryParse(Console.ReadLine(),out number);
        int  j=0;
        while (j==0){
              if(check==true)
              {
                Console.WriteLine(number);
                break;
              }
              else
              {
                Console.Write("Enter The valid number : ");
                check=int.TryParse(Console.ReadLine(),out number);
              }

            }
           

        
    }
}