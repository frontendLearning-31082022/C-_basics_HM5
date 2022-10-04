using System;
using System.Text.RegularExpressions;

class MainClass
{
    public static void Main()
    {

        Task34 task34 = new Task34();
        Task36 task36 = new Task36();
        Task38 task38 = new Task38();
        OneMore oneMore=new OneMore();

    }


    public static int readInteger(String msg)
    {

        Boolean itsOK = false;

        while (!itsOK)
        {
            Console.WriteLine(msg);

            try
            {
                String input = Console.ReadLine();
                String st = Regex.Replace(input, "\\D", "");


                //  Console.WriteLine("поменяно "+st);
                if (st.Length == 0)
                {
                    Console.WriteLine("ошибка, введите число.");
                    continue;
                }


                int res = int.Parse(st);
                Console.WriteLine("(Введено число " + res + ")");
                return res;
            }
            catch (Exception) { continue; }
        }



        return 0;
    }

    static void Exception(Exception exception)
    {
        Console.WriteLine(exception);
        Environment.Exit(1);
    }
}