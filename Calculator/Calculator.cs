namespace APCalculatorHistory 
{
    public partial class Calculator
    {
        string calculatorHistory = "";
        public int Add(int num1, int num2)
        {
            SaveHistory(num1, num2, "+");
            return num1 + num2;
        }

        private void SaveHistory(int num1, int num2, string operation)
        {
            if (calculatorHistory == "")
            {
                calculatorHistory = calculatorHistory + $"{num1},{operation},{num2}";
            }
            else
            {
                calculatorHistory = calculatorHistory + ",=," + $"{num1},{operation},{num2}";
            }
        }

        public int Subtract(int num1, int num2)
        {
            SaveHistory(num1, num2, "-");
            return num1 - num2;
        }
        public int Mul(int num1, int num2)
        {
            SaveHistory(num1, num2, "*");
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            SaveHistory(num1, num2, "/");
            return num1 / num2;
        }

        public string GetHistory()
        {
            return calculatorHistory;
        }
    }
}