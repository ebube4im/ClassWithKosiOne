namespace ClassWithKosiOne
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Pseudocode

            // Conditional statements   - IF/ELSE  - SWITCH

            // Loops

            // Collections



            // if (true/false) {

            //Do Something

            // }
            //else
            //{

            //}



            bool isABoy = true;



            string name = "Kosi";

            // false is not equals to true     = true


            if (isABoy == true)
            {
                Console.WriteLine("It is a boy");
            }
            else
            {
                Console.WriteLine("It is not a boy");
            }
            //        != : is not equals to 

            //    number is not equals to 5 

            // AND and OR
            // A = true
            // B = true;


            // A AND B = TRUE
            // A OR B = TRUE

            int number = 10;

            if (number <= 9)
            {
                Console.WriteLine("You are correct");
            }
            else
            {
                Console.WriteLine("You are wrong");
            }


            if (name != "Kosi")
            {
                Console.WriteLine("You are welcome");
            }
            else
            {
                Console.WriteLine("You are not welcome");
            }




            int result = 5 + 6;

            Console.WriteLine(result);





            //if (A & B & C)
            //{
            //    Console.WriteLine("TRUE");
            //}
            //else
            //{
            //    Console.WriteLine("FALSE");
            //}

            bool A = false;
            bool B = false;
            bool C = false;


            if (A || B || C)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }


            //      false          true
            if (isABoy != true || number < 15)
            {
                Console.WriteLine("It is true");
            }
            else
            {
                Console.WriteLine("it is false");
            }


            // A = fasle
            // B = true
            // number = 25


            if (A != false || number >= 26)
            {
                Console.WriteLine("It is true");
            }
            else
            {
                Console.WriteLine("it is false");
            }
            // TRUE

            if (A & B || number == 25)
            {
                Console.WriteLine("It is true");
            }
            else
            {
                Console.WriteLine("it is false");
            }
            // fASLE

            if ((A || B) & number != 25)
            {
                Console.WriteLine("It is true");
            }
            else
            {
                Console.WriteLine("it is false");
            }


            Console.WriteLine("Enter the grade");
            string grade = Console.ReadLine();


            if (grade == "A" || grade == "a")
            {
                Console.WriteLine("You did Excellently");
            }
            else if (grade == "B" || grade == "b")
            {
                Console.WriteLine("You did pefectly well");
            }
            else if (grade == "C")
            {
                Console.WriteLine("You can do better than this");
            }
            else if (grade == "D")
            {
                Console.WriteLine("You did poorly");
            }
            else
            {
                Console.WriteLine("invalid Grade");
            }




            switch (grade)
            {
                case "A":
                    Console.WriteLine("You did Excellently");
                    break;
                case "B":
                    Console.WriteLine("You did pefectly well");
                    break;
                case "C":
                    Console.WriteLine("You can do better than this");
                    break;
                case "D":
                    Console.WriteLine("You did poorly");
                    break;
                default:
                    Console.WriteLine("invalid Grade");
                    break;
            }











            //Calculator Casio = new Calculator();
            //Casio.FirstNumber = int.Parse(Console.ReadLine());

            //Casio.SecondNumber = int.Parse(Console.ReadLine());

            //int SubtractionResult = Casio.Subtract();
            //Console.WriteLine(SubtractionResult);

            //int DivisionResult = Casio.Divide();
            //Console.WriteLine(DivisionResult);

            //int MultiplyResult = Casio.Multiply();
            //Console.WriteLine(MultiplyResult);

            //string option = Console.ReadLine();

            //if (option == "1")
            //{
            //    int AdditionResult = Casio.Add();
            //    Console.WriteLine("First Answer : " + AdditionResult);
            //}

            //if (option == "2")
            //{
            //    int AdditionResult = Casio.Add();
            //    Console.WriteLine("First Answer : " + AdditionResult);
            //}

            //if (option == "3")
            //{
            //    int AdditionResult = Casio.Add();
            //    Console.WriteLine("First Answer : " + AdditionResult);
            //}

            //if (option == "4")
            //{
            //    int AdditionResult = Casio.Add();
            //    Console.WriteLine("First Answer : " + AdditionResult);
            //}
            //else
            //{
            //    Console.WriteLine("Your Option is invalid!");
            //}





            //Calculator Purpo = new Calculator();






















            //Car FirstCar = new Car();


            //FirstCar.Color = "Yellow";
            //FirstCar.Model = "Toyota";
            //FirstCar.Drive();
            //FirstCar.TurnRight();

            //string Response = FirstCar.GoAndBuySomething(200, 5);

            //Console.WriteLine(Response);





            //Car SecondCar = new Car();



            //SecondCar.Color = "Red";
            //SecondCar.Model = "Benz";


            //SecondCar.TurnLeft();

            //SecondCar.Accelerate(200);

            //Console.WriteLine("First Car: " + FirstCar.Color + " " + FirstCar.Model);
            //Console.WriteLine("Second Car: " + SecondCar.Color + " " + SecondCar.Model);


            //Car ThirdCar = new Car();


            //Console.WriteLine("Hello, World!");


        }
    }
}
