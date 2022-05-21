//Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120



Console.WriteLine("Введите любое натуральное число");
int number = int.Parse(Console.ReadLine());
double mul = 1;
for (int i = 1; i <= number; i++)
{
    mul = mul * i;
}
Console.WriteLine($"{number} -> {mul}");