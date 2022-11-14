//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] InitArray()
{
    int[] result = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < 10; i++)
    {
        result[i] = rnd.Next(-10,100);
    }
    return result;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Result( int[] array)

{
    int sum = 0;
    
        for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
        sum +=  array[i];
        }
    }
    return sum;

}

int[] array = InitArray();
int result = Result(array);
Print(array);
Console.WriteLine($"{result}");
