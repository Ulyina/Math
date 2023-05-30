//Носонова Ульяна Вариант 19
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите значение a");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Абсолютное значение: " + Math.Abs(a));
    Console.WriteLine("Введите значение b");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Максимальное значение" + Math.Max(a, b)); 
    double x = Convert.ToDouble(Math.Round(Math.Sqrt(a), 2));
    Console.WriteLine("Извлекаемый корень равен " + x);
    //19. Проверить соотношение  lg(a) = ln(a)/ln(10)
     Console.WriteLine("Введите значение c");
     int c = Convert.ToInt32(Console.ReadLine());
     double y = Math.Round(Math.Log10(a), 2);
     double z = Math.Round(Math.Log(a) / Math.Log(10), 2);
     Console.WriteLine("Решение lg(a) = ln(a)/ln(10) " + y + " = " + z);
    // Проверка соотношения
    if ( y == z)
    {
        Console.WriteLine("Соотношение верно");
    }
    else
    {
        Console.WriteLine("Соотношение неверно");
    }
  }
}