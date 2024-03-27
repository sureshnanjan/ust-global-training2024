using Harish_Assign.training;
using System;
class MyClass{
	static void Main(){
		Console.WriteLine("Starting....");
		TrainingDashboard.publish();
		TrainingDashboard.generateReport();
	}
}