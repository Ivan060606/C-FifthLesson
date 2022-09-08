Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Новый массив: ");
void Random()
{
    int k = 0;
    int[] array = new int[N];
    Console.Write("[");
    for (int i = 0; i < N-1; i++)
        {
            array[i]=new Random().Next(100, 1000);
            Console.Write($"{array[i]}, ");
            if (array[i]%2==0) k++;
        }
    array[N-1]=new Random().Next(100, 1000);
    if (array[N-1]%2==0) k++;
    Console.WriteLine($"{array[N-1]}]");
    Console.WriteLine($"В массиве {k} чётных чисел.");
}
Random();