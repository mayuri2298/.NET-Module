using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();
            Console.WriteLine(o1.getNetSalary());
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
            Console.ReadLine();
        }
    }
    class Employee
    {
        private string empName;
        static int empNo=0;
        private decimal basicSal;
        private short deptNo;

        public Employee()
        {

        }
        public Employee(string empName,decimal basicSal,short deptNo)
        {
            empNo++;
            this.EmpNo = empNo;
            this.empName = empName;
            this.basicSal = basicSal;
            this.deptNo = deptNo;
        }
        public Employee(string empName,decimal basicSal)
        {
            empNo++;
            this.EmpNo = empNo;
            this.empName = empName;
            this.basicSal = basicSal;
        }
        public Employee(string empName)
        {
            empNo++;
            this.EmpNo = empNo;
            this.empName = empName;
        }
        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                if (value == null)
                {
                    empName = value;
                }
                else
                {
                    Console.WriteLine("invalid name");
                }
            }
        }
        public int EmpNo
        {
            get;
        }
        public decimal BasicSal
        {
            get
            {
                return basicSal;
            }
            set
            {
                if(value>100000 && value < 150000)
                {
                    basicSal = value;
                }
                else
                {
                    Console.WriteLine("salary is not between a range");
                }
            }
        }
        public short DeptNo
        {
            get
            {
                return deptNo;
            }
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("invalid dept number");
                }
            }
        }
        public decimal getNetSalary()
        {
            double diwaliBonus = 1000;
            decimal sal = basicSal + (decimal)diwaliBonus;
            return sal;
        }
    }
}
