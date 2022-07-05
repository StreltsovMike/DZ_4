// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNumbers(int number)
{
    int sum = 0;
    for (int LastDigit = 0; number > 0; number = number / 10)
    {
        LastDigit = number % 10;
        sum = sum + LastDigit;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int Sum = SumNumbers(A);
Console.WriteLine(Sum);