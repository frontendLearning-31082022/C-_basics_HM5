using System.Collections;
class OneMore
{
    // Найти в массиве самую длинную последовательность, состоящую из одинаковых элементов. Вывести на экран количество элементов самой длиной последовательности,
    //  элемент самой последовательности и номер элемента, который является ее началом.
    // Данная задача не вилияет на оценку
    // Пример:
    // [1 2 2 4 4 4 4 3 3 3] ->
    // Count: 4
    // Element: 4
    // Position: 3

    public OneMore()
    {
        int[] array = genArrayRepeats();
        Console.WriteLine("Массив");
        Array.ForEach(array, num => Console.Write(num + "\t"));

        RepeatObject result = RepeatObject.findRepeatChain(array);
        Console.WriteLine(result.getInfo());
    }

    int[] genArrayRepeats()
    {
        Random rnd = new Random();

        int arraySizeMax = rnd.Next();
        arraySizeMax = 30;
        int[] array = new int[arraySizeMax];


        int lastNum = -1;
        for (int i = 0; i < arraySizeMax; i++)
        {
            Boolean repeatIT = rnd.NextDouble() < 0.5;
            int newRand = rnd.Next();
            array[i] = repeatIT ? lastNum : newRand;
            lastNum = array[i];
        }



        return array;
    }




    class RepeatObject : ICloneable
    {

        public static RepeatObject findRepeatChain(int[] array)
        {

            RepeatObject repeatMax = new RepeatObject(1, array[0], 0);
            RepeatObject current = new RepeatObject(1, array[0], 0);

            for (int i = 1; i < array.Length; i++)
            {
                if (current.isNewChain(array[i]) && current.getSize() > repeatMax.getSize()) repeatMax = (RepeatObject)current.Clone(); ;
                if (current.isNewChain(array[i])) current = new RepeatObject(1, array[i], i);

                if (!current.isNewChain(array[i])) current.countOneMore();
            }

            if (current.getSize() > repeatMax.getSize()) repeatMax = current;

            return repeatMax;
        }


        int countRepeats;
        int element;
        int firstPosition;

        RepeatObject(int countRepeats, int element, int position)
        {
            this.countRepeats = countRepeats;
            this.element = element;
            this.firstPosition = position;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int getSize()
        {
            return countRepeats;
        }

        public void countOneMore()
        {
            countRepeats++;
        }

        public String getInfo()
        {
            return "\n ======== \n Результат - Число " + this.element +
                    "\n Повторялось " + this.countRepeats + " раз\n" + "IndexOf - " + this.firstPosition;
        }

        Boolean isNewChain(int Digit)
        {
            return Digit != this.element;
        }

    }


}
