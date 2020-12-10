using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondQue
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the no of batches for batch");
            int batch = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[batch][];
            for(int i = 0; i < batch; i++)
            {
                Console.WriteLine("enter the number of students");
                int num = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[num];
                for(int j = 0; j < num; j++)
                {
                    Console.WriteLine("enter marks for student");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }
            Console.ReadLine();
        }
    }
}
