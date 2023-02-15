/* 
Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program(); // для доступа к полиморфным фукциям печати массивов
        string[] strArray = InputStringArray();
        string[] outArray = StringSelect(strArray, 3);
        p.PrintArray(outArray, msg: "Строки длиной не более 3 символов:");

        string[] InputStringArray(string msg = "Введите строки массива через пробел:")
        {
            string[] subs = new string[0];
            Console.WriteLine(msg);
            string? s = Console.ReadLine();
            if (s != null)
            {
                subs = s.Split();
            }
            return subs;
        }

        string[] StringSelect(in string[] strArray, int len)
        {
            string[] outArray = new string[strArray.Length];
            int i = 0;
            foreach (string sub in strArray)
            {
                if (sub.Length <= len && sub != "")
                {
                    outArray[i++] = sub;
                }
            }
            Array.Resize(ref outArray, i);
            return outArray;
        }
    }
    void PrintArray(double[,] arr, string msg = "")
    {
        Console.WriteLine(msg);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0:0.0}\t", arr[i, j]);
            }
            Console.WriteLine("");
        }
    }
    void PrintArray(int[,] arr, string msg = "")
    {
        Console.WriteLine(msg);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine("");
        }
    }
    void PrintArray(int[] arr, string msg = "")
    {
        Console.WriteLine(msg);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("{0}\t", arr[i]);
        }
        Console.WriteLine("");
    }
    void PrintArray(double[] arr, string msg = "")
    {
        Console.WriteLine(msg);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("{0:0.00}\t", arr[i]);
        }
        Console.WriteLine("");
    }
    void PrintArray(string[] arr, int maxCount = 0, string msg = "")
    {
        Console.WriteLine(msg);
        int count = maxCount < arr.Length && maxCount > 0 ? maxCount : arr.Length;
        Console.Write("[");
        for (int i = 0; i < count; i++)
        {
            Console.Write($"\"{arr[i]}\" ");
        }
        Console.WriteLine("]");
    }
}
