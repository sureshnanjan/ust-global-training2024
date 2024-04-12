namespace GettingStarted_UST
{
    /// <summary>
    /// Main class
    /// </summary>
    internal class Kitchen
    {

        public event Action<object, EventArgs> FoodIsReady;

        /// <summary>
        /// Method to invoke Event
        /// </summary>
        public void CollectOrder()
        {
            
            FoodIsReady?.Invoke(this, EventArgs.Empty);        
        }

        /// <summary>
        /// Method to handle event
        /// </summary>
        /// <param name="handler"> Object of EventArgs</param>
        public void PlaceOrder(Action<object, EventArgs> handler)
        {
            FoodIsReady += handler;
        }
    }
}
