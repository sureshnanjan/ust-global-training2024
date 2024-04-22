namespace GettingStarted_UST
{
    internal class GenericSimpleClass<T1,T2>
    {
        // Generic   

        //int id; //20022  UST-20001
        //int counter;
        //string name;
        T1 id;
        T1 counter;
        T2 name;

        public T1 MyId { get; set; }
        public T1 MyCounter { get; set; }

        public T2 MyName { get; set; }
    }
}
