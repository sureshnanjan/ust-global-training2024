{
    /// <summary>
    /// Main class
    /// </summary>
    public class Kitchen
    {
        public event Action<object, EventArgs> FoodISReady;

        //Preparing the food and Invoking all the events as Publisher
        public void PrepareTheFood()
        {
        }

        public void PlaceOrder(Action<object, EventArgs> handler)
        {
        }


    }
}
