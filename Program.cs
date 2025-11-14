namespace Calculator
{
    class Program
    {

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }


        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }


        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }


        public static double Divide(double num1, double num2)
        {

            return num1 / num2;
        }


        public static double GetNumberInput(string prompt)
        {
            double number;
            Console.Write(prompt);

            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Некорректный ввод. Пожалуйста, введите число: ");
            }
            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("    Простейший Калькулятор");



            double number1 = GetNumberInput("Введите первое число: ");

            double number2 = GetNumberInput("Введите второе число: ");


            Console.Write("Выберите операцию (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result = 0;
            bool isValidCalculation = true;

            switch (operation)
            {
                case "+":
                    result = Add(number1, number2);
                    break;
                case "-":
                    result = Subtract(number1, number2);
                    break;
                case "*":
                    result = Multiply(number1, number2);
                    break;
                case "/":

                    if (number2 == 0)
                    {
                        Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                        isValidCalculation = false;
                    }
                    else
                    {
                        result = Divide(number1, number2);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка: Некорректная операция. Пожалуйста, используйте +, -, *, или /.");
                    isValidCalculation = false;
                    break;
            }


            if (isValidCalculation)
            {
                Console.WriteLine($"Результат: {number1} {operation} {number2} = {result}");
            }
        }
    }
}