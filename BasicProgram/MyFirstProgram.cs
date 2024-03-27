using System;
using renjitha.training;
public class Myclass
{
	public static void Main()
		{
		Console.WriteLine("Starting ....");
		TrainingDashboard.publish();
		TrainingDashboard.generateReport();
		}
		
}