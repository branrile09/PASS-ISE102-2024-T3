namespace PASS_Wk5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            // ----------------(args)
            number = addNumber(42,69);
            number = addNumber(number, number, number);
            float n = (float)number;
            n = addNumber(n,number);
            int num = (4);
            
            Console.WriteLine(number);
            double sideA = 3;
            double sideB = 4;
            double hypotenuse = CalculateHypotenuse(sideA, sideB);
            Console.WriteLine($"The hypotenuse of the tringle with sides {sideA} and {sideB} is:{hypotenuse}");


            bool even = Even((int)hypotenuse);

            if (even)
            {
                Console.WriteLine("even");
            }
            else
                Console.WriteLine("Odd");



            string[] newStringArray = { "bob", "bert" , "burt", "burp"};

            string newString = CreateString(newStringArray);

            Console.WriteLine(newString);

        }

        // ------- accesssibility, return, name of function, (parameters)

        /// <summary>
        /// adds two numbers cause we lazy as hell
        /// </summary>
        /// <param name="i"> add info here </param>
        /// <param name="j"> add more info</param>
        /// <returns></returns>
        static int addNumber(int i, int j)
        {
            int k = i + j;
            return i + j;        
        }

        //function overloading

        static int addNumber(int i, int j, int k)
        {
            return i + j + k;        
        }

        static float addNumber(float i, float j)
        {
            float k = i + j;
            return i + j;
        }
        static float addNumber(float i, int j)
        {
            float k = addNumber(i,(float)j);
            return k;
        }


        //lets make some functions here
        // 1. string concatination taking multiple strings and numbers (return string)
        // 2. return bool value for if number is even
        // 3. solve for hypotenuse of a triangle with float points of A and B - kS

        static string CreateString(string[] subStrings)
        {
            string newString = "";
            for (int i = 0; i <= subStrings.Length - 1; i++)
            {
                newString += string.Format($"{i}/{subStrings[i]}\n");
            }
            return newString;
        }

            static double CalculateHypotenuse(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b,2));
        }
        
       

        static bool Even (int num)
        {
            return num % 2 == 0;
        }
        
        
        
        static void loops()
        {
            // --- loops
            int i = 0;

            //test a condition everytime, even before starting
            while (i < 10) { i++; }


            // similar to while loop, but we want to run the code atleast once
            do
            {
                i++;
            }
            while (i < 20);


            // run a certain amount of times
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }


            // useful for iterating through lists and datastructures
            //e.g maps, dictionarys , etc
            List<int> list = new List<int>();
            foreach (int l in list)
            {
                Console.WriteLine(l);
            }

            //nested loop, 

            int[][] a = new int[6][];
            i = 6;
            a[0] = new int[i];
            a[1] = new int[i];
            a[2] = new int[i];
            a[3] = new int[i];
            a[4] = new int[i];
            a[5] = new int[i];

            // loop through 2d array
            // useful for multidimensional data
            int random = new Random().Next();

            for (int row = 0; row < a.Length; row++)
            {
                for (int col = 0; col < a[row].Length; col++)
                {
                    random = new Random().Next();
                    a[row][col] = random;
                    Console.Write($"{a[row][col]},");
                }
                Console.WriteLine();
            }

        }


    }
}
