namespace PASS_Wk7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Vehicle vehicle = new Vehicle();
            Console.WriteLine(vehicle.name);

            Car vehicle1 = new Car("Ford","Gt500","Elanor");
            Console.WriteLine(vehicle1.name);

            vehicle1.Move();

            Helicopter helicopter1 = new Helicopter();
            Helicopter Apache = new Helicopter("Boeing","AH-64 Apache","Apache");

            Apache.Enter();            
            Apache.Move();

            
            List<Vehicle> list = new List<Vehicle>();


        }




    }








}
