// Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите три числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine("Максимальное число");
        Console.WriteLine(number1);
    }
    else
    {
        Console.WriteLine("Максимальное число");
        Console.WriteLine(number3);
    }
}
if (number1 < number2)
{
    if (number2 > number3)
    {
        Console.WriteLine("Максимальное число");
        Console.WriteLine(number2);
    }
    else
    {
        Console.WriteLine("Максимальное число");
        Console.WriteLine(number3);
    }
}
if (number1 == number2)
{
    if (number1 == number3)
    {
        Console.WriteLine("Все числа равны");
        Console.WriteLine(number1);
    }
    else
    {
        Console.WriteLine("Максимальное число");
        Console.WriteLine(number3);
    }
}