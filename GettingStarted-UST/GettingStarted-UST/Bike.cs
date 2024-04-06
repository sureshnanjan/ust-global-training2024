namespace GettingStarted_UST
{
    class Bike : IStartable {
        // fields
        string make;
        int wheels;
        int cc;
        public Bike(string make, int wheels, int cc)
        {
            this.cc = cc;
            this.make = make;
            this.wheels = wheels;
        }

        public void start() {
            Console.WriteLine("Starring my bike by kicking");
        }
    }
}
