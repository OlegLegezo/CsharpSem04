// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/*
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
// int[] array = {1,0,1,1,0};
array[0] = 1;
array[1] = 2;
*/

int num = int.Parse(Console.ReadLine());
int[] array = new int[num];
int i = 0;
while (i <= num)
{
    array[i] = new Random().Next(100, 1000);
    //int num = new Random().Next(100, 1000);
    Console.WriteLine(array[i]);
    i++;
    
}
/*
int count = 0;
while (count < num)
{
    Console.Write(array[count]);
    count++;
}
*/