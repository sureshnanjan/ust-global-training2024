using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace MyLIbrary
{
    /// <summary>
    /// This class perform all Training Dashboard
    /// </summary>
    public class TrainingDashboard
    {

        // Primitive Types - int , bool , float ,
        // Reference Types

        // Properties
        string trainerName = "suresh"; // 566794 - 456789
        string endDate;
        string[] participants;
        string[] topics;
        int Marks = 10; // 5667789 - 00001010
        float Percent = 10.2f;
        
        // Methods
        
        /// <summary>
        /// Publish report about Training
        /// </summary>
        public void Publish() {
            Console.WriteLine("I am publishing the report");
            // marks = "suresh";
            Marks = (int)Percent; // Explicit type converstion // TypeCasting
            Percent = Marks;
            
        }
        public void GenerateReport() {
            Console.WriteLine("Creating my wonderful report ");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public string GetTrainerName(string name, int param)
        {

            return this.trainerName;
        }


    }
}
