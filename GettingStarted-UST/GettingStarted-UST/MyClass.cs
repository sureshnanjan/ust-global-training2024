namespace GettingStarted_UST
{

    public class MyClass
    {
        static void showDemo()
        {
            List<IStartable> allvehicles = new List<IStartable>();
            allvehicles.Add(new Bike("Enfield", 2, 150));
            allvehicles.Add(new Bike("Skooty", 2, 100));
            allvehicles.Add(new Bike("Enfield2", 2, 200));
            allvehicles.Add(new Car("ford", 2, 200, "blue"));
            allvehicles.Add(new Car("ford1", 2, 200, "red"));
            allvehicles.Add(new Car("ford2", 2, 200, "green"));

            foreach (IStartable obj in allvehicles)
            {
                obj.start();
            }

        }
    }
}
