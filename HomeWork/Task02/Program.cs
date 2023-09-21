// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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




int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
     sum = sum + array[i];
    }
    return sum;
}


int[] array = GetArray(4,-99,100);
int evenNum = SumElements(array);
System.Console.WriteLine(string.Join(" ",array));
System.Console.WriteLine(evenNum);