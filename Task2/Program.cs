//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Большое число");
    Console.WriteLine(number1);
    Console.WriteLine("Меньшее число");
    Console.WriteLine(number2);
}
if (number1 < number2)
{
    Console.WriteLine("Большое число");
    Console.WriteLine(number2);
    Console.WriteLine("Меньшее число");
    Console.WriteLine(number1); 
}
if (number1 == number2)
{
    Console.WriteLine("Числа одинаковые");
    Console.WriteLine(number1);
}
