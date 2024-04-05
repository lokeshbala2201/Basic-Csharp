using System;
using System.Collections.Generic;
using System.Reflection;
namespace ListAssignment1;
class Program{
    public static void Main(string[] args)
    {
        List<CustomerDetails> CustomerList=new List<CustomerDetails>();
        string decision="";
        string decision1="";
        
        do{
            Console.WriteLine("1.Registration\n2.Login\n3.Exit");
            decision=Console.ReadLine();
            if(decision=="1"){
                Console.Write("Enter Your Name : ");
                string CostomerName=Console.ReadLine();
                Console.Write("Enter Your Balance : ");
                int Balance=int.Parse(Console.ReadLine());
                Console.Write("Enter Your Gender : ");
                Gender CusGender=Enum.Parse<Gender>(Console.ReadLine(),true);
                Console.Write("Enter Your PhoneNO : ");
                long PhoneNo=long.Parse(Console.ReadLine());
                Console.Write("Enter Your Date Of Birth : ");
                DateTime DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                Console.Write("Enter Your EmailId : ");
                string MailId=Console.ReadLine();
                CustomerDetails customer1=new CustomerDetails(CostomerName,Balance,CusGender,PhoneNo,MailId,DOB);
                CustomerList.Add(customer1);
                
            } 
        
            else if(decision=="2"){ 
                Console.Write("Enter Your Register Customer Id: ");
                int EmpId=int.Parse(Console.ReadLine());
                bool flag = true;  
                foreach(CustomerDetails customer in CustomerList){
                    
                    if(customer.CustomerID==EmpId ){
                        flag=false;
                        Console.WriteLine($"Hi, {customer.CostomerName}");
                        Console.WriteLine("2,1. Deposit\n2,2. Withdraw\n2,3. Balance\n2,4. Exit");
                        decision=Console.ReadLine();
                        if(decision=="2,1"){
                        Console.Write("Enter the deposit Amount : ");
                        customer.Deposit=int.Parse(Console.ReadLine());
                       
                        customer.DepositAmount(customer.Deposit);
                        Console.WriteLine($"Hi {customer.CostomerName}, {customer.Deposit} rupees deposit into your account");
                        Console.WriteLine($"Current balance is {customer.Balance}");
                        }else if(decision=="2,2"){
                            Console.Write("Enter the withdraw Amount : ");
                            customer.Withdraw=int.Parse(Console.ReadLine());
                            customer.WithdrawAmount(customer.Withdraw);
                            Console.WriteLine($"Hi {customer.CostomerName}, {customer.Withdraw} rupees deposit from your account");
                            Console.WriteLine($"Current balance is {customer.Balance}");
                            
                           
                        }else if(decision=="2,3"){
                            Console.WriteLine($"{customer.Balance}/- Rupees");
                           
                        }else if(decision=="2,4"){
                            break;
                        }

                    
                    } 
                }
                if(flag){
                    Console.WriteLine("Invalid user id");
                    Console.WriteLine("Please contact your branch");
                } 
            }
            else if(decision=="3"){
                break;
            }
            Console.Write("Do you want Countinue: ");
            decision1=Console.ReadLine();   
        }while(decision1=="yes");          
    
    } 
}        
       
    

