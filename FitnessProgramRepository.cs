using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_
{
    internal class FitnessProgramRepository
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=FitnessProgramManagement2;";

        //1 insert new Finess program
        public void  InsertNewFitnessprogram(FitnessProgram fitnessProgram)
        {
            string query = "INSERT INTO FitnessPrograms (Title, Duration, Price) VALUES (@Title,@Duration,@Price);";

            try
            {
                using (SqlConnection Connection = new SqlConnection(connectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@Title", fitnessProgram.Title);
                        Console.WriteLine("Title Added");
                        Command.Parameters.AddWithValue("@Duration", fitnessProgram.Duration);
                        Command.Parameters.AddWithValue("@Price", fitnessProgram.Price);
                        Command.ExecuteNonQuery();
                    } ;
                }
                Console.WriteLine("Fitness program inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while inserting" + ex.Message);
            }
            
        }
              
                
    }
}
        
 