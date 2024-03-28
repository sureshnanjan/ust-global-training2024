using Anu.training;
using System;
class Program
{
	public static void Main()
	{
		Console.WriteLine("starting");
		TrainingDashboard.publish();
		TrainingDashboard.generateReport();
		
	}
}
