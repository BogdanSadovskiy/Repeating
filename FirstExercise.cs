namespace Repeat
{
    internal class FirstExercise
    {
        private static List<int> list = new List<int>();
        private static List<int> even = new List<int>();
        private static void desription()
        {
            Console.WriteLine("Create an array of integers and use" +
                "\na lambda expression to output even numbers only.\n");
        }
        private static void addNumbers()
        {
            bool b;
            do
            {
                Console.Clear();
                readList(list);
                Console.WriteLine("E - Exit");
                Console.WriteLine("Input number:");
                string number = Console.ReadLine();
                if (number.Equals("E") || number.Equals("e")) break;
                if (RegexStr.isOnlyNumbers(number))
                {
                    list.Add(Int32.Parse(number));
                    continue;
                }

            } while (true);
        }
        private static void readList(List<int> list_)
        {
            foreach (int n in list_)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("");
        }
        private static void findEven(List<int> list_)
        {
            even = list_.Where(n => n % 2 == 0).ToList();
        }
        public static void firstEx()
        {
            desription();
            addNumbers();
            Console.WriteLine("All numbers:");
            readList(list);
            findEven(list);
            Console.WriteLine("Even numbers");
            readList(even);


        }

    }
}
