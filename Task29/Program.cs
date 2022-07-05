// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] array = new int[8];
for (int N = 1; N < 9; N++)
{
    Console.WriteLine($"Введите {N} число");
    int number = Convert.ToInt32(Console.ReadLine());
    array[N - 1] = number;
}
var str = string.Join(" ", array);

Console.WriteLine($"Ваш массив готов : [{str}]");

