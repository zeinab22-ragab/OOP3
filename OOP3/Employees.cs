using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP3
{

    ///Q1.2
///    public class Employees
///    {
///        public int Id {  get; set; }
///        public string Name { get; set; }
///
///        private string gender;      
///        public string Gender
///        {
///            get { return gender; }
///            set
///              {
///                if (value == "Male" || value == "Female")
///                    gender = value;
///                else
///                    throw new ArgumentException("Not Found");
///              }
///        }
///
///        public decimal Salary { get; set; }
///        public HiringDate HiringDate { get; set; }
///        public SecurityLevel SecurityLevel { get; set; }
///
///
///        public Employees(int id, string name, string gender, decimal salary, HiringDate hiringDate, SecurityLevel securityLevel)
///        {
///            Id = id;
///            Name = name;
///            Gender = gender;
///            Salary = salary;
///            HiringDate = hiringDate;
///            SecurityLevel = securityLevel;
///        }
///
///
///        public override string ToString()
///        {
///            return string.Format($" ID : {Id} \n Name : {Name} \n Gender : {Gender} \n Salary : {Salary:C} \n HiringDate : {HiringDate} \n SecurityLevel : {SecurityLevel}");
///        }









    }
}
