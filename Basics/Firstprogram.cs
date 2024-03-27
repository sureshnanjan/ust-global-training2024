using Afshan.training;
using System;
class testing{
	public static void Main(){
		Console.WriteLine("Starting");
		TrainingDashboard.publish();
		TrainingDashboard.generateReport();
	}
}