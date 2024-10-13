namespace ABRAMYAN1000TASKS;

public class loop
{
    //Given integers K and N (N > 0), output the number K N times.
    public static void l1()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(k);
        }
    }
    //Given two integers A and B (A < B), output in ascending order all integers in
    // the range A to B (including A and B). Also output the amount N of these
    // integers.
    public static void l2()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int n = 0;
        for (int i = a; i <= b; i++)
        {
            Console.WriteLine(i);
            n++;
        }
        Console.WriteLine(n);
    }
    //Given two integers A and B (A < B), output in descending order all integers in
    // the range A to B (excluding A and B). Also output the amount N of these
    // integers.
    public static void l3()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int n = 0;
        for (int i = b-1; i > a; i--)
        {
            Console.WriteLine(i);
            n++;
        }
        Console.WriteLine(n);
    }
    //Given the price of 1 kg of sweets (as a real number), output the cost of 1, 2, …,
    // 10 kg of these sweets.
    public static void l4()
    {
        double a = double.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i*a);
        }
    }
    //Given the price of 1 kg of sweets (as a real number), output the cost of 0.1,
    // 0.2, …, 1 kg of these sweets.
    public static void l5()
    {
        double a = double.Parse(Console.ReadLine());

        for (double i = 0.1; i <= 1; i += 0.1)
        {
            Console.WriteLine(i*a);
        }
    }
    //Given the price of 1 kg of sweets (as a real number), output the cost of 1.2,
    // 1.4, …, 2 kg of these sweets.
    public static void l6()
    {
        double a = double.Parse(Console.ReadLine());

        for (double i = 1.2; i <= 2; i += 0.2)
        {
            Console.WriteLine(i*a);
        }
    }
    //Given two integers A and B (A < B), find the sum of all integers in the range A
    // to B inclusive.
    public static void l7()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = 0;
        for (int i = a; i <= b; i++)
        {
            c+= i;
        }
        Console.WriteLine(c);
    }
    //Given two integers A and B (A < B), find the product of all integers in the
    // range A to B inclusive.
    public static void l8()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int product = 1;
        for (int i = a; i <= b; i++)
        {
            product *= i;
        }
        Console.WriteLine(product);
    }
    //Given two integers A and B (A < B), find the sum of squares of all integers in
    // the range A to B inclusive.

    public static void l9()
    {
        int a = int.Parse(Console.ReadLine());

        int b = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = a; i <= b; i++)
        {
            sum += i * i;
        }

        Console.WriteLine(sum);

    }
    //Given an integer N (> 0), find the value of a following sum (as a real
    // number):
    // 1 + 1/2 + 1/3 + … + 1/N.
    public static void l10()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
        }

        Console.WriteLine(sum);
    }
    //Given an integer N (> 0), find the value of a following product:
    // N! = 1·2·…·N
    // (N–factorial). To avoid the integer overflow, compute the product using a real
    // variable and output the result as a real number.
    
    public static void l19(){
    int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);


        }
    //An integer N (> 0) is given. Using one loop-statement compute the sum
    // 1! + 2! + 3! + … + N!,
    // where N! (N–factorial) is the product of all integers in the range 1 to N:
    // N! = 1·2·…·N. To avoid the integer overflow, compute the sum using real
    // variables and output the result as a real number.
    public static void l20()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            sum += fact;
        }
        Console.WriteLine(sum);
    }
    //An integer N (> 1) and two points A, B (A < B) on the real axis are given. The
    // segment [A, B] is divided into N sub-segments of equal length. Output the
    // length H of each sub-segment and then output the values of a function
    // F(X) = 1 − sin(X) at points dividing the segment [A, B]:
    // F(A), F(A + H), F(A + 2·H), …, F(B).
    public static void l30()
    {
        int n = int.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double h = (b - a) / n;
        Console.WriteLine(h);

        for (int i = 0; i <= n; i++)
        {
            double x = a + i * h;
            double fx = 1 - Math.Sin(x);
            Console.WriteLine(x);
            Console.WriteLine(fx);
        }
        
    }
    //An integer N (> 0) is given. A sequence of real numbers AK is defined as:
    // A0 = 2, AK = 2 + 1/AK−1, K = 1, 2, … .
    // Output terms A1, A2, …, AN of the sequence.
    public static void l31()
    {
        int n = int.Parse(Console.ReadLine());

        double pt = 2;

        for (int i = 1; i <= n; i++)
        {
            double ct = 2 + (1 / pt);
            Console.WriteLine(ct);
            pt = ct;
        }
    }
    
    
}
