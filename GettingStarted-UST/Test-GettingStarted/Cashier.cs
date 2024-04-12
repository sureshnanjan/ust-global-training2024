namespace Test_GettingStarted
{
    /// <summary>
    /// Capture cashier details and Billing status
    /// </summary>
    internal class Cashier
    {
        /// <summary>
        /// Capture Cashier details
        /// </summary>
        string orderId;
        int id;
        public string notification;

        /// <summary>
        /// COnstructor for Id fetch
        /// </summary>
        /// <param name="id"></param>
        public Cashier(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Shows status of collected monet details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void CollectMoney(object sender, EventArgs? args)
        {
            notification = $"Cashier {this.id} is collecting the Money";
            Console.WriteLine($"Cashier {this.id} is collecting the Money");
            //Console.WriteLine($"{this.id} is Cleaning the Table");
        }
    }
}