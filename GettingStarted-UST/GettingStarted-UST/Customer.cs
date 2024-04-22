namespace Test_GettingStarted
{

    /// <summary>
    /// Class tot store all the Customer details 
    /// </summary>
    public class Customer
    {
        //Variable hold the name of the customer
        private string name;
        public string notification, notification2;

        //Constructor to instantiate 
        public Customer(string name)
        {
            this.name = name;
        }

        //Adding the Order food status to Event Argument 
        public void OrderFood(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.name} is ordering the Food");
            notification = $"{this.name} is ordering the Food";
        }

        //Adding the Bill Payment details to event Arguments
        public void BillPayment(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.name} is Paying the Bill");
            notification2 = $"{this.name} is Paying the Bill";
        }


    }
}
