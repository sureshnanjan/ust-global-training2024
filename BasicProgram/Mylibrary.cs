
using System;
namespace renjitha.training{

public class TrainingDashboard
{
	//Properties
	string TrainerName;
	string startdate;
	string enddate;
	string[] participants;
	string[] topics;
	// Methods
	public static void publish()
	{
		Console.WriteLine(" Publishing report for Training.......");
	}
	public static void generateReport()
	{
		Console.WriteLine(" Generating Report....... ");
	}
}
}
