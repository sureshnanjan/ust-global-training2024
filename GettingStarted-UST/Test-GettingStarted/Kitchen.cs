namespace Test_GettingStarted
{
    internal class Kitchen
    {
        public event Action<object, EventArgs> FoodISReady;
        
        /// <summary>
        /// Preparing the food and Invoking all the events as Publisher
        /// </summary>
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


        /// <summary>
        /// Adding the Event as arguments 
        /// </summary>
        /// <param name="handler"></param>
        public void PlaceOrder(Action<object, EventArgs> handler)
        {

            FoodISReady += handler;
        }


    }
}