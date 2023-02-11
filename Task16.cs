/*
Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] InitArray()
{
    double[] result = new double[10];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.NextDouble() * 10 - 1;
        result[i] = Math.Round(result[i], 3);
    }
    return result;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void DiffMaxMinNumber(double[] array)
{
    double max = array[0];
    double min = array[0];
    double sum = 0;
    for (int i = 1; i < array.Length; i++)
    {               
        if (array[i] > max)
        {
            max = array[i];                      
        }                    
    }

    for (int j = 1; j < array.Length; j++)
    {
        if (array[j] < min)
        {
            min = array[j];
        }
    }
    sum = max - min; 
    Console.WriteLine($"Разница между самым большим числом массива {max} и самым маленьким {min} = {sum}");
}

double[] array = InitArray(); 
PrintArray(array);
DiffMaxMinNumber(array);
