//Носонова Ульяна 25ИС-21 19 Вариант
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите латинский символ: ");
        string input = Console.ReadLine();

        char symbol = char.Parse(input);

        if (symbol >= 'a' && symbol <= 'z')
        {
            char leftKey = (char)(symbol - 1);
            Console.WriteLine("За клавишей" + symbol + "находится символ" + leftKey);
        }
        else
        {
            Console.WriteLine("Вы ввели некорректный символ");
        }

        Console.ReadKey();
    }
}