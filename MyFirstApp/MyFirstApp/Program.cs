// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }    
    
    return sum / numbers.Length;
}

static int FindMaxValue(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}


