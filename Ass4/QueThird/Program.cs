using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdQue
{
    class Program
    {
        static void Main()
        {
            student s = new student("mayuri", 1, 100);
            student s1 = new student("harry", 2, 90);
            student s2 = new student("harmoini", 3, 80);
            student s3 = new student("ron", 4, 70);
            student s4 = new student("draco", 5, 60);

            student[] arr = { s, s1, s2, s3, s4 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].RollNo + " " + arr[i].Name + " " + arr[i].Marks);
            }
            Console.ReadLine();
        }
    }
    public struct student
    {
        private string name;
        private int rollNo;
        private decimal marks;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("invalid name");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value > 0)
                {
                    rollNo = value;
                }
                else
                {
                    Console.WriteLine("invalid roll no");
                }
            }
        }
        public decimal Marks
        {
            get;
            set;
        }
    }
}