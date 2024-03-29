namespace GettingStarted_UST
{
    class Car : IStartable {
        string make;
        int wheels;
        int cc;
        string color;

        public Car(string make, int wheels, int cc, string col)
        {
            this.make = make;
            this.wheels = wheels;
            this.cc = cc;
            this.color = col;
            
        }

        public void start()
        {
            Console.WriteLine("Starting car using Key");
        }


    }
}
