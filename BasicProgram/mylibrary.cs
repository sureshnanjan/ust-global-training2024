namespace Anu.training{

public class TrainingDashboard{

	//Properties
	string TrainerName;
	string startdate;
	string enddate;
	string[] participants;
	string[] topics;
	
	//Methods
	public static void publish(){
		System.Console.WriteLine("This is my publish function");
	}
	
	public static void generateReport(){
		System.Console.WriteLine("Generating Report ...");
	}

}

}