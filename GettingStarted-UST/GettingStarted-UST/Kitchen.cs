namespace GettingStarted_UST
{
    internal class Kitchen
    {

        public event Action<object, EventArgs> FoodIsReady;

        public void CollectOrder()
        {
            
            FoodIsReady?.Invoke(this, EventArgs.Empty);        
        }

        public void PlaceOrder(Action<object, EventArgs> handler)
        {
            FoodIsReady += handler;
        }
    }
}
