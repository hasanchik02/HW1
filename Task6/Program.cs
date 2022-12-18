// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int remains = number %2;

if (remains > 0)
{
    Console.WriteLine($"Число {number} не является четным числом");
}
else
{
    Console.WriteLine($"Число {number} является четным числом");
}