

public static class Program { 
    static void Main(string[] args)
    {
        int i = 10, j = 20;

        if (isGreater(i, j))
        {
            Console.WriteLine("i is less than j");
        }

        if (isGreater(j, i))
        {
            Console.WriteLine("j is greater than i");
        }


        int[] array1 = new int[5];

        for (int k = 0; k < array1.Length; k++)
        {
            array1[k] = (k *10);
        }
        for (int t = 0; t < array1.Length; t++)
        {
            Console.WriteLine(array1[t]);
        }

    }

    static bool isGreater(int i, int j)
    {
        return i > j;
    }


}