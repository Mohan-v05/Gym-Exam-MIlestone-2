using System.Security.Cryptography.X509Certificates;

namespace FitnessProgramManagementSystem_
{
    internal class Program
    {

        static void Main(string[] args)
        {
          

        

            FitnessProgram fitnessProgram = new FitnessProgram(1, "weightLifting", "3months", 1000);
            FitnessProgramManager fitnessProgramManager= new FitnessProgramManager();
            Console.WriteLine(fitnessProgram.ToString());




            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n----- Fitness Program Management Menu -----");
                Console.Write("1. Add a FitnessProgram\r\n2. View All FitnessPrograms\r\n3. Update a FitnessProgram\r\n4. Delete a FitnessProgram\r\n5. Exit\r\nChoose an option:");
                  

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        fitnessProgramManager.CreateFitnessProgram();

                        break;
                    case "2":
                        Console.Clear();
                        fitnessProgramManager.ReadFitnessPrograms();
                        break;
                    case "3":
                        Console.Clear();
                        fitnessProgramManager.UpdateFitnessProgram();
                        break;
                    case "4":
                        Console.Clear();
                        fitnessProgramManager.DeleteFitnessProgram();
                        break;
                    case "5":

                        exit = true;
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }
            }
        }
    }
}
    