Console.Clear();
Console.WriteLine("Введите длинну массива");

uint length;
    while (!uint.TryParse(Console.ReadLine()!, out length))
    {
        Console.WriteLine("Нужно положительное");
    }
int[] array = new int[length];


void RandomArray(int[] array)     
{
    Random random = new Random();
    Console.WriteLine("Сгенерированный массив");
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-99,100);
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
EvenIndex(array);

void EvenIndex(int[] array)      
{
    int sum = 0;
    for (int i = 1; i < length; i+=2)
    {
        sum = array[i] + sum; 
            
    }
    Console.WriteLine("Сумма нечётных элементов в массиве = " + sum);
}
