using System;
namespace renjitha.training{

public class TrainingDashboard
{
	string TrainerName;
	string startdate;
	string enddate;
	string[] participants;
	string[] topics;
	// Methods
	public static void publish()
	{
		Console.WriteLine(" Inside Publish method");
		}
	public static void generateReport()
	{
		Console.WriteLine(" Inside generateReport method");
	}
	static void Main()
	{
		TrainingDashboard.publish();
		TrainingDashboard.generateReport();
	}
}
}