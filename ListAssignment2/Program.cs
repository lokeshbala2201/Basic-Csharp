using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace ListAssignment2;
class Program{
    public static void Main(string[] args)
    {
        string finalDecision="yes";
        string decision="";
        List<EmployeeDetails> EmployeeList=new List<EmployeeDetails>();
       do{
            Console.WriteLine("1.Registration\n2.Login\n3.Exit");
            decision=Console.ReadLine();
            if(decision=="1"){
                Console.Write("Enter your name : ");
                string cName=Console.ReadLine();
                Console.Write("Enter your Role : ");
                string role=Console.ReadLine();
                Console.Write("Enter your Workplace : ");
                WorkPlace workPlace=Enum.Parse<WorkPlace>(Console.ReadLine(),true);
                Console.Write("Enter your Team Name : ");
                string team=Console.ReadLine();
                Console.Write("Enter your Date Of Joining : ");
                DateTime doj=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                Console.Write("No of Working in this month : ");
                int workingDays=int.Parse(Console.ReadLine());
                Console.Write("Total Leaves Taken : ");
                int leaves=int.Parse(Console.ReadLine());
                Console.Write("Enter your Gender : ");
                Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
                EmployeeDetails Employee=new EmployeeDetails(cName,role,workPlace,team,doj,workingDays,leaves,gender);
                EmployeeList.Add(Employee);
                Console.WriteLine($"Your Employee ID is {Employee.EmployeeId}");


            }else if(decision=="2"){
                Console.Write("Enter your Registered EmployeeID :");
                string employeeid=Console.ReadLine();
                bool flag = true;
                foreach(EmployeeDetails Employee in EmployeeList){
                    if(employeeid==Employee.EmployeeId){
                        flag=false;
                        Console.WriteLine("1.Salary Calculate\n2.Show Details\n3.Exit");
                        decision=Console.ReadLine();
                        if(decision=="1"){
                            Console.WriteLine($"Hi,{Employee.EmployeeName}\nThis month Take-Home salary is - {Employee.SalarDeduction()}/-");
                        }
                        else if(decision=="2"){
                            Console.Write($"Employee Id : {Employee.EmployeeId}\nEmployee Name : {Employee.EmployeeName}\nRole : {Employee.Role}\n");
                            Console.Write($"Work Place : {Employee.WorkPlace}\nTeam Name : {Employee.TeamName}\nDate Of Joining : {Employee.DateOfJoining.ToString("dd/MM/yyyy")}\n");
                            Console.Write($"Total Working Days : {Employee.NoOfWorkingMonth}\nLeaveTaken : {Employee.NoOfLeave}\nGender : {Employee.Gender}\n");
                        }else if(decision=="3"){
                            
                            finalDecision="yes";

                        }
                    }
                }
                if(flag){
                    Console.WriteLine("Invalid Id");
                    finalDecision="no";
                }
                

            }else if(decision=="3"){
                finalDecision="no";
            }
            
       }while(finalDecision=="yes"); 
    }
}
