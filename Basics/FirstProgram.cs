using Sumin.training;
using System;
class training{
	public static void Main()
	{
		Console.WriteLine("Calling");
		TrainingDashboard.publish();
		TrainingDashboard.generateReport();
	}
}

// Make this library and create a main program and call the methods