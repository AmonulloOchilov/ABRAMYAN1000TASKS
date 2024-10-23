namespace ABRAMYAN1000TASKS;

public class arrays
{
    //Array1. Given an integer N (> 0), create and output an array of N integers that are the
    // first positive odd numbers: 1, 3, 5, … .
    public static void arr1()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = 2 * i + 1;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    //Array2. Given an integer N (> 0), create and output an array of N integers that are the
    // first positive integer powers of 2: 2, 4, 8, 16, … .
    public static void arr2()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = (int)Math.Pow(2, i + 1);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    //Array3. An integer N (> 1), the first term A and the common difference D of an
    // arithmetic sequence are given (A and D are real numbers). Create and output
    // an array of N real numbers that are the initial terms of this sequence:
    // A, A + D, A + 2·D, A + 3·D, … .
    public static void arr3()
    {
        int n = int.Parse(Console.ReadLine());
        double[] arr1 = new Double[n];
        
        double a = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            arr1[i] = a + i * d;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr1[i]);
        }
    }
    //Array4. An integer N (> 1), the first term A and the common ratio R of a geometric
    // sequence are given (A and D are real numbers). Create and output an array of
    // N real numbers that are the initial terms of this sequence:
    // A, A·R, A·R2
    // , A·R3
    // , … .
    public static void arr4()
    {
        int n = int.Parse(Console.ReadLine());
        double[] arr1 = new Double[n];
        
        double a = double.Parse(Console.ReadLine());
        double r = double.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            arr1[i] = a * Math.Pow(r, i);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr1[i]);
        }
    }
    //Array5. Given an integer N (> 2), create and output an array of N integers that are the
    // initial terms of a sequence {FK} of the Fibonacci numbers:
    // F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, … .
    public static void arr5()
    {
        int n = int.Parse(Console.ReadLine());
        int[] fib = new int[n];
        
        int f1 = 1;
        int f2 = 1;
        
        fib[0] = f1;
        fib[1] = f2;
        
        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(fib[i]);
        }
    }
    //Array6. Given three integers N (> 2), A, B, create and output an array of N integers
    // such that the first element is equal to A, the second one is equal to B, and each
    // subsequent element is equal to the sum of all previous ones.

    public static void arr6()
    {
        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        arr[0] = a;
        arr[1] = b;

        for (int i = 2; i < n; i++)
        {
            arr[i] = 0;

            for (int j = 0; j < i; j++)
            {
                arr[i] += arr[j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}