using System.Collections;
class Task38
{
    //  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    // [3 7 22 2 78] -> 76

    public Task38()
    {
        double[] array = genArrayDouble();
        Console.WriteLine("Массив");
        Array.ForEach(array, num => Console.Write(num + " --> "));
        Console.WriteLine("\n");

        Console.WriteLine("разница между максимальным и минимальным элементом массива \n");
         Console.WriteLine( getEnenNumbs(array));


    }


    double[] genArrayDouble()
    {
        Random rnd = new Random();

        int arraySizeMax = rnd.Next();
        arraySizeMax = 10;
        double[] array = new double[arraySizeMax];

        int iter = 0;
        Array.ForEach(array, num => { array[iter] = rnd.NextDouble() * (rnd.NextDouble() < 0.5 ? -1 : 1) * rnd.Next(); iter++; });

        return array;
    }

    double getEnenNumbs(double[] array)
    {
        double minVal = array[0];
        double maxVal = array[0];

        Array.ForEach(array, num => { if (num > maxVal) maxVal = num; if (num < minVal) minVal = num; });
        return maxVal - minVal;
    }
}