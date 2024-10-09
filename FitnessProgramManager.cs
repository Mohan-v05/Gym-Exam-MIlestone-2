using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FitnessProgramManagementSystem_
{
    internal class FitnessProgramManager
    {
        public List<FitnessProgram> FitnessProgramList = new List<FitnessProgram>();
        FitnessProgramRepository FitnessProgramRepository=new FitnessProgramRepository();

      
        public void CreateFitnessProgram()
        {
            Console.Write("Enter Program ID :");
            int FitnessProgramId = int.Parse(Console.ReadLine());

            Console.Write("Enter Program Title:");
            string FitnessProgramName = Console.ReadLine();

            Console.Write("Enter Program Duration:");
            string Duration = Console.ReadLine();

            
          decimal Price =  ValidateFitnessProgramPrice();


            var Program = new FitnessProgram(FitnessProgramId, FitnessProgramName, Duration, Price);

            FitnessProgramList.Add(Program);
            FitnessProgramRepository.InsertNewFitnessprogram(Program);


            Console.Write("-----Fitness Program added successfully------");

        }
        public void ReadFitnessPrograms()
        {
            if (FitnessProgramList.Count == 0)
            {
                Console.Write("---------No Fitness Programs available-----");
                return;
            }
            else
            {
                foreach (var program in FitnessProgramList)
                {
                    Console.Write(program);
                    Console.ReadLine();
                }
            }


        }
        public void UpdateFitnessProgram()
        {
            Console.Write("Enter id:");
            var id = int.Parse(Console.ReadLine());
            var program = FitnessProgramList.Find(p => p.fitnessProgramId == id);
            if (program == null)
            {
                Console.Write("---------No Program Available--------");

            }
            else
            {
                Console.Write("Enter new Title:");
                program.Title = Console.ReadLine();

                Console.Write("Enter new Price:");
                program.Price = decimal.Parse(Console.ReadLine());

                Console.Write("Enter new Duration:");
                program.Duration = Console.ReadLine();

                Console.Write("----------Fitness Program updated successfully-------");

            }


        }
        public void DeleteFitnessProgram()
        {
            Console.Write("Enter program id:");
            var id = int.Parse(Console.ReadLine());
            var program = FitnessProgramList.Find(p => p.fitnessProgramId == id);
            if (program != null)
            {
                Console.Write("not such program exist:");
            }
            else
            {
                FitnessProgramList.Remove(program);
                Console.Write("--------Program removed succesfully-------");


            }
        }
        public decimal ValidateFitnessProgramPrice()
        { decimal init = 0;
            while (true)
            {
                Console.Write("Enter Program Price:");
                decimal Price = decimal.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Red;
                if (Price > 0)
                {
                   init = Price;
                    break;
                }
                Console.WriteLine("enter a valid amount price cant be zero");
            }
            Console.ForegroundColor = ConsoleColor.White;
            return init;
           
        }


    }

}
