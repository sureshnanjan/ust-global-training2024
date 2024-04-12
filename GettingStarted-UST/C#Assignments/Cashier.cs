namespace C_Assignments
{
    /// <summary>
    /// Represents a cashier in the restaurant.
    /// </summary>
    internal class Cashier
    {
       
        int id;

        public Cashier(int id)
        {
            this.id = id;
        }


        // Wait for a order completion
        // Consumer - Receiver - Subscriber  - Pub-Sub - Chat

        /// <summary>
        /// Collects money from customers.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="args">Optional event arguments.</param>
        public void CollectMoney(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.id} is collecting the Money");
            //Console.WriteLine($"{this.id} is Cleaning the Table");
        }
    }
}