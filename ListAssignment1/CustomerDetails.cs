using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ListAssignment1;

namespace ListAssignment1;
public enum Gender{Select,male,female,Trasgender};

    
        
    
    public class CustomerDetails
    {
         private static int s_customerID=1000;
        public int CustomerID{ get;  }
        public string CostomerName { get; set; }
        public int Balance { get; set; }
        public Gender CusGender { get; set; }
        public long PhoneNo { get; set; }
        public string MailId { get; set; }
        public DateTime DOB { get; set; }
        public int Deposit { get; set; }
        public int Withdraw { get; set; }
        public CustomerDetails(string Cname,int balance,Gender gender,long phone,string mail,
        DateTime date){
            s_customerID++;
            CustomerID=s_customerID;
            CostomerName=Cname;
            Balance=balance;
            CusGender=gender;
            PhoneNo=phone;
            MailId=mail;
            DOB= date;
        }

        public int DepositAmount(int money)
        {
           return Balance+=money;
        }
        public int WithdrawAmount(int money){
            return Balance-=money;
        }
    }
