// Задать массив из 8 элементов и вывести их на экран.
Console.Clear();

int[] array = {1, 3, 5, 7, 9, 1, 2, 11};
/* Console.WriteLine(array);
int X = 0;
while (X < array.Length)
{
    Console.Write(" " + array[X]);
    X++;
} */

void print (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(" " + mass[i]);
    } 
}
print (array);