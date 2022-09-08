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
            array[i]=new Random().Next(1, 10);
            Console.Write($"{array[i]}, ");
            if (i%2==1) k+=array[i];
        }
    array[N-1]=new Random().Next(1, 10);
    if (N%2==0) k+=array[N-1];
    Console.WriteLine($"{array[N-1]}]");
    Console.WriteLine($"Сумма элементов, стоящих в массиве на нечётных позициях равна {k}.");
}
Random();