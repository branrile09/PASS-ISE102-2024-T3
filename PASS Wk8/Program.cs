namespace PASS_Wk8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //created some objects, Animal is base class, others are subclass
            Canine newDogo = new Canine();
            Poodle newPoo = new Poodle();
            GreatDane newdane = new GreatDane();
            Fish Goldy = new Fish();


            //created a list of animals
            List<Animal> animals = new List<Animal>();
            //added animals to list
            animals.Add(newDogo);
            animals.Add(newPoo);
            animals.Add(Goldy);
            animals.Add(newdane);
            

            //list of subclass type canine
            List<Canine> canines = new List<Canine>();
            //added other canines (subclass is different)
            canines.Add(newDogo);
            canines.Add(newPoo);
            //canines.Add(Goldy); different Base class, cant be added


            canines[0].id = 4;
            
            //canines[1].name = 1;
            
            //checked object from list, checked it class type
            if (canines[1].GetType() == typeof(Poodle))
            {
                //cast back to a poodle from canine
                Poodle temp = (Poodle)canines[1];
                //accessing functitonality of this object
                Console.WriteLine(temp.name);
            }


            if (animals[2].GetType() == typeof(Fish))
            {
                //if only calling 1 function or changing 1 thing.
                ((Fish)animals[2]).swim(); 
            }

            if (canines[0].GetType() == typeof(Cockerspaniel))
            {
                //cast back to a poodle from canine
                Cockerspaniel temp = (Cockerspaniel)canines[1];
                //accessing functitonality of this object
                Console.WriteLine(temp.id);
            }
            else
            {
                Console.WriteLine("this is not a cockerspaniel!!!");           
            
            }


            //iterating through lists
            int counter = 0;
            //how many doggos??
            foreach (Animal a in animals)
            {
                if (a.GetType() == typeof(Canine) || a.GetType() == typeof(Poodle))
                {
                    counter++;
                    Console.WriteLine($"{counter} dog/s");
                }                  
            }

            //another way
            counter = 0;
            for (int i = 0; i < animals.Count; i++) 
            {
                if (animals[i].GetType() == typeof(Canine) || animals[i].GetType() == typeof(Poodle) || animals[i].GetType() == typeof(GreatDane))
                {
                    counter++;
                    Console.WriteLine($"{counter} dog/s");
                    ((Canine) animals[i]).poop();
                }
            }


        }


    }



    internal class Animal
    { 



        //variables
        //public
        public int id;
        

        //protected
        protected int y;
        
        //private
        private int x;

        //functions

        public Animal()
        { 
        
        }

        //functions dealing with 
        //handles protected and private variables

        public void sety(int y)
        { //error handling
            if (y != this.y && y > 12) 
            { this.y = y; }        
        }



    }
    internal class Canine : Animal 
    {
        //default function
        virtual public void poop()
        {
            Console.WriteLine("doggo does poop");        
        }

    }
    internal class Poodle : Canine
    {

        public string name = "poopoo the poodle";
    }

    internal class Cockerspaniel : Canine
    { 
    
    }
    internal class GreatDane : Canine
    {
        //override is like overload but its not the same thing
        //if we want to use this function instead of default when calling said item. 
        public override void poop()
        {
            Console.WriteLine("doggo does big poop");
        }

    }
    internal class Fish : Animal
    {
        public void swim()
        {
            Console.WriteLine("Just keep swimming, just keep swimming");
        
        
        }


    }


}
