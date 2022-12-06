// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
}

double DiffMaxMin(double[] array)
{
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        double max = array.Max();
        double min = array.Min();
    
        diff = max - min;
    }
    return diff;
}


Console.Clear();
Console.Write("Количество вещественных чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
FillArray(array);
Console.WriteLine($"Получен массив вещественных чисел: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между max и min массива: {DiffMaxMin(array)}");
