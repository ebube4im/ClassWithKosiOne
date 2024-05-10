namespace ClassWithKosiOne
{
    internal class Car
    {

        // Fields of a class
        int x;
        // int, string, double, decimal, bool, float, 
        decimal y;

        double z = 23.56;

        int num1 = 22;

        string name = "Kosi";


        // Properties  of a class

        // Structure - 

        // - Access Modifier
        public string Color { get; set; }

        public string Model { get; set; }


        // Methods

        public string GoAndBuySomething(int Amout, int Quantity)
        {
            int Result = Amout * Quantity;

            return "I have bought the items, And here is the total Amount I spent " + Result;
        }

        public void Drive()
        {
            Console.WriteLine("Driving....");
            Console.WriteLine("Driving....");
            Console.WriteLine("Driving....");
            Console.WriteLine("Driving....");
            Console.WriteLine("Driving....");
        }

        public string Accelerate(int value)
        {
            Console.WriteLine("Accelerating....");
            return "Accelerated by " + value;
        }


        public void TurnRight()
        {
            Console.WriteLine("Turning Right....");
            Console.WriteLine("Turning Right....");
            Console.WriteLine("Turning Right....");
            Console.WriteLine("Turning Right....");
            Console.WriteLine("Turning Right....");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Turning Left....");
            Console.WriteLine("Turning Left....");
            Console.WriteLine("Turning Left....");
            Console.WriteLine("Turning Left....");
            Console.WriteLine("Turning Left....");
        }


    }
}
