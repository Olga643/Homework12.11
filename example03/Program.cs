// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] InitArray()
{
    double[] result = new double[5];
    Random rnd = new Random();
    for (int i = 0; i < 5; i++)
    {
        result[i] = rnd.Next(1,100);
    }
    return result;
}
void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double Result( double[] array)

{
    double min = array[0];
    double max = array[0];
    double difference = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] < min)
        {
            min =  array[i];
        }
        else if(array[i] > max)
        {
            max =  array[i];
        }
        difference = max - min;
    }
    return difference;

}

double[] array = InitArray();
double result = Result(array);
Print(array);
Console.WriteLine($"{result}");