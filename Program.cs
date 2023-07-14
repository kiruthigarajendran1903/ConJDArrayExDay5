using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConAppJDArrayExcersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NoOfEmp;
            Console.WriteLine("Enter number of employees");
            NoOfEmp = int.Parse(Console.ReadLine());
            int WorkingDays;
            Console.WriteLine("Enter No of working days");
            WorkingDays = int.Parse(Console.ReadLine());
            int[][] employee = new int[NoOfEmp][];
            for (int i = 0; i < NoOfEmp; i++)
            {
                employee[i] = new int[WorkingDays];
                Console.WriteLine($"Enter salary forn each employee {i + 1}\'s");
                for (int j = 0; j < WorkingDays; j++)
                {
                    Console.WriteLine($"Salary for Each day{j + 1}\'s");
                    employee[i][j] = int.Parse(Console.ReadLine());
                }
            }
                Console.WriteLine("\nDisplay Employees Details");
                for (int i = 0; i < NoOfEmp; i++)
                {
                    int totalSalary = 0;
                    Console.Write($"\nEmployee{i + 1}:\t");
                    for (int j = 0; j < WorkingDays; j++)
                    {
                        Console.Write($"{employee[i][j]}");
                        totalSalary += employee[i][j];
                    }
                    Console.WriteLine($"\nTotal Salary: {totalSalary}\t");
                Console.WriteLine("\n");
                Console.ReadKey();
            }
            
        
    }
    }
}
