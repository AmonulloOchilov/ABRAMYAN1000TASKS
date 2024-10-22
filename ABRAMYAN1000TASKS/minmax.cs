namespace ABRAMYAN1000TASKS;

public class minmax
{
    //Minmax1. An integer N and a sequence of N real numbers are given. Find the
    // minimal element and the maximal element of the sequence (that is, elements
    // with the minimal value and the maximal value respectively).
    public static void mn1()
    {
        int n = int.Parse(Console.ReadLine());
        double min = double.Parse(Console.ReadLine());
        double max = double.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());

            if (max < y)
            {
                max = y;
            }

            if (min > y) 
            {
                min = y;
            }
        }
        Console.WriteLine($"min = {min}, max = {max}");
    }
    //Minmax2. An integer N and a sequence of N rectangles are given. Each rectangle is
    // defined by a pair of its sides (a, b). Find the rectangle with the minimal area
    // and output the value of its area.
    public static void mn2()
    {
        int n = int.Parse(Console.ReadLine());
        double minarea = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        double area = a * b;
        if (area < minarea)
        {
            minarea = area;
        }
        }
        Console.WriteLine($"min = {minarea}");
    }
    //Minmax3. An integer N and a sequence of N rectangles are given. Each rectangle is
    // defined by a pair of its sides (a, b). Find the rectangle with the maximal
    // perimeter and output the value of its perimeter.
    public static void mn3()
    {
        int n = int.Parse(Console.ReadLine());
        double maxperimetr = double.MinValue;
        for (int i = 0; i < n; i++)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double p = 2 * (a + b);
            if (p > maxperimetr) 
            {
                maxperimetr = p;
            }
        }
        Console.WriteLine($"max = {maxperimetr}");
    }
    //Minmax4. An integer N and a sequence of N real numbers are given. Find the order
    // number of the minimal element of the sequence.
    public static void mn4()
    {
        int n = int.Parse(Console.ReadLine());
        double min = double.Parse(Console.ReadLine());
        int minindex = 1;
        for (int i = 2; i <= n; i++)
        {
            var a = double.Parse(Console.ReadLine());
            if (min > a)
            {
                min = a;
                minindex = i;
            }
        }
        Console.WriteLine($"minimum index = {minindex}");
    }
    //Minmax5. An integer N and a sequence of N pairs of real numbers (m, v) are given.
    // Each pair of given numbers contains the weight m and the volume v of a detail
    // that is made of some homogeneous material. Output the order number of a
    // detail that is made of the material with maximal density. Also output the
    // corresponding density. Note that the density P can be found by formula
    // P = m/v.
    public static void mn5()
    {
        int n = int.Parse(Console.ReadLine());
        double maxdens = double.MinValue;
        int dindex = 1;
        for (int i = 1; i <= n; i++)
        {
            double m = double.Parse(Console.ReadLine());
            double v = double.Parse(Console.ReadLine());
            double p = m / v;
            if (maxdens < p) 
            {
                maxdens = p;
                dindex = i;
            }
        }
        Console.WriteLine($"maximum density = {maxdens}, index = {dindex}");
    }
    //Minmax6. An integer N and a sequence of N integers are given. Find the order
    // numbers of the first minimal element and the last maximal element of the
    // sequence.
    public static void mn6()
    {
        int n = int.Parse(Console.ReadLine());
        double fe = double.Parse(Console.ReadLine());
        double min = fe;
        double max = fe;
        int posmax = 1;
        int posmin = 1;
        for (int i = 2; i <= n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            
            if (max < y)
            {
                max = y;
                posmax = i;
            }

            if (min > y) 
            {
                min = y;
                posmin = i;
            }
        }
        Console.WriteLine($"Min position = {posmin}, Max position = {posmax}");
    }
    //Minmax7. An integer N and a sequence of N integers are given. Find the order
    // numbers of the first maximal element and the last minimal element of the
    // sequence.
    public static void mn7()
    {
        int n = int.Parse(Console.ReadLine());
        int fe = int.Parse(Console.ReadLine());
        int min = fe;
        int max = fe;
        int posmax = 1;
        int posmin = 1;

        for (int i = 2; i <= n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            if (max < y) 
            {
                max = y;
                posmax = i;
            }

            if (min >= y)
            {
                min = y;
                posmin = i;
            }
        }
        Console.WriteLine($"First  Max position = {posmax}, Last Min pos = {posmin}");
    }
    //Minmax8. An integer N and a sequence of N integers are given. Find the order
    // numbers of the first and the last minimal elements of the sequence.
    public static void mn8()
    {
        int n = int.Parse(Console.ReadLine());
        int fe = int.Parse(Console.ReadLine());
        int min = fe;
        int posminl = 1;
        int posmin = 1;

        for (int i = 2; i <= n; i++)
        {
            int y = int.Parse(Console.ReadLine());

            if (min > y)
            {
                min = y;
                posmin = i;
            }
            if (min >= y)
            {
                posminl = i;
            }
        }
        Console.WriteLine($"First min pos = {posmin}");
        Console.WriteLine($"Last min pos = {posminl}");
    }
    //Minmax9. An integer N and a sequence of N integers are given. Find the order
    // numbers of the first and the last maximal elements of the sequence.
    public static void mn9()
    {
        int n = int.Parse(Console.ReadLine());
        int fe = int.Parse(Console.ReadLine());
        int max = fe;
        int posmax = 1;
        int posmaxl = 1;

        for (int i = 2; i <= n; i++)
        {
            int y = int.Parse(Console.ReadLine());

            if (max < y) 
            {
                max = y;
                posmax = i;
            }

            if (max <= y) 
            {
                posmaxl = i;
            }
        }
        Console.WriteLine($"First Max pos = {posmax}");
        Console.WriteLine($"Last Max pos = {posmaxl}");
    }
    //Minmax10. An integer N and a sequence of N integers are given. Find the order
    // number of the first extremal (that is, minimal or maximal) element of the
    // sequence.
    public static void mn10()
    {
        int n = int.Parse(Console.ReadLine());
        int first = int.Parse(Console.ReadLine());
        int min = first;
        int max = first;
        
        int minindex = 1;
        int maxindex = 1;

        for (int i = 2; i <= n; i++)
        {
            int y = int.Parse(Console.ReadLine());

            if (min > y)
            {
                min = y;
                minindex = i;
            }
            if (max < y) 
            {
                max = y;
                maxindex = i;
            }
        }

        if (minindex < maxindex) 
        {
            Console.WriteLine($"First min at pos = {minindex}");
        }
        else
        {
            Console.WriteLine($"First max at pos = {maxindex}");
        }
    }
    //Minmax20. An integer N and a sequence of N integers are given. Find the total
    // amount of all extremal (that is, minimal or maximal) elements of the sequence.
    public static void mn20()
    {
        int n = int.Parse(Console.ReadLine());
        int first = int.Parse(Console.ReadLine());
        int min = first;
        int max = first;

        int totalamountmin = 1;
        int totalamountmax = 1;


        for (int i = 2; i <= n; i++)
        {
            int y = int.Parse(Console.ReadLine());

            if (min > y)
            {
                min = y;
                totalamountmin = 1;
            }
            else if (min == y)
            {
                totalamountmin++;
            }

            if (max < y)
            {
                max = y;
                totalamountmax = 1;
            }
            else if (max == y)
            {
                totalamountmax++;
            }
        }

        Console.WriteLine($"Total amount of min = {totalamountmin}");
        Console.WriteLine($"Total amount of max = {totalamountmax}");
    }
    //Minmax21. An integer N (> 2) and a sequence of N real numbers are given. The
    // elements of the sequence represent some experimental data. Find the average
    // of the experimental data provided that the minimal and maximal values must
    // be ignored.
    public static void mn21()
    {
        int n = int.Parse(Console.ReadLine());
        double first = double.Parse(Console.ReadLine());
        var min = first;
        var max = first;

        for (int i = 2; i <= n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            if (max < y)
            {
                max = y;
            }

            if (min > y)
            {
                min = y;
            }
        }

        double sum = 0;
        int count = 0;
        
        Console.WriteLine($"Enter {n} numbers again to calculate the average ignoring min and max:");

        for (int i = 1; i <= n; i++)
        {
            double y = double.Parse(Console.ReadLine());
            if (y == min || y == max)
            {
                continue;
            }

            sum += y;
            count++;
        }

        if (count > 0)
        {
            double average = sum / count;
            Console.WriteLine($"Avarage = {average}");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
    //Minmax22. An integer N (> 2) and a sequence of N real numbers are given. Find two
    // smallest elements of the sequence and output their values in ascending order.
    public static void mn22()
    {
        int n = int.Parse(Console.ReadLine());
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            if (min1 > y)
            {
                min2 = min1;
                min1 = y;
            }else if (min2 > y && y != min1)  
            {
                min2 = y;
            }
        }
        Console.WriteLine(min1);
        Console.WriteLine(min2);
    }
    //Minmax23. An integer N (> 3) and a sequence of N real numbers are given. Find
    // three greatest elements of the sequence and output their values in descending
    // order.
    public static void mn23()
    {
        int n = int.Parse(Console.ReadLine());
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int max3 = int.MinValue;

        for (int i = 1; i <= n; i++)
        {
            int y = int.Parse(Console.ReadLine());

            if (max1 < y) 
            {
                max3 = max2;
                max2 = max1;
                max1 = y;
            }else if (max2 < y) 
            {
                max3 = max2;
                max2 = y;
            }else if (max3 < y)
            {
                max3 = y;
            }
        }
        Console.WriteLine($"{max1}, {max2}, {max3}");
    }
    //Minmax24. An integer N (> 1) and a sequence of N real numbers are given. Find the
    // maximal sum of two adjacent elements of the sequence.
    public static void mn24()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        
        int previous = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            int sum = current + previous;

            if (sum > max) 
            {
                max = sum;
            }

            previous = current;
        }
        Console.WriteLine(max);
    }
    //Minmax25. An integer N (> 1) and a sequence of N real numbers are given. Find two
    // adjacent elements that have the minimal product of their values and output
    // their order numbers in ascending order.
    public static void mn25()
    {
        int n = int.Parse(Console.ReadLine());
        int previous = int.Parse(Console.ReadLine());
        int minpr = int.MaxValue;
        int minin1 = -1;
        int minin2 = -1;

        for (int i = 1; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            int pr = current * previous;

            if (pr < minpr)
            {
                minpr = pr;
                minin1 = i - 1;
                minin2 = i;
            }
            previous = current;
        }
        Console.WriteLine($"{minin1 + 1} {minin2 + 1}");
    }
}