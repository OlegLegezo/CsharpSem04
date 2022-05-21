// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

Console.WriteLine("введите натуральное число");
int number = int.Parse (Console.ReadLine());
int count = 0;
Console.Write($"кол-во цифр в числе{number} = ");
while (number >0)
{
    number=number/10;
    count++;
}
Console.WriteLine(count);