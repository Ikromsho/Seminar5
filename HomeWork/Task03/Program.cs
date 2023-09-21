// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double GetMax(double[] b) {

    double max = b[0];
    for (int i = 0; i < b.Length; i++)
    {
        if (b[i] > max)
        {
            max = b[i];
        }
    }
    Console.WriteLine("Максимальный элемент массива: " + max);

    return max;
}
double GetMin(double[] b) {
    double min = b[0];
    for (int i = 0; i < b.Length; i++) {
        if (b[i] < min)
        {
            min = b[i];
        }
    }
    Console.WriteLine("Минимальный элемент массива: " + min);
    return min;

}

void GetDifference(double[] b)
{
    double s = GetMax(b)-GetMin(b);
    
    Console.WriteLine("Разница между максимальным и минимальным элеметом массива: "+s);
}
void Print(double []a) {
    Console.WriteLine("Массив");
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(a[i]);
    }
}
double[] Gen(double[] b) {
    for (int i = 0; i < b.Length; i++)
    {
        b[i]= new Random().Next(-99,99)+ new Random().NextDouble();
    }
    return b;
}
double[]a=new double[100];
a=Gen(a);
Print(a);
GetDifference(a);
