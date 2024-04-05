using System;
using System.Collections.Generic;
namespace ListAssignment3;
class Program{
    public static void Main(string[] args)
    {
        List<EBDetails> EBDetailsList=new List<EBDetails>();
        string decision="";
        string finaldecision="yes";
        do{
            Console.WriteLine("1.Registration\n2.Login\n3.Exit");
            decision=Console.ReadLine();
            if(decision=="1"){
                Console.Write("Enter Your Name : ");
                string userName=Console.ReadLine();
                Console.Write("Enter Your PhoneNO : ");
                long phone=long.Parse(Console.ReadLine());
                Console.Write("Enter Your Email ID : ");
                string email=Console.ReadLine();
                Console.Write("Units used : ");
                int unit=int.Parse(Console.ReadLine());
                EBDetails EBmeter=new EBDetails(userName,phone,email,unit);
                EBDetailsList.Add(EBmeter);
                
            } 
        
            else if(decision=="2"){ 
                Console.Write("Enter Your Register EB bill Id: ");
                string EBbill=Console.ReadLine();
                bool flag = true;  
                foreach(EBDetails EB in EBDetailsList){
                    
                    if(EB.MeterId==EBbill){
                        flag=false;
                        Console.WriteLine($"Hi, {EB.UserName}");
                        Console.WriteLine("1. Calculate Amount\n2. Show User Details\n3. Exit");
                        decision=Console.ReadLine();
                        if(decision=="1"){
                            Console.WriteLine($"Amount Pay : {EB.UnitAmount()}");
                       
                        }else if(decision=="2"){
                           Console.Write($"EB Bill ID : {EB.EmailID}\nUser Name : {EB.UserName}\nPhone No : {EB.PhoneNo}\nUnit Used : {EB.UnitUsed}\n"); 
                           
                        }else if(decision=="3"){
                           finaldecision="yes";
                        }

                    
                    } 
                }
                if(flag){
                    Console.WriteLine("Invalid bill id");
                    
                } 
            }
            else if(decision=="3"){
                finaldecision="no";
            }
              
        }while(finaldecision=="yes");
    }
}
