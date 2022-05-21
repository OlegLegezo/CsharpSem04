
// найдите сумму чисел введенного числа




Console.Write($"введите натуральное число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum = sum + i; //- короткая запись sum+=i
}
Console.Writeline($"сумма чисел от 1 до {number} = {sum}");