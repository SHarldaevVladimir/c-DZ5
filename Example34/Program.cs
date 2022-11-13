Console.Clear();
Console.WriteLine("Введите длинну массива");

uint length;
    while (!uint.TryParse(Console.ReadLine()!, out length))
    {
        Console.WriteLine("Нужно положительное");
    }
int[] array = new int[length];

void NumberOfEven(int[] array)    
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine("Кол-во чётных чисел в массиве = " + count);
}

void RandomArray(int[] array)     
{
    Random random = new Random();
    Console.WriteLine("Сгенерированный массив");
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}

void PrintArray(int[] array)     
{
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine(array[i]);
    }
    
}

RandomArray(array);
PrintArray(array);
NumberOfEven(array);