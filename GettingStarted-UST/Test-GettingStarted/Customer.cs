﻿namespace Test_GettingStarted
{

    /// <summary>
    /// Class tot store all the Customer details 
    /// </summary>
    internal class Customer
    {
        //Variable hold the name of the customer
        private string name;

        //Constructor to instantiate 
        public Customer(string name)
        {
            this.name = name;
        }

        //Adding the Order food status to Event Argument 
        public void OrderFood(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.name} is ordering the Food");
        }

        //Adding the Bill Payment details to event Arguments
        public void BillPayment(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.name} is Paying the Bill");
        }


    }
}