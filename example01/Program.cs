// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] InitArray()
{
    int[] result = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < 10; i++)
    {
        result[i] = rnd.Next(100,999);
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
    int num = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
        num++;
        }
    }
    return num;

}

int[] array = InitArray();
int result = Result(array);
Print(array);
Console.WriteLine($"{result}");
