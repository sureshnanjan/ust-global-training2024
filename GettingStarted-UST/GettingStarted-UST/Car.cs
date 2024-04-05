namespace GettingStarted_UST
{
    class Car : IStartable {
        string make;
        private int wheels;
        internal int cc;
        string color;
        public string wheel_pub;

        public Car(string make, int wheels, int cc, string col)
        {
            //this.make = make;
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
