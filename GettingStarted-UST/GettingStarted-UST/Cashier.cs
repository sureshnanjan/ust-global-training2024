namespace Test_GettingStarted
{
    /// <summary>
    /// Capture cashier details and Billing status
    /// </summary>
    public class Cashier
    {
        //Capture Cashier details
        string name;
        string orderId;
        int id;
        public string notification;

        //COnstructor for Id fetch
        public Cashier(int id)
        {
            this.id = id;
        }

        //Shows status of collected monet details
        public void CollectMoney(object sender, EventArgs? args)
        {
            notification = $"Cashier {this.id} is collecting the Money";
            Console.WriteLine($"Cashier {this.id} is collecting the Money");
            //Console.WriteLine($"{this.id} is Cleaning the Table");
        }
    }
}