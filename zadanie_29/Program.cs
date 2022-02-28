// Написать программу вычисления произведения чисел от 1 до N
Console.Clear();

Console.Write("Ввести число: ");
int A = int.Parse(Console.ReadLine());
/* int B = 1;
for (int i = 1; i <= A; i++)
{
    B = B * i;
}
Console.WriteLine("Произведение чисел:" + B); */

int f = Factorial(A);
int Factorial(int A)
{
    int B = 1;
    for (int i = 1; i <= A; i++)
    {
        B = B * i;
    }
    return B;
}
Console.WriteLine("Факториал числа" + f);