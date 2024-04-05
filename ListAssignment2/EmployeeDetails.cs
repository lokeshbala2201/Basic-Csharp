using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListAssignment2;
public enum WorkPlace{Select,Chennai,California,Kenya};
public enum Gender{select,Male,Female,Transgender};
    public class EmployeeDetails
    {
        //field
        private static int s_employeeId=1000;
        //Property
        public string EmployeeId { get; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public WorkPlace WorkPlace { get; set; }
        public string TeamName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int NoOfWorkingMonth { get; set; }
        public int NoOfLeave { get; set; }
        public Gender Gender { get; set; }

        public EmployeeDetails(string employeeName,string role,WorkPlace workplace,string teamName,DateTime doj,int workingDays,int leave,Gender gender){
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            EmployeeName=employeeName;
            Role=role;
            WorkPlace=workplace;
            TeamName=teamName;
            DateOfJoining=doj;
            NoOfWorkingMonth=workingDays;
            NoOfLeave=leave;
            Gender=gender;
        }
        public float SalarDeduction(){
            float workedDays=NoOfWorkingMonth-NoOfLeave;
            return workedDays*500;
        }


    }
