namespace Minnu.Training {
 public class TrainingDashboard
{
    //properties
    string TrainerName;
    string StartDate;
    string EndDate;
    string[] Participants;
    string[] Topics;

    //Methods
    public static void publish()
    {
        System.Console.WriteLine("This is publish function ");
    }

    public static void generateReport()
    {
        System.Console.WriteLine("Generating Report");
    }
}}

