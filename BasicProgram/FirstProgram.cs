using Hrishikesh.training;
using System;

/// <summary>
/// Class for main execution
/// </summary>
class MyClass{
	/// <summary>
	/// Method for publishing & generating report
	/// </summary>
	/// ///test
	static void Main(){
		Console.WriteLine("Starting....");
		TrainingDashboard.publish();
		TrainingDashboard.generateReport();
	}
}
