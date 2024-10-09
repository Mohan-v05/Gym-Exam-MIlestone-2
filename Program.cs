using System.Security.Cryptography.X509Certificates;

namespace FitnessProgramManagementSystem_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Data Source=MyDatabase.db";

            FitnessProgram fitnessProgram = new FitnessProgram(1, "weightLifting", "3months", 1000);
            FitnessProgramManager fitnessProgramManager= new FitnessProgramManager();
            Console.WriteLine(fitnessProgram.ToString());
           

            Console.WriteLine("1. Add a FitnessProgram\r\n2. View All FitnessPrograms\r\n3. Update a FitnessProgram\r\n4. Delete a FitnessProgram\r\n5. Exit\r\nChoose an option:");

                var input = Console.ReadLine();
            while (input!="5")
            {
                if (input == "1")
                {
                    fitnessProgramManager.CreateFitnessProgram();
                }
                else if (input == "2")
                {
                    fitnessProgramManager.ReadFitnessPrograms();
                }
                else
                {
                    Console.WriteLine("Not Available Function");
                }
                 input = Console.ReadLine();
            }
        }
    }
}
