using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GettingStarted_UST
{
    public class MainProgram
    {
        static IWebDriver driver = new ChromeDriver();
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.add(10000, 20000);
            int result1 = calculator.subtract(2, 1);

            Console.WriteLine($"When I add 1,2 the resut is {result} when i subtract 2, 1 the result is {result1}");


        }

        public static void petStoreImplementation(String URL) {
         
            driver.Navigate().GoToUrl(URL);
            driver.Quit();
        }
    }
}
