namespace ClassWithKosiOne
{
    internal class Calculator
    {

        int answer = 0;

        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }


        public int Add()
        {
            answer = FirstNumber + SecondNumber;

            return answer;

        }

        public int Subtract()
        {
            answer = FirstNumber - SecondNumber;

            return answer;
        }

        public int Divide()
        {
            answer = FirstNumber / SecondNumber;

            return answer;

        }

        public int Multiply()
        {
            answer = FirstNumber * SecondNumber;

            return answer;
        }



    }
}
