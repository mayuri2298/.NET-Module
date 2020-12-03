using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mg = new Manager("mayuri", 1, 68000, "developer");
            Console.WriteLine(mg.EmpName+" "+mg.calcNetSalary());

            GeneralManager gm = new GeneralManager("mayuri", 2, 75000, "trainee", "fs");
            Console.WriteLine(gm.EmpName+" "+gm.calcNetSalary());

            CEO ce = new CEO("Mayuri", 10, 850000);
            Console.WriteLine(ce.EmpName+" "+ce.calcNetSalary());
            Console.ReadLine();
        }
    }
    public abstract class Employee
    {
        private string empName;
        private int empNo;
        public static int id;
        private short deptNo;
        public decimal basicSal;
        public abstract decimal calcNetSalary();

        public string EmpName
        {
            get { return empName; }
            set { if (value == null) { Console.WriteLine("name can't be null"); } else { empName = value; } }
        }
        public int EmpNo { get; }
        public short DeptNo
        {
            get { return deptNo; }
            set { if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("invalid number");
                }
            }
        }
        public abstract decimal BasicSal
        {
            get; set;
        }

        public Employee(string empName, short deptNo, decimal basicSal)
        {
            id++;
            this.EmpNo = id;
            this.EmpName = empName;
            this.DeptNo = deptNo;
            this.BasicSal = basicSal;
        }
    }
        public class Manager : Employee
        {
            string designation;
            public string Designation
            {
                get { return designation; }
                set
                {
                    if (value == null)
                    {
                        Console.WriteLine("designation can't be null");
                    }
                    else
                    {
                        designation = value;
                    }

                }
            }
            public override decimal BasicSal { get; set; }
            public Manager(string empName, short deptNo, decimal basicSal,string designation) : base(empName, deptNo, basicSal)
            {
                this.Designation = designation;
            }
            public override decimal calcNetSalary()
            {
                decimal bonus = 2000;
                decimal netSal = BasicSal + bonus;
                return netSal;
            }

        }
        public class GeneralManager : Manager
        {
            private string perks;
            public string Perks
            {
                get { return perks; }
                set { perks = value; }
            }
            public GeneralManager(string empName, short deptNo, decimal basicSal, string designation,string perks) : base(empName, deptNo, basicSal, designation)
            {
                this.Perks = perks;
            }
            public override decimal calcNetSalary()
            {
                decimal bonus = 2000;
                decimal netSal = BasicSal + bonus;
                return netSal;
            }
        }
        public class CEO : Employee
        {
            public CEO(string empName, short deptNo, decimal basicSal) : base(empName, deptNo, basicSal)
            {

            }
            public override decimal BasicSal { get; set; }
            public override decimal calcNetSalary()
            {
                decimal bonus = 2000;
                decimal netSal = BasicSal + bonus;
                return netSal;
            }
        }
    

}
