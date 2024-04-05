using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        string[] names = new string[5] { "Loki", "Suresh,Ganesh", "Mani", "Venkat", "Venkat" };
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        int Count = 0;
        int count1 = 0;
        Console.Write("Enter the checking name : ");
        string getName = Console.ReadLine();
        for (int j = 0; j < names.Length; j++)
        {
            if (names[j] == getName)
            {
                Console.WriteLine($"The name is Present in Array, index posit is {j}");
                ++Count;
                break;
            }
        }
        if (Count == 0)
        {
            Console.WriteLine("The name is not present in array");
        }

        foreach (string k in names)
        {
            if (k == getName)
            {
                Console.WriteLine($"The name is Present in Array ");
                ++count1;
                break;
            }
        }
        if (count1 == 0)
        {
            Console.WriteLine("The name is not present in array");
        }

    }
}