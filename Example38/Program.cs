Console.Clear();
Console.WriteLine("Введите длинну массива");
uint length;
    while (!uint.TryParse(Console.ReadLine()!, out length))
    {
        Console.WriteLine("Неверный ввод");
    }
double[] array = new double[length];

RandomArray(array);
PrintArray(array);
MaxMinDif(array);


void RandomArray(double[] array)    
{
    Random random = new Random();
    Console.WriteLine("Сгенерированный массив ");
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(random.Next(-100, 100) + random.NextDouble(), 2);
    }
}

void PrintArray(double[] array)   
{
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    
}

void MaxMinDif(double[] array)      
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

        if (array[i] > max)
        {
            max = array[i];
        }
    }
    double difference = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + difference);
}