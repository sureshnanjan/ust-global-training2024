namespace Anu.training{
	/// <summary>
	/// Class for Training Dashboard
	/// </summary>
	public class TrainingDashboard{

		//Properties
		string TrainerName;
		string startdate;
		string enddate;
		string[] participants;
		string[] topics;
	
		/// <summary>
		/// Method to publish
		/// </summary>
		public static void publish(){
			System.Console.WriteLine("This is my publish function");
		}
	
		/// <summary>
		/// Method to generate report
		/// </summary>
		public static void generateReport(){
			System.Console.WriteLine("Generating Report ...");
		}

	}

}