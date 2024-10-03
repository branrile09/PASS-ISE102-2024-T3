namespace PASS_Wk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hi, RB Waz here!!!");
            Console.WriteLine("Gabby reporting in.");
            Console.WriteLine("Jackson Here,Hi!");
            Console.WriteLine("Keer is here");
            
            // -- Variables --

            float Apple = 3.0f;
            string fillerName = "aghsdj";            
            double digits = 23;
            bool cowboyMode = false;
            int loneValue = 1;
            char i = 'j';
            List<string> shoppingList = new(); 
            dynamic myVar = 5;


            //Variable manipulation

            Apple++;
            Apple -= 3;
            Apple += 2;
            Apple *= 2;
            Apple = Apple / 2;

            //Decision Control
            //if else aswell
            if (cowboyMode = true)
            { Console.WriteLine("yeehaw"); }
            else { Console.WriteLine("sad yeehaw"); }

            //switch 
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // While and do 

            string password = "abc";
        ConsoleKeyInfo key;

        // Loop until Enter key is pressed        
        do
        {
            key = Console.ReadKey(intercept: true); // intercept true prevents displaying the key
            if (key.Key != ConsoleKey.Enter)
            {
                // Append the pressed key character to the password string
                password += key.KeyChar;

                // Display a '*' to mask the character
                Console.Write("*");
            }
        } while (key.Key != ConsoleKey.Enter);

            bool newBool = true;
            while (key.Key != ConsoleKey.Enter)
            { }


        // Move to the next line after the user presses Enter
        Console.WriteLine();

            //does password containt 'x'
            bool containX = false;
            foreach (char c in password)
            {
                if (c == 'x') Console.WriteLine();
                { 
                //special condition
                containX = true;
                }
            }

            for (int j = 1; j < 5; j++)
            {
                //great for arrays and vectors                
            }
        }
    }
}
