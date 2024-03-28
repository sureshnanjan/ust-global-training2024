namespace MyLib
{
    public class Report
    {
        //Properties
        string TrainerName;
        string startdate;
        string enddate;
        string[] participants;
        string[] topics;

        // Methods
        public void publish()
        {
            System.Console.WriteLine("Publishing Report");
        }
        public void generateReport()
        {
            System.Console.WriteLine("Generating Report");
        }
    }
}
