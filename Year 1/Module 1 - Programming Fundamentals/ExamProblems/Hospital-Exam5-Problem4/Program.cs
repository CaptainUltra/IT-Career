using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Exam5_Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var docs = 7;
            var treated = 0;
            var notTreated = 0;
            for(int i = 0 ; i <= n - 1 ; i++)
            {
                var patients = int.Parse(Console.ReadLine());
                if ((i % 3 == 0) && (notTreated > treated))
                {
                    docs++;
                }
                if (patients > docs)
                {
                    treated += docs;
                    notTreated += patients - docs;
                }
                else
                {
                    treated += patients;
                }
                Console.WriteLine();
                Console.WriteLine(treated);
                Console.WriteLine(notTreated);
                Console.WriteLine();
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", notTreated);
        }
    }
}
//----------------------------------------------------
//tqhno
//----------------------------------------------------
/*using System;

class Hospital
{
    static void Main()
    {
        var period = int.Parse(Console.ReadLine());

        int treatedPatients = 0;
        int untreatedPatients = 0;
        int countOfDoctors = 7;

        for (int day = 1; day <= period; day++)
        {
            var currentPatients = int.Parse(Console.ReadLine());

            if ((day % 3 == 0) && (untreatedPatients > treatedPatients))
            {
                countOfDoctors++;
            }

            if (currentPatients > countOfDoctors)
            {
                treatedPatients += countOfDoctors;
                untreatedPatients += currentPatients - countOfDoctors;
            }
            else
            {
                treatedPatients += currentPatients;
            }
            Console.WriteLine();
            Console.WriteLine(treatedPatients);
            Console.WriteLine(untreatedPatients);
            Console.WriteLine();
        }

        Console.WriteLine("Treated patients: {0}.", treatedPatients);
        Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
    }
}*/

