// Определить количество цифр в числе.
Console.Clear();

Console.Write("Ввести число: ");
string A = Console.ReadLine();
int num = int.Parse(A);
//Console.WriteLine(A.Length) = можно на этом остановиться, но математичкое решиние иное.
int count = 0;
while (num != 0)
{
    num = num / 10;
    count++;
}
Console.WriteLine("Колличество цифр в числе: " + count);