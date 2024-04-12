namespace Test_GettingStarted
{

    /// <summary>
    /// Class tot store all the Customer details 
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Variable hold the name of the customer
        /// </summary>
        private string name;
        public string notification = null,notification2 = null;

        /// <summary>
        /// Constructor to instantiate 
        /// </summary>
        /// <param name="name"></param>
        public Customer(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Adding the Order food status to Event Argument 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OrderFood(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.name} is ordering the Food");
            notification= $"{this.name} is ordering the Food";
        }

        /// <summary>
        /// Adding the Bill Payment details to event Arguments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void BillPayment(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.name} is Paying the Bill");
            notification2 = $"{this.name} is Paying the Bill";
        }


    }
}