using MyLIbrary;
using PetStore;

namespace C_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First Assignment
            GenerateReport();

            //Second Assignment
            UsingLiterals();

            //Third Assignment
            BinarySearch();

            //Fourth Assignment
            PetStore();

            //Fifth Assignment
            CustomSortArray();

            //Sixth Assignment
            EventsDemo();
            //Seventh Assignment

            //Eighth Assignment
            OperatorsAndIndexers();
            //Ninth Assignment
        }

        private static void EventsDemo()
        {
            Kitchen kfc = new Kitchen(); // Publisher
            Waiter waiter1 = new Waiter(1); // Consumers
            Waiter waiter2 = new Waiter(2);
            Waiter waiter3 = new Waiter(3);
            Cashier cashier = new Cashier(1);
            Manager manager = new Manager(1);
            TableCleaner tableCleaner = new TableCleaner(1);
            kfc.PlaceOrder(waiter1.ServeFood);
            kfc.PlaceOrder(waiter2.ServeFood);
            kfc.PlaceOrder(waiter3.ServeFood);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PlaceOrder(manager.ManageRestaurant);
            kfc.PlaceOrder(tableCleaner.CleanTabe);
            kfc.PrepareTheFood();
        }

        private static void OperatorsAndIndexers()
        {
            SimpleClass classOne = new(10);
            SimpleClass classTwo = new(100);

            var resultOne = classOne + classTwo;
            Console.WriteLine(resultOne);

            SimpleCollection simpleCollection=new ();
            Console.WriteLine(simpleCollection[1].ValueOne);
            Console.WriteLine(simpleCollection[2].ValueOne);
        }

        private static void PetStore()
        {
            Pet pet = new Pet();
            Category category = new Category();
        }

        private static void CustomSortArray()
        {
            CustomSortArray[] customSortArrays = { new(0, 1), new(2, 3), new(1, 2) };
            Array.Sort(customSortArrays);
            foreach (var customSortArray in customSortArrays)
            {
                Console.Write(customSortArray.ToString() + ",");
            }
        }

        private static void BinarySearch()
        {
            BinarySearch binarySearch = new([2, 3, 4], 3);
            binarySearch.DoSearch();
        }

        private static void UsingLiterals()
        {
            UsingLiterals usingLiterals = new();
            usingLiterals.ShowUsage();
        }

        private static void GenerateReport()
        {
            TrainingDashboard.generateReport();
            TrainingDashboard.publish();
        }
    }
}
