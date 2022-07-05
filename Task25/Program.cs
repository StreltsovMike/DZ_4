int sqr(int A, int B)
{
    int C = A;
    for (int count = 1; count < B; count++)
    {
        C = C * A;
    }
    return C;
}

Console.WriteLine("Введите А:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B:");
int B = Convert.ToInt32(Console.ReadLine());

int R = sqr(A, B);

Console.WriteLine("A в степени B = " + R);
