namespace ABRAMYAN1000TASKS;

public class Condition
{
    //An integer is given. If the integer is positive then increase it by 1, otherwise do
    // not change it. Output the obtained integer.
    public static void if1()
    {
        int a = int.Parse(Console.ReadLine());
        if (a > 0)
        {
            a++;
        }
        Console.WriteLine(a);
    }
    //An integer is given. If the integer is positive then increase it by 1, otherwise
    // decrease it by 2. Output the obtained integer.

    public static void if2()
    {
        int a = int.Parse(Console.ReadLine());
        if (a > 0)
        {
            Console.WriteLine(a + 1);
        }
        else
        {
            Console.WriteLine(a - 2);
        }
    }
    //An integer is given. If the integer is positive then increase it by 1, if the integer is
    // negative then decrease it by 2, if the integer equals 0 then change it to 10.
    // Output the obtained integer.
    public static void if3()
    {
        int a = int.Parse(Console.ReadLine());
        
        if (a > 0)
        {
            Console.WriteLine(a + 1);
        }
        else if (a < 0)
        {
            Console.WriteLine(a - 2);
        }
        else
        {
            Console.WriteLine(10);
        }
        
    }
    //Three integers are given. Find the amount of positive integers in the input data.
    public static void if4()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine(3);
        }else if ((a>0 && b>0 && c<0) || (a>0 && b<0 && c>0) || (a<0 && b>0 && c>0))
        {
            Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(1);
        }
        
        
    }
    
    //Three integers are given. Find the amount of positive and amount of negative
    // integers in the input data.
    public static void if5()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine(3);
            Console.WriteLine(0);
        }else if ((a>0 && b>0 && c<0) || (a>0 && b<0 && c>0) || (a<0 && b>0 && c>0))
        {
            Console.WriteLine(2);
            Console.WriteLine(1);
        }
        else if ((a>0 && b<0 && c<0) || (a<0 && b<0 && c>0) || (a<0 && b>0 && c<0))
        {
               Console.WriteLine(1);
               Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(0);
            Console.WriteLine(3);
        }
        
    }
    //Given two real numbers, output the larger value of them.
    public static void if6()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(a, b));
    }
    //Given two real numbers, output the order number of the smaller of them
    
    public static void if7()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());

        if (a < b)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(2);
        }
    }
    //Given two real numbers, output the larger value and then the smaller value of
    // them.
    public static void if8()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        Console.WriteLine("Max = " + Math.Max(a, b));
        Console.WriteLine("Min = " + Math.Min(a, b));
    }
    //The values of two real variables A and B are given. Redistribute the values so
    // that A and B have the smaller and the larger value respectively. Output the new
    // values of the variables A and B.
    public static void if9()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        if (a>b)
        {
            double c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("A: " + a + " B: " + b);
    }
    //The values of two integer variables A and B are given. If the values are not
    // equal then assign the sum of given values to each variable, otherwise assign
    // zero value to each variable. Output the new values of the variables A and B

    public static void if10()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        if (a != b)
        {
            double c = a + b;
            a = c;
            b = c;
            
        }
        else
        {
            a = 0;
            b = 0;
        }

        Console.WriteLine("A " + a + " B: " + b);
    }
    //The values of two integer variables A and B are given. If the values are not
    // equal then assign the larger value to each variable, otherwise assign zero value
    // to each variable. Output the new values of the variables A and B.
    public static void if11()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());

        if (a != b)
        {
            double c = Math.Max(a, b);
            b = c;
            a = c;
        }
        else
        {
            a = 0;
            b = 0;
        }
        Console.WriteLine("A " + a + " B: " + b);
    }

    //Given three real numbers, output the minimal value of them.
    public static void if12()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());

        double min = a;
        if (b<min)
        {
            min = b;
        }
        if (c<min)
        {
            min = c;
        }
        Console.WriteLine(min);
    }
    //Given three real numbers, output the value between the minimum and the
    // maximum.
    public static void if13()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());

        double mid, min, max;
        if (a <= b && a <= c)
        {
            min = a;
            if (b <= c)
            {
                mid = b;
                max = c;
            }
            else
            {
                mid = c;
                max = b;
            }
        }else if (b <= a && b <= c)
        {
            min = b;
            if (a <= c)
            {
                max = c;
                mid = a;
            }
            else
            {
                max = a;
                mid = c;
            }
        }
        else
        {
            min = c;
            if (a <= b)
            {
                mid = a;
                max = b;
            }
            else
            {
                max = a;
                mid = b;
            }
        }
        Console.WriteLine("Mid = " + mid);
    }
    //Given three real numbers, output the minimal value and then the maximal value.
    public static void if14()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        
        double min, max;
        if (a <= b && a <= c)
        {
            min = a;
            if (b <= c)
            {
                max = c;
            }
            else
            {
                max = b;
            }
        }else if (b <= a && b <= c)
        {
            min = b;
            if (a <= c)
            {
                max = c;
            }
            else
            {
                max = a;
            }
        }
        else
        {
            min = c;
            if (a <= b)
            {
                max = b;
            }
            else
            {
                max = a;
            }
        }
        Console.WriteLine("Max = " + max + "\nMin = " + min);
        
    }
}