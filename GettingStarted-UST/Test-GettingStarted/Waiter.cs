namespace Test_GettingStarted
{
        /// <summary>
        /// /Capturing the waiter details and Publishing the Order status
        /// </summary>
    internal class Waiter
    {
        //Capture Waiter and Order details
        string name;
        string orderId;
        int id;

        public Waiter(int id)
        {
            this.id = id;
            this.name = "Pizza";
            this.orderId = "001";
        }
        
        // Captures the status of Food Serve
        public void ServeFood(object sender, EventArgs? args)
        {
            Console.WriteLine($"Waiter {this.id} is Serving the Food");
            Console.WriteLine($"Waiter {this.id} is Cleaning the Table");
        }

    }
}