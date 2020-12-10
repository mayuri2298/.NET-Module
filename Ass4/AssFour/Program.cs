using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arr = new Employee[3];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter empid: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter empname");
                string name = Console.ReadLine();
                Console.WriteLine("enter empsal");
                decimal sal = Convert.ToDecimal(Console.ReadLine());
                arr[i] = new Employee(id, name, sal);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].EmpSal > arr[j + 1].EmpSal)
                    {

                        Employee temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("employee with highest salary");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpSal == arr[arr.Length - 1].EmpSal)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }
            Console.WriteLine("Enter empId : ");
            int empid = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpId == empid)
                {
                    Console.WriteLine("employee is present");
                    Console.WriteLine(arr[i].EmpId+" "+arr[i].EmpName+" "+arr[i].EmpSal);
                }
                //else
                //{
                //    Console.WriteLine("wrong empid");
                //}
            }
            Console.ReadLine();
        }
    }
    public class Employee
    {
        private int empId;
        private string empName;
        private decimal empSal;

        public int EmpId
        {
            get;
            set;
        }
        public string EmpName
        {
            get;
            set;
        }
        public decimal EmpSal
        {
            get;set;
        }

        public Employee(int empId,string empName,decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }
    }
}
