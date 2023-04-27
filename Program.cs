Console.Clear();

Console.WriteLine("\n\nЗадача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. \n" );

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[a];

void mas(int a)
{
for (int i = 0; i < a; i++)
    {
        Array[i] = new Random().Next(99,999);
        Console.Write(Array[i] + " ");
    }
}
int n (int[] Array)
{
int n = 0;
for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        n = n + 1;
    }
return n;
}
mas(a);
Console.Write($"\nКоличество чётных чисел в массиве: {n(Array)}");


Console.WriteLine("\n\n\nЗадача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. \n" );
Console.Write("Введите количество элементов массива: ");
int b = Convert.ToInt32(Console.ReadLine());
Array = new int[b];
void mass(int b)
{
for (int j = 0; j < b; j++)
    {
        Array[j] = new Random().Next(1,100);
        Console.Write(Array[j] + " ");
    }
}
int kol (int[] Array)
{
int sum = 0;
int j = 0;
while (j < Array.Length)
    {
        sum = sum + Array[j];
        j = j + 2;
    }
return sum;
}

mass(b);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {kol(Array)}");



Console.WriteLine("\n\n\nЗадача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. \n" );
Console.Write("Введите количество элементов массива: ");
a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void masV(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
    {
        randomArray[i] = rand.NextDouble();
        Console.Write($"{randomArray[i]:f2} ");
    }
}

double r(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
    {
        if (max<randomArray[i])
            max = randomArray[i];
        if (min>randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
Console.Write($"\nМинимальный элемент массива: {min:F2}");
Console.Write($"\nМаксимальный элемент массива: {max:F2}");
return max-min;
}

masV(a);

Console.Write($"\nРазница между максимальным и минимальным элементов массива: {r(randomArray):F2}");