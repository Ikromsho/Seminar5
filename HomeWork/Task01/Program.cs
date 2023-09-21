// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2




using System.Diagnostics.Tracing;

int[] GetArray(int length = 10,int min = 0,int max = 10)
{
    int[] array = new int[length];
    Random rand = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(min, max);
    }
    return array;
}




int EvenNum(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            even++;
        }
    }
    return even;
}


int[] array = GetArray(10,100,1000);
int evenNum = EvenNum(array);
System.Console.WriteLine(string.Join(" ",array));
System.Console.WriteLine(evenNum);