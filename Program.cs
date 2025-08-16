using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_27
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of students:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nStudent {i + 1} name:");
                string name = Console.ReadLine();

                int[] days = new int[30];
                Console.WriteLine("Enter 30 attendance values (1=present,0=absent) separated by spaces:");
                string[] input = Console.ReadLine().Split(' ');

                if (input.Length != 30)
                {
                    Console.WriteLine("Error: Must enter exactly 30 values.");
                    i--;
                    continue;
                }
                int absentCount = 0;
                int streak = 0;
                int maxStreak = 0;
                for (int j = 0; j < 30; j++)
                {
                    if (input[j] == "1" || input[j].ToUpper() == "Y")
                    {
                        days[j] = 1;
                        streak++;
                        if (streak > maxStreak) maxStreak = streak;
                    }
                    else
                    {
                        days[j] = 0;
                        absentCount++;
                        streak = 0;
                    }
                }
                double absenceRate = (absentCount / 30.0) * 100;
                string status = (absenceRate > 20 || maxStreak < 5) ? "DEFICIENT" : "OK";

                Console.WriteLine($"{name}: Absence Rate = {absenceRate:F1}%, Longest Streak = {maxStreak}, Status = {status}");
            }
        }
    }
}

            