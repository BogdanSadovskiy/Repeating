namespace Repeat
{
    internal class Exercise
    {
        private static List<int> list = new List<int>();
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
            list_.ForEach(n => Console.Write(n + " "));
            Console.WriteLine("");
        }


        ////////////////////////////////////////////////////////////////////////
        ///                         Exercise 1
        private static List<int> even = new List<int>();
        private static void desriptionExerciseONe()
        {
            Console.WriteLine("Create an array of integers and use" +
                "\na lambda expression to output even numbers only.\n");
        }
        private static void findEven(List<int> list_)
        {
            even = list_.Where(n => n % 2 == 0).ToList();
        }
        public static void ExerciseOne()
        {
            desriptionExerciseONe();
            addNumbers();
            Console.Clear();
            Console.WriteLine("All numbers:");
            readList(list);
            findEven(list);
            Console.WriteLine("Even numbers");
            readList(even);
        }
        ////////////////////////////////////////////////////////////////////////
        



        ////////////////////////////////////////////////////////////////////////
        /// Exercise 2 
        private static void desriptionExerciseTwo()
        {
            Console.WriteLine("Create an array of decimal numbers and use a lambda expression for\n" +
            "calculating the average value.\n");
        }
        private static int findAverage(List<int> list_)
        {
            int avarege = (int)list_.Average();
            return avarege;
        }
        public static void ExerciseTwo()
        {
            desriptionExerciseTwo();
            addNumbers();
            Console.Clear();
            Console.WriteLine("All numbers:");
            readList(list);
            Console.WriteLine("Average number - " + findAverage(list));
        }
        ////////////////////////////////////////////////////////////////////////

  

        ////////////////////////////////////////////////////////////////////////
        /// Exercise 3 
        private static List<string> strings = new List<string>();
        private static void desriptionExerciseThree()
        {
            Console.WriteLine("Create an array of strings and use a lambda expression to find the "+
            "with the longest length\n");
        }
        private static void readStrings(List<string> allStrings)
        {
            int i = 1;
            allStrings.ForEach(str => Console.WriteLine(i++ + ") " + str));
            Console.WriteLine("");
        }
        private static void addStrings()
        {
            do
            {
                Console.Clear();
                readStrings(strings);
                Console.WriteLine("E - Exit");
                Console.WriteLine("Input string:");
                string str_ = Console.ReadLine();
                if (str_.Equals("E") || str_.Equals("e")) break;
                if (str_ != null)
                {
                    strings.Add(str_);
                    continue;
                }

            } while (true);
        }
        private static string thelongestString(List<string> allStrings)
        {
            string theLongest = allStrings.OrderByDescending(s => s.Length).FirstOrDefault();
            return theLongest;
        }
        public static void ExerciseThree()
        {
            desriptionExerciseThree();
            addStrings();
            Console.Clear();
            Console.WriteLine("All strings:");
            readStrings(strings);
            Console.WriteLine("The longest string:\n" + thelongestString(strings));
        }
        ////////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////////
        /// Exercise 4

        private static void desriptionExerciseFour()
        {
            Console.WriteLine("Create a Person class with name and age properties.\n" +
                "Create an array of objects of this class\n" +
                "and use a lambda function to output those\n" +
                "individuals who are under 30 years old.\n");
        }
        private static void allPersons(List<Person> persons)
        {
            int i = 1;
            persons.ForEach(person => Console.WriteLine($"\t{i++}) Name: {person.getName()}, Age: {person.getAge()}"));
            Console.WriteLine("");
        }
        private static List<Person>  personsYoungestThenThirty(List<Person> persons)
        {
            List<Person> youngest = persons.Where(persons => persons.getAge() < 30).ToList();
            return youngest;
        }
        public static void ExerciseFour(List<Person> persons)
        {
            desriptionExerciseFour();
            Console.Clear();
            Console.WriteLine("All persons:");
            allPersons(persons);
            Console.WriteLine("Persons youngest then 30:\n");
            allPersons(personsYoungestThenThirty(persons));
        }

    }
}
