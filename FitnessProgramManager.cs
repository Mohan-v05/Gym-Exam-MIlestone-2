using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_
{
    internal class FitnessProgramManager
    {
        public List<FitnessProgram> FitnessProgramList = new List<FitnessProgram>();
        public void CreateFitnessProgram()
        {
            Console.WriteLine("Enter Program ID :");
            int FitnessProgramId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Program Title");
            string FitnessProgramName = Console.ReadLine();

            Console.WriteLine("Enter Program Duration");
            string Duration = Console.ReadLine();

            Console.WriteLine("Enter Program Price");
            decimal Price=decimal.Parse(Console.ReadLine());

            var Program = new FitnessProgram(FitnessProgramId, FitnessProgramName, Duration, Price);

            FitnessProgramList.Add(Program);


        }
        public void ReadFitnessPrograms()
        {
            Console.WriteLine(FitnessProgramList);
        }

    }
}
