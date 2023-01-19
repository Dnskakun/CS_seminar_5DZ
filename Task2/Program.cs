// Задайтие одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int size = new Random().Next(5, 10);
int[] array = FillArray(size, -20, 21);
int sum = CalcSumm(size, array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {sum}");


// Функции, используемые в программе
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue+1);
    }
    return arr;
}

int CalcSumm(int size, int[] arr)
{
    int summa = 0;
    for (int i = 1; i < size; i = i + 2)
    {
        summa = summa + arr[i];
    }
    return summa;
}