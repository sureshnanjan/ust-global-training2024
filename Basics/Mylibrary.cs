namespace Afshan.training{
public class TrainingDashboard{
	// Properties
	string TrainerName;
	string startdate;
	string enddate;
	string[] participants;
	string[] topics;
	// Methods
	public static void publish(){
		System.Console.WriteLine("Publishing training");
	}
	public static void generateReport(){
		System.Console.WriteLine("Generating report");
	}
}
}

// Make this library and create a main program and call the methods