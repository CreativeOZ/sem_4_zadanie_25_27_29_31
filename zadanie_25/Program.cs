// Найти сумму чисел от 1 до А.

Console.Clear();

Console.Write("Число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Сумма чисел от 1 до А: ");
int B = 0;
for (int i = 1; i <= A; i++)
{
    B = B + i;
}
Console.WriteLine(B);

//Console.Write("Число А: ");
//int A = int.Parse(Console.ReadLine());
//Console.Write("Сумма чисел от 1 до А: ");
//int B = 1;
//int resalt = 0;
//while (B <= A);
//{
 //   resalt = resalt + B;
 // B++;
//}
//Console.WriteLine(B);