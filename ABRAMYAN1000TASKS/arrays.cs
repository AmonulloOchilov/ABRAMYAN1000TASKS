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
    
    //Array7. Given an array of N real numbers, output its elements in inverse order.
    public static void arr7()
    {
        int n = int.Parse(Console.ReadLine());
        double[] arr = new Double[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
        }
        Array.Reverse(arr);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    //Array8. Given an array of N integers, output all odd numbers contained in the array
    // in ascending order of their indices. Also output the amount K of odd numbers
    // contained in the array.
    public static void arr8()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int k = 0;

        for (int i = 0; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            arr[i] = y;
            if (arr[i] % 2 != 0)
            {
                Console.WriteLine(arr[i]);
                k++;
            }   
        }
        Console.WriteLine(k);
    }
    //Array9. Given an array of N integers, output all even numbers contained in the array
    // in descending order of their indices. Also output the amount K of even
    // numbers contained in the array.
    public static void arr9()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int k = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            
            if (arr[i] % 2 == 0)
            {
                k++;
            }
        }

        for (int i = n-1; i >=0; i--)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine(arr[i]);
            }
        }
        Console.WriteLine(k);
    }
    //Array10. Given an array of N integers, output all even numbers contained in the array
    // in ascending order of their indices and then output all odd numbers contained
    // in the array in descending order of their indices.
    public static void arr10()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int aceven = 0;
        int decodd = 0;

        for (int i = 0; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            arr[i] = y;
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine($"Acending even order = {arr[i]}");
                aceven++;
            }
            else
            {
                decodd++;
            }
        }
        Console.WriteLine($"Amount of aceven = {aceven}");
        
        for (int i = n-1; i >=0; i--)
        {
            if (arr[i] % 2 != 0)
            {
                Console.WriteLine($"Decending odd order = {arr[i]}");
            }
        }
        Console.WriteLine($"Amount of decodd = {decodd}");
    }
    //Array11. An array A of N real numbers and an integer K (1 ≤ K ≤ N) are given.
    // Output array elements with order numbers that are multiples of K: AK, A2·K,
    // A3·K, … . Do not use conditional statements.
    public static void arr11()
    {
        int n = int.Parse(Console.ReadLine());
        double[] a = new double[n];
        int k = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++) 
        {
            a[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= n / k; i++)
        {
            Console.WriteLine(a[i * k - 1]);
        }
    }
    //Array12. An array A of N real numbers is given (N is an even number). Output array
    // elements with even order numbers in ascending order of indices: A2, A4, A6, …,
    // AN. Do not use conditional statements.

    public static void arr12()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            arr[i] = y;
        }

        for (int i = 1; i < n; i+=2)
        {
            Console.WriteLine($"a{i + 1} = {arr[i]}");
        }
    }
    //Array13. An array A of N real numbers is given (N is an odd number). Output array
    // elements with odd order numbers in descending order of indices: AN, AN−2,
    // AN−4, …, A1. Do not use conditional statements.
    public static void arr13()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            arr[i] = y;
        }
        for (int i = n-1; i < n; i-=2)
        {
            Console.WriteLine($"a{i + 1} = {arr[i]}");
        }
    }
    //Array14. An array A of N real numbers is given. Output array elements with even
    // order numbers (in ascending order of indices) and then output array elements
    // with odd order numbers (in ascending order of indices too):
    // A2, A4, A6, …, A1, A3, A5, … .
    public static void arr14()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            arr[i] = y;
        }

        for (int i = 1; i < n; i+=2)
        {
            Console.WriteLine($"a{i + 1} = {arr[i]}");
        }
        
        for (int i = 0; i < n; i+=2)
        {
            Console.WriteLine($"a{i + 1} = {arr[i]}");
        }
    }
    //Array15. An array A of N real numbers is given. Output array elements with odd
    // order numbers in ascending order of indices and then output array elements
    // with even order numbers in descending order of indices:
    // A1, A3, A5, …, A6, A4, A2.
    // Do not use conditional statements.
    public static void arr15()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            arr[i] = y;
        }
            
        for (int i = 0; i < n; i+=2)
        {
            Console.WriteLine($"a{i + 1} = {arr[i]}");
        }

        for (int i = n-1; i >= 0; i-=2)
        {
            Console.WriteLine($"a{i + 1} = {arr[i]}");
        }
    }
    //Array16. An array A of N real numbers is given. Output array elements as follows:
    // A1, AN, A2, AN−1, A3, AN−2, … .
    public static void arr16()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            arr[i] = y;
        }
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            Console.WriteLine($"a{i + 1} = {arr[i]}");
            if (i != n - 1 - i)
            {
                Console.WriteLine($"a{n - i} = {arr[n - 1 - i]}");
            }
        }
    }
}