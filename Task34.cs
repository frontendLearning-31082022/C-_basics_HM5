using System.Collections;
class Task34
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2

    public Task34()
    {

        int[] array = genArray333();
        Console.WriteLine("Массив");
        Array.ForEach(array, num => Console.Write(num + ","));

        Console.Write("\nЧетных чисел в массиве\n");
        Console.WriteLine(getEnenNumbs(array));

    }

    int[] genArray333()
    {
        Random rnd = new Random();

        int arraySizeMax = rnd.Next();
        arraySizeMax = 10;
        int[] array = new int[arraySizeMax];

        int iter = 0;
        Array.ForEach(array, num => { array[iter] = rnd.Next(100, 999); iter++; });

        return array;
    }

    int getEnenNumbs(int[] array)
    {
        List<int> even = array.OfType<int>().ToList();
        even.RemoveAll(x => x % 2 != 0);

        return even.Count;
    }




}