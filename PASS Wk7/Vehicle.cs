using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_Wk7
{
    internal class Vehicle
    {
        //should almost never use public variables!!!! BAD RILEY BAD!!!
        public string make;
        public string model;
        public string name;

        protected float Speed; //private accessibility, but can be inherited

        //sail boats dont use fuel, but most vehicles do, Protected would be best!!
        private float fuelAmmount; // can only be accessed within the class



        //default constructor
        public Vehicle()
        {   //not an actual null, its a string of "null"
            make = "null";
            model = "null";
            name = "null";
        }

        public void Move()
        {
            //we moved.....     
            Console.WriteLine("vehicle is no longer where it was");
        }

        //overload
        /// <summary>
        /// overload with preinitialized values
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        public Vehicle(string make, string model, string name)
        {   //not an actual null, its a string of "null"

            if (EdgeCaseCheck())
            {
                this.make = make;
                this.model = model;
                this.name = name;
            }
            else { Console.WriteLine("Bad values"); }

            
        }
        //inheritable function
        protected bool EdgeCaseCheck()
        {
            //console write exact issue/s

            return true;        
        }



    }
    
    internal class Car : Vehicle 
    {
        
        public Car(string make, string model, string name)
        {   //not an actual null, its a string of "null"
            this.make = make;
            this.model = model;
            this.name = name;
        }
        public Car()         
        { }   
    }

    internal class Helicopter : Vehicle 
    {
        public Helicopter(string make, string model, string name)
        {   //not an actual null, its a string of "null"
            this.make = make;
            this.model = model;
            this.name = name;
        }
        public Helicopter()
        { }

        //this is how we enter choppa!!
        public void Enter()
        {
            Console.WriteLine("GET TO THE CHOPPER!!!!");        
        }

        //overload directs to correct function
        public void Move()
        { Fly(); }
        private void Fly()
        {
            Console.WriteLine("we fly, not move");
            Console.WriteLine("this is a chopper not a plane, no 911 jokes!");        
        }


    }

    internal class Boat : Vehicle
    {
        protected float fuelAmmount;
        //going to generalize most boats

    }

    internal class Yacht : Boat
    {
        float FuelAmmount = 0;
    }

    class  Motorbike : Vehicle 
    {
        float fuelAmmount = 0;

        public Motorbike() { }
        
    }

    class  pushBike : Vehicle
    {
        bool hasPedals = true;
        public pushBike() { }
        
    }
    //we wanted to try multiple inheritance, 
    /// <summary>
    /// https://dotnettutorials.net/lesson/multiple-inheritance-csharp/
    /// https://stackoverflow.com/questions/178333/multiple-inheritance-in-c-sharp
    /// </summary>
    class motorisedPushBike : pushBike      
    {
        private Motorbike motorbike = new();
    }




}
