namespace Anu.training
{
public class TrainingDashboard
{
	// Properties
	string TrainerName;
	string startdate;
	string enddate;
	string[] participants;
	string[] topics;
	// Methods
	public static void publish()
	{
	System.Console.WriteLine("Publishing Training");
	}
	public static void generateReport()
	{
	System.Console.WriteLine("Generate Report Training");	
	}
}
}

// Make this library and create a main program and call the methods