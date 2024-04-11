


//Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.


class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите выражение (или 'Q' для выхода): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "Q")
            {
                break;
            }

            try
            {
                char[] delimiters = { '+', '-', '*', '/' };
                string[] elements = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                if (elements.Length != 2)
                {
                    Console.WriteLine("Некорректное выражение");
                    continue;
                }

                double a = Convert.ToDouble(elements[0]);
                double b = Convert.ToDouble(elements[1]);
                char operation = input.FirstOrDefault(c => c == '+' || c == '-' || c == '*' || c == '/');
                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = a + b;
                        break;
                    case '-':
                        result = a - b;
                        break;
                    case '*':
                        result = a * b;
                        break;
                    case '/':
                        if (b != 0)
                            result = a / b;
                        else
                            Console.WriteLine("Деление на ноль!!!");
                        break;
                    default:
                        Console.WriteLine("Некорректная операция");
                        break;
                }

                Console.WriteLine("Результат: " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }
}