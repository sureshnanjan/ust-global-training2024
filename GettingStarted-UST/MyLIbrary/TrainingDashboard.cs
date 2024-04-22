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
        string TrainerName = "suresh"; // 566794 - 456789
        string enddate;
        string[] participants;
        string[] topics;
        int marks = 10; // 5667789 - 00001010
        float percent = 10.2f;
        
        // Methods
        
        /// <summary>
        /// Publish report about Training
        /// </summary>
        public void publish() {
            Console.WriteLine("I am publishing the report");
            // marks = "suresh";
            marks = (int)percent; // Explicit type converstion // TypeCasting
            percent = marks;
            
        }
        public void generateReport() {
            Console.WriteLine("Creating my wonderful report ");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public string getTrainerName(string name, int param)
        {

            return this.TrainerName;
        }


    }
}
