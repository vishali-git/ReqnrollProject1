
namespace ReqnrollProject1.StepDefinitions
{
    internal class Calculator
    {
        public int FirstNumber { get; internal set; }
        public int SecondNumber { get; internal set; }

        public int Addition()
        {
            return FirstNumber + SecondNumber;
        }
    }
}