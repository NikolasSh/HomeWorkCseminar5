
/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] InitArray()
{
    int[] result = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(0, 100);
    }

    return result;

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumOddNumbers(int[] array)
{
    int sum = array[1];
    for (int i = 2; i < array.Length; i++)
    {
        if (i % 2 !=0)
        {
            sum = sum + array[i];
        }
    }

    return sum;
}

int[] array = InitArray();
int sum = SumOddNumbers(array);
PrintArray(array);
Console.WriteLine($"Сумма нечетных элементов массива = {sum}");