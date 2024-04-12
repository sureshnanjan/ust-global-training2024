
namespace C_Assignments
{
    internal class Kitchen
    {
        public event Action<object, EventArgs>? FoodISReady;
        internal void PrepareTheFood()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Step1");
            Thread.Sleep(3000);
            Console.WriteLine("Step2");
            Thread.Sleep(5000);
            Console.WriteLine("Plate the food");
            FoodISReady?.Invoke(this, EventArgs.Empty);
        }
        public void PlaceOrder(Action<object, EventArgs> handler)
        {
            FoodISReady += handler;
        }
    }
}