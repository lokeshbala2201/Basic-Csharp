using System;
using System.Transactions;
namespace StringManipulation;
class Program{
    public static void Main(string[] args)
    {
     Console.Write("Enter the String :");
     string mainStr=Console.ReadLine();
     Console.Write("Enter the Searched string :");
     string searchStr=Console.ReadLine();
     string modify = mainStr.Replace(searchStr,"1");
     int count=0;
     foreach (char i in modify){
        if(i=='1'){
            count++;
        }
     }
     Console.WriteLine(count);
    }
}