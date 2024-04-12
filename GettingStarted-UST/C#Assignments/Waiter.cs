namespace C_Assignments
{
    /// <summary>
    /// Represents a waiter in the restaurant.
    /// </summary>
    internal class Waiter
    {
        string name;
        string orderId;
        int id;

        public Waiter(int id)
        {
            this.id = id;
            this.name = "Pizza";
            this.orderId = "001";
        }


        // Wait for a order completion
        // Consumer - Receiver - Subscriber  - Pub-Sub - Chat

        /// <summary>
        /// Serves food to customers.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="args">Optional event arguments.</param>
        public void ServeFood(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.id} is Serving the Food");
        }

    }
}