namespace PASS_Wk4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // say our hellos

            Console.WriteLine("RB waz here!!! ");
            Console.WriteLine("Jackson is alive and well :)");
            Console.WriteLine("Nam checking in");
            Console.WriteLine("Yago here!! ");



            // code some arrays and lists

            string[] characteres = { "Luffy", "Zoro" };

            Console.WriteLine(characteres[0]); //should output "Luffy"
            Console.WriteLine(characteres[1]); //should output "Zoro"


            int[][] a = new int[6][];
            int i = 6;
            a[0] = new int[i];
            a[1] = new int[i];
            a[2] = new int[i];
            a[3] = new int[i];
            a[4] = new int[i];
            a[5] = new int[i];



            // loop through array

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

            List<string> ShoppingList = new List<string>();
            ShoppingList.Add("eggplant");
            ShoppingList.Add("butter");
            ShoppingList.Add("bread");

            foreach (string s in ShoppingList)
            { Console.WriteLine(s); }


            // look at functions


            int tempN = addNumber( 3, 4);

            Console.WriteLine(tempN) ;



        }



        static int addNumber(int x, int y)
        { 
            return x + y;
        }



    }
}
