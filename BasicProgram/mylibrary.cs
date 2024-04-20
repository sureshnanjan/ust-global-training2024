namespace Chandni.training{
public class TrainingDashboard{
	// Properties
	string TrainerName;
	string startdate;
	string enddate;
	string[] participants;
	string[] topics;
	// Methods
	public static void publish()
	{
		System.Console.WriteLine("Publishing the details of training");
	}
	public static void generateReport()
	{
		System.Console.WriteLine("Generating report of training");
	}
}
}

// Make this library and create a main program and call the methods