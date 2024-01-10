namespace Assignment2Advanced
{
    //Step 0 (Delegate Declaration)
    public delegate int StringFuncDelegate(string str);
    // New Class , New Delegate => ny reference from this delegate Can refer to function or more
    internal class Program
    {
        #region delegte example 3
        //public static List<int> GetOddNumbers(List<int> Numbers)
        //{
        //    List<int> result = new List<int>();
        //    if (Numbers is not null)

        //        for(int i = 0; i<Numbers.Count;i++)

        //            if (Numbers[i]%2==1)

        //                result.Add(Numbers[i]);



        //    return result;
        //}

        //public static List<int> GetEvenNumbers(List<int> Numbers)
        //{
        //    List<int> result = new List<int>();
        //    if (Numbers is not null)

        //        for (int i = 0; i < Numbers.Count; i++)

        //            if (Numbers[i] % 2 == 0)

        //                result.Add(Numbers[i]);



        //    return result;
        //}

        public delegate bool FunctionDelegatebool(int x);
        public static List<int> GetElementBasedOnPassedFormat(List<int> elements, FunctionDelegatebool delegatebool)
        {
            List<int> result = new List<int>();
            if (elements is not null && delegatebool is not null)

                for (int i = 0; i < elements.Count; i++)

                    //if (elements[i] % 2 == 0)
                    if (delegatebool.Invoke(elements[i]))

                        result.Add(elements[i]);



            return result;

        }
        #endregion
        static void Main(string[] args)
        {
            #region User Defined Delegate
            ////step 1 Declare Reference from delegate
            //StringFuncDelegate funcDelegate;
            ////Step 2 Initialize a referrence (Pointer to function)
            ////funcDelegate = new StringFuncDelegate(StringFunctions.GetUpperChars);
            //funcDelegate = StringFunctions.GetUpperChars; //Syntax sugar
            ////Step 3 Use Delegate reference
            //int result = funcDelegate("MazenELLITHY");
            //Console.WriteLine(result);

            //funcDelegate+= StringFunctions.GetLowerChars;
            //funcDelegate-= StringFunctions.GetUpperChars;


            #endregion
            #region Delegate exmple 2
            //int[] Numbers = { 1, 2, 30, 5, 0, 9, 150, 13, 147 };
            //SortingAlgorithms<int>.BubbleSort(Numbers, CompareFunctions.CompareGrt); // Asc
            //foreach (int number in Numbers)
            //    Console.WriteLine(number);

            //string[] Names = { "Mai", "Mahmoud", "Mona", "Mazen" };
            //CompareFuncDelegate<string> compareFuncDelegate2 = CompareFunctions.SortAscending;

            //SortingAlgorithms<string>.BubbleSort(Names, CompareFunctions.SortAscending);

            //foreach (string name in Names)
            //    Console.WriteLine(name);

            #endregion

            #region Delegate ex 3

            //List<int> Numbers = Enumerable.Range(1, 100).ToList();
            //List<int> OddNumbers = GetElementBasedOnPassedFormat(Numbers, ConditionFunctions.CheckOdd);
            //foreach (int odd in OddNumbers)
            //    Console.WriteLine($"odd numbers = {odd}  ");

            //List<int> EvenNumbers = GetElementBasedOnPassedFormat(Numbers, ConditionFunctions.CheckEven);
            //foreach (int even in EvenNumbers)
            //    Console.WriteLine($"even numbers = {even}");




            #endregion

            #region Built-in  Delegates

            //Predicate<int> predicate = ConditionFunctions.test;
            //predicate(10);


            //Func<int, string> func = ConditionFunctions.Cast;
            //func(55);


            //Action action = ConditionFunctions.Print;
            //action();

            #endregion

            #region Anonymous Function and Lambda

            // Anonymous Function
            //Predicate<int> predicate = delegate (int x) { return x > 0; };
            //predicate.Invoke(10);


            //Func<int, string> func = delegate(int x) { return x.ToString(); };
            //func(55);


            //Action action = delegate () { Console.WriteLine("Hello"); };
            //action();



            //Lambda Expression Read as Goes To
            //Predicate<int> predicate =  x => x > 0; 
            //predicate.Invoke(10);


            //Func<int, string> func = x => x.ToString(); 
            //func(55);


            //Action action= () => Console.WriteLine("Hello"); 
            //action();



            #endregion

            #region New Update in C# 10

            //var predicate = (int x)  => x > 0;
            //predicate.Invoke(10);


            //var func  =(int x) => x.ToString();
            //func(55);


            //var action = () => Console.WriteLine("Hello");
            //action();

            #endregion

            #region List Methods
            //    List <int> Numbers = Enumerable.Range(0,100).ToList();

            //    //List<int> OddNumbers = GetElementBasedOnPassedFormat(Numbers, delegate (int a) { return a % 2 == 1; });

            //    //List<int> OddNumbers = GetElementBasedOnPassedFormat(Numbers, (a) => a % 2 == 1);
            //    List<int> OddNumbers = Numbers.FindAll((a) => a % 2 == 1);


            //    Numbers.ForEach((a) => { a += 10; });

            //}


            #endregion

        class ConditionFunctions
        {   
            public static bool CheckOdd(int a)
            {
                return a % 2 == 1;
            }

            public static bool CheckEven(int a)
            {
                return a % 2 == 0;
            }
        }


        #region User Defined Delegate
        class StringFunctions
        {
            public static int GetUpperChars(string Name)
            {
                int Count = 0;
                if (Name is not null)
                {
                    for (int i = 0; i<Name.Length; i++)
                    {
                        if (char.IsUpper(Name[i]))
                        {
                            Count++;
                        }
                    }
                }

                return Count;
            }
            public static int GetLowerChars(string Name)
            {
                int Count = 0;
                if (Name is not null)
                {
                    for (int i = 0; i < Name.Length; i++)
                    {
                        if (char.IsLower(Name[i]))
                        {
                            Count++;
                        }
                    }
                }

                return Count;
            }
        }
        #endregion
    }

}