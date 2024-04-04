using System;
namespace chandni.training{
public class TrainingDashboard{
	// Properties
	string TrainerName;
	string startdate;
	string enddate;
	string[] participants;
	string[] topics;
	// Methods
	
	public static void publish(){
		Console.WriteLine("Training will cover csharp fundamentals");
		
	}
	public static void generateReport(){
		Console.WriteLine("Total 30 paticipants are in the training");
		
	}
	static void Main(){
		
		TrainingDashboard.publish();
		TrainingDashboard.generateReport();
	}
}
}