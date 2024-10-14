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
    
    //An integer N (> 0) is given. A sequence of real numbers AK is defined as:
    // A0 = 1, AK = (AK−1 + 1)/K, K = 1, 2, … .
    // Output terms A1, A2, …, AN of the sequence.
    public static void l32()
    {
        int n = int.Parse(Console.ReadLine());
        double pt = 1;
        for (int i = 1; i <= n; i++)
        {
            double ct = (pt + 1) / i;
            Console.WriteLine(ct);
            pt = ct;
        }
    }
    //An integer N (> 0) is given. An integer-valued sequence of the Fibonacci
    // numbers FK is defined as:
    // F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, … .
    // Output terms F1, F2, …, FN of the sequence.
    public static void l33()
    {
        int n = int.Parse(Console.ReadLine());
        double f1 = 1;
        double f2 = 1;
        Console.WriteLine(f1 + "\n" + f2);
        for (int i = 2; i < n; i++)
        {
            double fn = f1 + f2;
            Console.WriteLine(fn);
            f1 = f2;
            f2 = fn;
        }
    }
    //An integer N (> 1) is given. A sequence of real numbers AK is defined as:
    // A1 = 1, A2 = 2, AK = (AK−2 + 2·AK−1)/3, K = 3, 4, … .
    // Output terms A1, A2, …, AN of the sequence.
    public static void l34()
    {
        int n = int.Parse(Console.ReadLine());
        double a1 = 1;
        double a2 = 2;
        Console.WriteLine(a1 + "\n" + a2);
        for (int i = 3; i <= n; i++)
        {
            double ct = (a2 + 2 * a1) / 3;
            Console.WriteLine(ct);
            a1 = a2;
            a2 = ct;
        }
    }
    //For35. An integer N (> 2) is given. A sequence of integers AK is defined as:
    // A1 = 1, A2 = 2, A3 = 3, AK = AK−1 + AK−2 − 2·AK−3, K = 4, 5, … .
    // Output terms A1, A2, …, AN of the sequence.
    public static void l35()
    {
        int n = int.Parse(Console.ReadLine());
        double a1 = 1;
        double a2 = 2;
        double a3 = 3;
        Console.WriteLine(a1 + "\n" + a2 + "\n" + a3);

        for (int i = 4; i <= n; i++)
        {
            double ct = a1 + a2 - 2 * a3;
            Console.WriteLine(ct);
            a1 = a2;
            a2 = a3;
            a3 = ct;
        }
    }
    //For36. Given positive integers N and K, find the sum
    // 1K + 2K + … + NK
    // .
    // To avoid the integer overflow, compute the sum using real variables and
    // output the result as a real number.
    public static void l36()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            double ct = Math.Pow(i, k);
            sum += ct;
        }
        Console.WriteLine(sum);
    }
    //For37. Given an integer N (> 0), find the sum
    // 11 + 22 + … + NN
    // .
    // To avoid the integer overflow, compute the sum using real variables and
    // output the result as a real number.
    public static void l37()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            double ct = Math.Pow(i, i);
            sum += ct;
        }
        Console.WriteLine(sum);
    }
    //Given an integer N (> 0), find the sum
    // 1N + 2N−1 + … + N1
    // .
    // To avoid the integer overflow, compute the sum using real variables and
    // output the result as a real number.
    public static void l38()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            double ct = Math.Pow(i, n-i+1);
            sum += ct;
        }
        Console.WriteLine(sum);
    }
    //For39. Positive integers A and B (A < B) are given. Output all integers in the range A
    // to B, with an integer of a value K being output K times (for example, the
    // number 3 must be output 3 times).
    public static void l39()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.WriteLine(i);
            }
        }
    }
    //Integers A and B (A < B) are given. Output all integers in the range A to B,
    // with the number A being output once, the number A + 1 being output twice,
    // and so on.
    public static void l40()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= (i - a + 1); j++) 
            {
                Console.WriteLine(i);    
            }
        }
    }
}
