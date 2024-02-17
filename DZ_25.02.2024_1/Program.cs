// Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без остатка)
// нужно вывести слово Fizz. Если число кратно 5 нужно вывести слово Buzz.
// Если число кратно 3 и 5 нужно вывести Fizz Buzz.
// Если число не кратно не 3 и 5 нужно вывести само число.
// Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.
class Program
{
    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Введите число от 1 до 100 (для выхода введите 'exit'):");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                exit = true;
            }
            else
            {
                if (int.TryParse(input, out int number))
                {
                    if (number >= 1 && number <= 100)
                    {
                        if (number % 3 == 0 && number % 5 == 0)
                        {
                            Console.WriteLine("Fizz Buzz");
                        }
                        else if (number % 3 == 0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else if (number % 5 == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(number);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 100");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введено некорректное значение");
                }
            }
        }
    }
}