namespace minnu.Training {
 class TrainingDashboard 
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
        System.Console.Writeline("This is publish function ");
    }

    public static void generateReport()
    {
        System.Console.Writeline("Generating Report");
    }
}}

