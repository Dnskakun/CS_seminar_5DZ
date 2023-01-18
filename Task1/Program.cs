// Задача 34. Задайтие массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int size = new Random().Next(5,20);
int[] array = FillArray(size, 100, 1000);
int result = CheckArray(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {result}");


//Функции, используемые в программе
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++) res[i] = rnd.Next(minValue, maxValue);
    return res;
}


int CheckArray(int[] arr)
{
    int size = arr.Length;
    int res = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0) res += 1;
    }
    return res;
}