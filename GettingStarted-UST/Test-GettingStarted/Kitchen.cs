namespace Test_GettingStarted
{
    internal class Kitchen
    {
        public event Action<object, EventArgs> FoodISReady;
        
        //Preparing the food and Invoking all the events as Publisher
        public void PrepareTheFood()
        {
            Thread.Sleep(2000);
            Console.WriteLine("All Waiters Arrived");
            Thread.Sleep(3000);
            Console.WriteLine("Cooking Completed");
            Thread.Sleep(5000);
            Console.WriteLine("Plate the food");
            FoodISReady?.Invoke(this, EventArgs.Empty);
        }


        //Adding the Event as arguments 
        public void PlaceOrder(Action<object, EventArgs> handler)
        {

            FoodISReady += handler;
        }


    }
}