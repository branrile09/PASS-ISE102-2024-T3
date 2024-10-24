//includees

namespace PASS_Wk6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //variables (objects)

            // loops

            // functions

            // if, else if, switch (logic)

            int i = 0;
            DOB obj = new(11,9,2001);
            Employee employee = new Employee();
            Employee employee2 = new Employee(1,"robert","rob", obj);

            Console.WriteLine(employee2.firstName);
            Console.WriteLine(employee2.lastName);
            Console.WriteLine(employee2.IDTag);
            Console.WriteLine(employee2.DOB.GetDOB());

            employee2.IDTag = 3;
            employee2.firstName = "butthead";


            Console.WriteLine(MathLibrary.addNumber(42,69,3));
            Console.WriteLine(MathLibrary.addNumber(1,2));
            Console.WriteLine(MathLibrary.addNumber(1));
            Console.WriteLine(MathLibrary.addNumber(19231,4234,142,96));

            employee2.Address = "new";
            employee2.Address = "new3";
            Console.WriteLine(employee2.Address);

        }
    }

    internal struct DOB
    {
        private int Day;
        private int Month;
        private int Year;

        public DOB(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string GetDOB()
        {
            return $"{Day}/{Month}/{Year}";        
        }
        public void SetDOB(int day, int month, int year)
        {
            if (goodDate(day, month, year))
            {
                Day = day;
                Month = month;
                Year = year;
            }            
        }
        
        //safe data handling
        bool goodDate(int day, int month, int year)
        { 
            //check day < 31
            //early return if day <= 3
            
            // check if month < 13

            //check year is less than current year


            //otherwise return true
                        
            return true;         
        }
    }


    internal class Employee
    {
        //publically accessible values
        public int IDTag;
        public string firstName;
        public string lastName;
        public DOB DOB;

        private string address;
        public string Address { get { return address; } set { if (isGood(value)) { address = value; } else { Console.WriteLine("BAD!"); }  }  }
        public int phoneNumber { get; set; }

        //constructor
        public Employee()
        { 
        
        
        }

        //overloaded constructor 
        public Employee(int IDTag, string firstName, string lastName, DOB DOB)
        {
            this.IDTag = IDTag;
            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = DOB;
        }


        public bool isGood(string s)
        {
            if (s.Length < 4)
            {
                return false;
            }


            return true;
        }

    }







}
