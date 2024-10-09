using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_
{
    internal class FitnessProgram
    {
        public int fitnessProgramId {  get; set; }

        public string Title {  get; set; }
        
        public string Duration {  get; set; }
 
        public decimal Price { get; set; }

        public FitnessProgram(int fitnessProgramId, string title, string duration, decimal price)
        {
            this.fitnessProgramId = fitnessProgramId;
            this.Title = title;
            this.Duration = duration;
            this.Price = price;
        }
        public override string ToString() {
            return $"ID: {fitnessProgramId}, Title: {Title}, Duration: {Duration}, Price: {Price}\r\n";
                }
    }
}
