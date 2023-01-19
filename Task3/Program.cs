// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементом массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int size = new Random().Next(5, 10);

float[] array = FillArray(size, -99, 99);
float result = CalcArray(size, array);

Console.WriteLine($"[{String.Join(" ", array)}] -> {result}");

//Функции, используемые в программе
float[] FillArray(int size, int minValue, int maxValue)
{
    float[] arr = new float[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++) arr[i] = rnd.Next(minValue, maxValue+1);
    return arr;
}

float CalcArray(int size, float[] arr)
{
    float minValue = arr[0];
    float maxValue = arr[0];
    for (int i = 0; i < size; i++)
    {
        if (arr[i] < minValue) minValue = arr[i];
        if (arr[i] > maxValue) maxValue = arr[i];
    }
    float res = maxValue - minValue;
    return res;
}