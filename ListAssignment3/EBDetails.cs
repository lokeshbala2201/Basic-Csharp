using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListAssignment3
{
    public class EBDetails
    {
        private static int s_meterid=1000;
        public string MeterId { get;  }
        public string UserName { get; set; }
        public long PhoneNo { get; set; }
        public string EmailID { get; set; }
        public int UnitUsed { get; set; }
        public EBDetails(string username,long phone,string email,int unit){
            s_meterid++;
            MeterId="EB"+s_meterid;
            UserName=username;
            PhoneNo=phone;
            EmailID=email;
            UnitUsed=unit;
        }
        public float UnitAmount(){
            float amount=0;
            return amount=UnitUsed*5;
        }

    }
    
}