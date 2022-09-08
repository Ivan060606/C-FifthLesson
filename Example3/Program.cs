Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Новый массив: ");
void Random()
{
    double [] array = new double[N];
    Console.Write("[");
    for (int i = 0; i < N-1; i++)
        {
            array[i]=new Random().Next(1, 100);
            Console.Write($"{array[i]}, ");
        }
    array[N-1]=new Random().Next(1, 100);
double min = array[0];
double max = array[0];
    for (int i = 1; i < N; i++)
        {            
            if (array[i]>max) max = array[i];
            else if (array[i]<min) min = array[i];
        }
        double delta = max - min;

    Console.WriteLine($"{array[N-1]}]");
    Console.WriteLine($"Разница между максимальным и минимальным элеменами массива = {delta}");
}
Random();