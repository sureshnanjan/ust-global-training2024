namespace Test_GettingStarted
{
        /// <summary>
        /// /Capturing the waiter details and Publishing the Order status
        /// </summary>
    internal class Waiter
    {
        /// <summary>
        /// Capture Waiter and Order details
        /// </summary>
        string name;
        string orderId;
        int id;
        public string notification;
        /// <summary>
        /// Create Waiter object thru constructor
        /// </summary>
        /// <param name="id"></param>
        public Waiter(int id)
        {
            this.id = id;
            this.name = "Pizza";
            this.orderId = "001";
        }
        
        /// <summary>
        /// Captures the status of Food Serve
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ServeFood(object sender, EventArgs? args)
        {
            Console.WriteLine($"Waiter {this.id} is Serving the Food");
            notification = $"Waiter {this.id} is Serving the Food";
            //Console.WriteLine($"Waiter {this.id} is Cleaning the Table");
        }

    }
}