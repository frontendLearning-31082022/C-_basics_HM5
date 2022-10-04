using System.Collections;
class Task36
{
    //   Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0

    public Task36()
    {
        int[] array = genArrayOneDem();
        Console.WriteLine("Массив");
        Array.ForEach(array, num => Console.Write(num + ","));

        Console.Write("\nСумма чисел на нечётных позициях в массиве\n");
        Console.WriteLine(getSumNotEvenNumbs(array));
    }

    int[] genArrayOneDem()
    {
        Random rnd = new Random();

        int arraySizeMax = rnd.Next();
        arraySizeMax = 10;
        int[] array = new int[arraySizeMax];

        int iter = 0;
        Array.ForEach(array, num => { array[iter] = rnd.Next()*rnd.Next(-100,100); iter++; });

        return array;
    }

    long getSumNotEvenNumbs(int[] array)
    {

        List<int> even = array.OfType<int>().ToList();

        long sum = 0;
        int iter = 0;
        even.ForEach(x => { if (iter % 2 != 0) sum = sum + x; iter++; });

        return sum;
    }




}