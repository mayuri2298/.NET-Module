using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssSeven
{
    class Program
    {
        static void Main1()
        {
            Func<decimal,decimal,decimal,decimal> o = (a,b,c) => a*b*c / 100;
            Console.WriteLine("simple interest: "+o(1700,2,12));
            Console.ReadLine();
        }
        static decimal SimpleInterest(decimal p,decimal n,decimal r)
        {
            return (p * n * r) / 100;
        }
    }
}

namespace SecondQue
{
    class Program
    {
        static void Main2()
        {
            Func<int, int, bool> f = (x, y) => x > y;
            Console.WriteLine(f(20,10));
            Console.ReadLine();
        }
        static bool isGreater(int a,int b)
        {
            return a > b;
        }
    }
}

namespace ThirdQue
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter employee salary");
            int sal = Convert.ToInt32(Console.ReadLine());
            Employee e = new Employee(sal);
            Func<Employee, int> o = x => x.BasicSal;
            Console.WriteLine(o(e));
            Console.ReadLine();
        }
        static int getBasic(Employee e)
        {
            return e.BasicSal;
        }
    }
    public class Employee
    {
        private int basicSal;
        public int BasicSal
        {
            get;
            set;
        }
        public Employee(int basicSal)
        {
            this.BasicSal = basicSal;
        }

    }
}

namespace FourthQue
{
    class Program
    {
        static void Main4()
        {
            Func<int, bool> f = n => n % 2==0;
            Console.WriteLine(f(17));
            
            Console.ReadLine();
        }
        static bool isEven(int num)
        {
            return num % 2 == 0;
        }
    }
}

namespace FifthQue
{
    class Program
    {
        static void Main5()
        {
            Employee e = new Employee(17000);
            Func<Employee, bool> f = x => x.BasicSal > 10000;
            Console.WriteLine(f(e));
            Console.ReadLine();
        }
        static bool isSalGreater(Employee e)
        {
            return e.BasicSal > 10000;
        }
    }
    public class Employee
    {
        private int basicSal;
        public int BasicSal
        {
            get; 
            set;
        }
        public Employee(int basicSal)
        {
            this.BasicSal = basicSal;
        }
    }
}
