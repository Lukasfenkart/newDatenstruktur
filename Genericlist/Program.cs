// See https://aka.ms/new-console-template for more information


using Genericlist;

namespace GenerischeKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemStore = new ItemStore<int, double, string>();
            itemStore.Value1 = 5;
            itemStore.Value2 = 4.5;
            itemStore.Value3 = "2";

            var summe = 6 + itemStore.Value1;

            Console.WriteLine(summe);
            Console.WriteLine(itemStore.Value2);




            CustomStack<int> myStack = new CustomStack<int>();
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);
            myStack.push(4);

            Console.Write(myStack);

        }
    }

    class ItemStore<TValueType1, TValueType2, TValueType3>
    {
        public TValueType1 Value1 { get; set; }
        public TValueType2 Value2 { get; set; }
        public TValueType3 Value3 { get; set; }
    }
}