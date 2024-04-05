using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        // get ranges from user
        Console.Write("Enter the start no : ");
        int startNo = int.Parse(Console.ReadLine());
        Console.Write("Enter the End Number : ");
        int endNo = int.Parse(Console.ReadLine());
        int sum=0;
        
        for(int i = startNo +1;i<endNo;i++)
        {
            sum+=i*i;
        }
        Console.WriteLine($"The result is {sum}");
    }
}
