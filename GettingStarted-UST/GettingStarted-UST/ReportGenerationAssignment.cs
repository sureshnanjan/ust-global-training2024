using MishraNeetu.training;

namespace GettingStarted_UST
{
    internal class ReportGenerationAssignment
    {
        class Myclass
        {
            static void Main()
            {
                Console.WriteLine("Report generation");
                TrainingDashboard.publish();
                TrainingDashboard.generatereport();


            }
        }
    }
}

