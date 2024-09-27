namespace ABRAMYAN1000TASKS;

public class integers
{
    public static void int1()
    {
        int l = int.Parse(Console.ReadLine());
        int m = l / 1000;
        Console.WriteLine(m);

    }

    public static void int2()
    {
        int m = int.Parse(Console.ReadLine());
        int t = m / 1000;
        Console.WriteLine(t);
        
    }

    public static void int3()
    {
        int b = int.Parse(Console.ReadLine());
        int k = b / 1024;
        Console.WriteLine(k);
    }

    public static void int4()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int s = a / b;
        Console.WriteLine(s);
    }

    public static void int5()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int s = a % b;
        Console.WriteLine(s);
    }

    public static void int6()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a / 10;
        int c = a % b;
        Console.WriteLine(b);
        Console.WriteLine(c);
    }

    public static void int7()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int e = a / 10;
        int f = a % b;
        int c = e + f;
        int d = e * f;
        Console.WriteLine(c);
        Console.WriteLine(d);
    }

    public static void int8()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a / 10;
        int c = a % 10;

        int d = c * 10 + b;
        Console.WriteLine(d);
    }

    public static void int9()
    {
        int a = int.Parse(Console.ReadLine());

        int b = a / 100;
        Console.WriteLine(b);
    }

    public static void int10()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a % 10;
        int c = a / 10 % 10;
        Console.WriteLine(b);
        Console.WriteLine(c);
    }

    public static void int11()
    {
        int a = int.Parse(Console.ReadLine());
        
        int e = a / 100;
        int f = a / 10 % 10;
        int c = a % 10;

        int d = e + f + c;
        int l = c * e * f;
        Console.WriteLine(c);
        Console.WriteLine(d);
    }

    public static void int12()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a % 10;
        int c = a / 10 % 10;
        int d = a / 100;
        
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }

    public static void int13()
    {
        int a = int.Parse(Console.ReadLine());

        int b = a % 10;
        int c = a / 10 % 10;
        int d = a / 100;
        
        int e = c*100+b*10+d;
        Console.WriteLine(e);
        
    }

    public static void int14()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a % 10;
        int c = a / 10 % 10;
        int d = a / 100;

        int e = b * 100 + c * 10 + d;
        Console.WriteLine(e);
    }

    public static void int15()
    {
        int a = int.Parse(Console.ReadLine());

        int b = a % 10;
        int c = a / 10 % 10;
        int d = a / 100;
        
        int e = c*100+d*10+b;
        Console.WriteLine(e);
    }

    public static void int16()
    {
        int a = int.Parse(Console.ReadLine());

        int b = a % 10;
        int c = a / 10 % 10;
        int d = a / 100;
        
        int e = d*100+b*10+c;
        Console.WriteLine(e);
    }

    public static void int17()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a / 100;
        int c = b % 10;
        Console.WriteLine(c);
    }

    public static void int18()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a / 1000;
        int c = b % 10;
        Console.WriteLine(c);
    }

    public static void int19()
    {
        int n = int.Parse(Console.ReadLine());

        int a = n / 60;
        Console.WriteLine(a);
    }
    public static void int20()
    {
        int n = int.Parse(Console.ReadLine());

        int a = n / 3600;
        Console.WriteLine(a);
    }

    public static void int21()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n % 60;
        Console.WriteLine(a);
    }

    public static void int22()
    {
        int n = int.Parse(Console.ReadLine());

        int a = n % 3600;
        Console.WriteLine(a);
    }

    public static void int23()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n % 3600;
        int b = a / 60;
        Console.WriteLine(b);
    }

    public static void int24()
    {
        int k = int.Parse(Console.ReadLine());
        
        Console.WriteLine(k%7);
    }

    public static void int25()
    {
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine((k + 3) % 7);
    }

    public static void int26()
    {
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(k % 7 + 1);
    }

    public static void int27()
    {
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine((k + 5) % 7);
    }

    public static void int28()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine((k + n - 2) % 7 + 1);
    }

    public static void int29()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        
        int d = (a/c)*(b/c); 
        int e = (a*b)-(d * c*c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        
    }

    public static void int30()
    {
        int a = int.Parse(Console.ReadLine());
        int b = (a + 99) / 100;
        Console.WriteLine(b);
    }
}