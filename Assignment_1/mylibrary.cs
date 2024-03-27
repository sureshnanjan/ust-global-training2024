	using System;
namespace Harish_Assign.training
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
	public static void publish(){
	Console.WriteLine("Display Trainig details...");
	}
	public static void generateReport()
	{
	Console.WriteLine("Reports generated ...");
	}
}
}