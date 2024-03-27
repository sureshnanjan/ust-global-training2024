using Syama.training;
using System;
class MyClass
{
static void Main(){
Console.WriteLine("This is starting ..");
TrainingDashboard.publish();
TrainingDashboard.generateReport();
}
}