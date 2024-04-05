using System;
namespace DateTimeAssignment;
class Program{
    public static void Main(string[] args)
    { 
        ="2022,08,10,10,40,32";
        DateTime date = new DateTime(2022,08,10,10,40,32);
        Console.WriteLine(date.ToString("yyyy"));
        Console.WriteLine(date.ToString("MM"));
        Console.WriteLine(date.ToString("dd"));
        Console.WriteLine(date.ToString("hh"));
        Console.WriteLine(date.ToString("mm"));
        Console.WriteLine(date.ToString("ss")); 
        string 
     
        string dateStr = Convert.ToString(date);
        string[] strArray =inP.Split(",");
        for(int i =strArray.Length-1;i>=0;i--){
            Console.Write(strArray[i]+" ");
            
        }
        Console.WriteLine();
        Console.Write("Enter the date this format yyyy/MM/dd hh:mm:ss tt : ");
        DateTime userIn = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        Console.WriteLine(userIn.ToString("yyyy"));
        Console.WriteLine(userIn.ToString("MM"));
        Console.WriteLine(userIn.ToString("dd"));


    }
}