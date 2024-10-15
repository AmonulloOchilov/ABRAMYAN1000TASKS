namespace ABRAMYAN1000TASKS;

public class cloop
{
    //While1. Two positive real numbers A and B (A > B) are given. A segment of length A
    // contains the greatest possible amount of segments of length B (without
    // overlaps). Not using multiplication and division, find the length of unused part
    // of the segment A.
    public static void cl1()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        while (a>=b)
        { 
            a -= b;
        }
        Console.WriteLine(a);
    }
    //While2. Two positive real numbers A and B (A > B) are given. A segment of length A
    // contains the greatest possible amount of segments of length B (without
    // overlaps). Not using multiplication and division, find the amount of
    // segments B, which are placed on the segment A.
    public static void cl2()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        int tt = 0;
        while (a>=b)
        {
            a -= b;
            tt++;
        }
        Console.WriteLine(tt);
    }
    //While3. Two positive integers N and K are given. Using addition and subtraction
    // only, find a quotient of the integer division N on K and also a remainder after
    // this division.
    public static void cl3()
    {
        double n = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());
        double rem = n;
        double quo = 0;

        while (rem >= k) 
        {
            rem -= k;
            quo++;
        }
        Console.WriteLine(quo);
        Console.WriteLine(rem);
    }
    //While4. An integer N (> 0) is given. If it equals 3 raised to some integer power then
    // output True, otherwise output False.
    public static void cl4()
    {
        double n = double.Parse(Console.ReadLine());
        while (n % 3 == 0 && n > 1)
        {
            n /= 3;
        }

        if (n == 1) 
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
    }
    //Given an integer N (> 0) that equals 2 raised to some integer power: N = 2K
    // ,
    // find the exponent K of the power.
    public static void cl5()
    {
        double n = double.Parse(Console.ReadLine());
        double k = 0;   
        while (n % 2 == 0 && n > 0)
        {
            n /= 2;
            k++;
        }

        if (n == 1) 
        {
            Console.WriteLine(k);
        }
    }
    //While6. Given an integer N (> 0), compute the double factorial of N:
    // N!! = N·(N−2)·(N−4)·…,
    // where the last factor equals 2 if N is an even number, and 1 otherwise. To
    // avoid the integer overflow, compute the double factorial using a real variable
    // and output the result as a real number.
    public static void cl6()
    {
        double n = double.Parse(Console.ReadLine());
        double result = 1;
        while (n >1)
        {
            result *= n;
            n -= 2;

        }
        Console.WriteLine(result);
    }
    //Given an integer N (> 0), find the smallest positive integer K such that its
    // square is greater than N: K2 > N. Do not use the operation of extracting a root.
    public static void cl7()
    {
        int n = int.Parse(Console.ReadLine());
        int k = 1;
        while (k * k <= n) 
        {
            k++;
        }
        Console.WriteLine(k);
    }
    //Given an integer N (> 0), find the largest integer K such that its square is not
    // greater than N: K2 ≤ N. Do not use the operation of extracting a root.
    public static void cl8()
    {
        int n = int.Parse(Console.ReadLine());
        int k = 1;
        while (n >= k * k)  
        {
            k++;
        }
        Console.WriteLine(k-1);
    }
    //Given an integer N (> 1), find the smallest integer K such that the inequality
    // 3K > N is fulfilled.
    public static void cl9()
    {
        int n = int.Parse(Console.ReadLine());
        int k = 0;
        int cp = 1;
        while (cp <= n)
        {
            k++;
            cp = cp * 3;
        }
        Console.WriteLine(k);
    }
    //Given an integer N (> 1), find the largest integer K such that the inequality
    // 3K < N is fulfilled.
    public static void cl10()
    {
        int n = int.Parse(Console.ReadLine());
        int k = 0;
        int cp = 1;
        while (cp <= n)
        {
            k++;
            cp = cp * 3;
        }
        Console.WriteLine(k-1);
    }
    //While20. An integer N (> 0) is given. Determine whether its decimal representation
    // contains a digit ‖2‖ or not, and output True or False respectively. Use the
    // operators of integer division and taking the remainder after integer division.
    public static void cl20()
    {
        int n = int.Parse(Console.ReadLine());
        bool dig = false;
        while (n > 0)
        {
            if (n % 10 == 2) 
            {
                dig = true;               
            }

            n /= 10;
        }
        Console.WriteLine(dig);
    }
    //While21. An integer N (> 0) is given. Determine whether its decimal representation
    // contains odd digits or not, and output True or False respectively. Use the
    // operators of integer division and taking the remainder after integer division.
    public static void cl21()
    {
        int n = int.Parse(Console.ReadLine());
        bool dig = false;
        while (n>0)
        {
            if (n % 10 % 2 != 0) 
            {
                dig = true;
                break;
            }

            n /= 10;
        }
        Console.WriteLine(dig);
    }
    //While22. An integer N (> 1) is given. If it is a prime number, i. e., it has not positive
    // divisors except 1 and itself, then output True, otherwise output False.
    public static void cl22()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 1) {
            Console.WriteLine("false");
            return;
        }
        if (n == 2) 
        {
            Console.WriteLine("true");
            return;
        }
        if (n % 2 == 0) 
        {
            Console.WriteLine("false");
            return;
        }
        
        bool dig = true;
        int i = 3;
        while (n > 1 && i*i <= n)
        {
            if (n % i == 0)  
            {
                dig = false;
            }

            i += 2;
        }
        Console.WriteLine(dig);
    }
    //While23. Two positive integers A and B are given. Find their greatest common
    // divisor (GCD) using the Euclidean algorithm:
    // GCD(A, B) = GCD(B, A mod B), if B ≠ 0; GCD(A, 0) = A,
    // where ―mod‖ denotes the operator of taking the remainder after integer
    // division.
    public static void cl23()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        

        while (b > 0)
        {
            int c = b;
            b = a % b;
            a = c;
        }
        Console.WriteLine(a);
    }
    //While24. An integer N (> 1) is given. An integer-valued sequence of the Fibonacci
    // numbers FK is defined as:
    // F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, … .
    // Determine whether N is a Fibonacci number or not, and output True or False
    // respectively.
    public static void cl24()
    {
        int n = int.Parse(Console.ReadLine());
        int f1 = 1;
        int f2 = 1;

        if (n == f1 || n == f2)
        {
            Console.WriteLine("true");
            return;
        }

        while (f2 < n)
        {
            int fib = f1 + f2;
            f1 = f2;
            f2 = fib;
            if (f2 == n) 
            {
                Console.WriteLine("true");
                return;
            }
            
        }
        Console.WriteLine("false");
    }
    //While25. Given an integer N (> 1), find the first Fibonacci number greater than N
    // (see the Fibonacci numbers definition in While24).
    public static void cl25()
    {
        int f1 = 1;
        int f2 = 1;
        int n = int.Parse(Console.ReadLine());
        while (f2 <= n) 
        {
            int nfib = f1 + f2;
            f1 = f2;
            f2 = nfib;
        }
        Console.WriteLine(f2);
    }
    //While26. Given an integer N (> 1) that is a Fibonacci number: N = FK, output
    // previous and next Fibonacci numbers: FK−1 and FK+1 (see the Fibonacci
    // numbers definition in While24).
    public static void cl26()
    {
        int n = int.Parse(Console.ReadLine());
        int f1 = 1;
        int f2 = 1;
        while (f2 < n) 
        {
            int fib = f1 + f2;
            f1 = f2;
            f2 = fib;
        }
        int nfib = f1 + f2;
        Console.WriteLine(f1);
        Console.WriteLine(nfib);
    }
    //While27. Given an integer N (> 1) that is a Fibonacci number: N = FK, find its order
    // number K (see the Fibonacci numbers definition in While24).
    public static void cl27()
    {
        int n = int.Parse(Console.ReadLine());
        int f1 = 1;
        int f2 = 1;
        int count = 2;
        if (n == f1)
        {
            Console.WriteLine(1);
            return;
        }
        while (f2 < n)
        {
            int fib = f1 + f2;
            f1 = f2;
            f2 = fib;
            count++;
        }

        if (f2 == n) 
        {
            Console.WriteLine(count);
        }
    }
    //While28. A real number ε (> 0) is given. A sequence of real numbers AK is defined
    // as:
    // A1 = 2, AK = 2 + 1/AK−1, K = 2, 3, … .
    // Find the first index K such that the inequality |AK − AK−1| < ε is fulfilled. Output
    // the index K and the terms AK−1 and AK.
    public static void cl28()
    {
        double a1 = 2;
        double a2 = 0;
        double e = double.Parse(Console.ReadLine());
        int k = 2;

        while (true)
        {
            a2 = 2 + 1 / a1;
            if (Math.Abs(a2 - a1) < e)
            {
                Console.WriteLine(k);
                Console.WriteLine(a1);
                Console.WriteLine(a2);
                break;
            }

            a1 = a2;
            k++;
        }
    }
    //While29. A real number ε (> 0) is given. A sequence of real numbers AK is defined
    // as:
    // A1 = 1, A2 = 2, AK = (AK−2 + 2·AK−1)/3, K = 3, 4, … .
    // Find the first index K such that the inequality |AK − AK−1| < ε is fulfilled. Output
    // the index K and the terms AK−1 and AK.
    public static void cl29()
    {
        double a1 = 2;
        double a2 = 0;
        double e = double.Parse(Console.ReadLine());
        int k = 3;

        while (true)
        {
            a2 = 2 + 1 / a1;
            double ak = (a1 + 2 * a2) / 3;
            if (Math.Abs(ak - a2) < e)
            {
                Console.WriteLine(k);
                Console.WriteLine(a2);
                Console.WriteLine(ak);
                break;
            }

            a1 = a2;
            a2 = ak;
            k++;
        }
    }
    //While30. Three positive real numbers A, B, C are given. A rectangle of size A × B
    // contains the greatest possible amount of squares with side C (without
    // overlaps). Find the amount of squares placed on the rectangle. Do not use the
    // operators of multiplication and division.
    public static void cl30()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        int ca = 0;
        int cb = 0;
        while (a>=c)
        {
            a = a - c;
            ca++;
        }

        while (b >= c)
        {
            b -= c;
            cb++;
        }

        int tc = 0;
        for (int i = 0; i < ca; i++)
        {
            tc += cb;
        }
        Console.WriteLine(tc);
    }
}