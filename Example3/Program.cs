Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Новый массив: ");
void Random()
{
    int k = 0;
    double [] array = new double[N];
    Console.Write("[");
    for (int i = 0; i < N-1; i++)
        {
            array[i]=new Random().Next(1, 100);
            Console.Write($"{array[i]}, ");
            if (array[i]%2==0) k++;
        }
    array[N-1]=new Random().Next(1, 100);
    if (array[N-1]%2==0) k++;
    Console.WriteLine($"{array[N-1]}]");
    Console.WriteLine($"В массиве {k} чётных чисел.");
}
Random();