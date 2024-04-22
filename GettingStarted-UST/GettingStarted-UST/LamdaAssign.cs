namespace GettingStarted_UST
{
    public class LamdaAssign
    {
        List<int> numbers = new List<int>();

        public LamdaAssign(List <int> number)
        {
            this.numbers = number;
        }

        public LamdaAssign()
        {
            //this.AddNumbers();
        }
        /// <summary>
        /// Showing the list of numbers
        /// </summary>
        public void ShowList()
        {
            Console.Write("The list of numbers : ");

            foreach (int number in numbers)
            {

                Console.Write("  " +number);
            }
        }
        /// <summary>
        /// Adding two numbers in a list
        /// </summary>
        public void AddNumbers()
        {

            int[] Mynumbers = { 1, 2, 3, 4, 5, 6 };
            int result = Mynumbers.Aggregate((arg1, arg2) => arg1 + arg2);
            Console.Write($"\n Aggregate of numbers: {result}");
        }
        /// <summary>
        /// Substracting two numbers in a list
        /// </summary>
        public void SubNumbers()
        {

            int[] Mynumbers = { 1, 2, 3, 4, 5, 6 };
            int result = Mynumbers.Aggregate((arg1, arg2) => arg1 - arg2);
            Console.Write($"\n substraction of numbers: {result}");
        }
        /// <summary>
        /// Multiplying 2 numbers in number
        /// </summary>
        public void MultipliesNumbers()
        {

            int[] Mynumbers = { 1, 2, 3, 4, 5, 6 };
            int result = Mynumbers.Aggregate((arg1, arg2) => arg1 * arg2);
            Console.Write($"\n Multiplying of numbers: {result}");
        }
        public void SquareofNumbers()
        {
            var square = numbers.Select(x => x * x);
            Console.Write("\n Squares : ");
            foreach(var number in square)
            {
                Console.Write("  " + number);
            }
        }
    }
}
