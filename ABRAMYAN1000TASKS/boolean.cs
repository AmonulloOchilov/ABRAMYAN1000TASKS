namespace ABRAMYAN1000TASKS;

public class boolean
{
    
    //Given integer A, verify the following proposition: ―The number A is
    // positive‖
    public static void bool1()
    {
        var a = double.Parse(Console.ReadLine());

        bool b = a > 0;
        Console.WriteLine(b);
    }
    //Given integer A, verify the following proposition: ―The number A is
    // odd‖
    

    public static void bool2()
    {
        var a = double.Parse(Console.ReadLine());
        
        bool b = a % 2 != 0;
        Console.WriteLine(b);
    }
    //Given integer A, verify the following proposition: ―The number A is
    // even‖
    public static void bool3()
    {
        var a = double.Parse(Console.ReadLine());
        
        bool b = a % 2 == 0;
        Console.WriteLine(b);
    }
    
    //Given two integers A and B, verify the following proposition: ―The
    // inequalities A > 2 and B ≤ 3 both are fulfilled‖

    public static void bool4()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());

        bool c = a > 2;
        bool d = b <= 3;
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
    //Given two integers A and B, verify the following proposition: ―The
    // inequality A ≥ 0 is fulfilled or the inequality B < −2 is fulfilled‖

    public static void bool5()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        bool c = a >= 0;
        bool d = b < -2;
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
    //Given three integers A, B, C, verify the following proposition: ―The
    // double inequality A < B < C is fulfilled‖
    
    public static void bool6()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        bool d = a < b;
        bool e = b < c;
        Console.WriteLine(e);
    }
    //Given three integers A, B, C, verify the following proposition: ―The
    // number B is between A and C‖

    public static void bool7()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        bool d = a < b && b < c;
        Console.WriteLine(d);
    }
    
    //Given two integers A and B, verify the following proposition: ―Each of
    // the numbers A and B is odd‖

    public static void bool8()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        bool c = a % 2 != 0;
        bool d = b % 2 != 0;
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
    //Given two integers A and B, verify the following proposition: ―At least
    // one of the numbers A and B is odd‖

    public static void bool9()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        bool c = a % 2 != 0 || b % 2 != 0;
        Console.WriteLine(c);
    }
    
    //Given two integers A and B, verify the following proposition: ―Exactly
    // one of the numbers A and B is odd‖
    public static void bool10()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        bool c = (a % 2 != 0) != (b % 2 != 0);
        Console.WriteLine(c);
    }

    //Given two integers A and B, verify the following proposition: ―The
    // numbers A and B have equal parity‖
    public static void bool11()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        bool c = (a % 2 == 0 && b % 2 == 0) || (a % 2 != 0 && b % 2 != 0);
        Console.WriteLine(c);
    }
    
    //Given three integers A, B, C, verify the following proposition: ―Each of
    // the numbers A, B, C is positive‖

    public static void bool12()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());
        
        bool d = a>0 && b>0 && c>0;
        Console.WriteLine(d);
    }
    //Given three integers A, B, C, verify the following proposition: ―At least
    // one of the numbers A, B, C is positive
    public static void bool13()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        bool d = a > 0 || b > 0 || c > 0;
        Console.WriteLine(d);
    }
    //Given three integers A, B, C, verify the following proposition: ―Exactly
    // one of the numbers A, B, C is positive
    public static void bool14()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());
        
        bool d = (a > 0 && b <= 0 && c <= 0) || (b > 0 && a <= 0 && c <= 0) || (c > 0 && a <= 0 && b <= 0);
        Console.WriteLine(d);
    }
    //Given three integers A, B, C, verify the following proposition: ―Exactly
    // two of the numbers A, B, C are positive‖
    public static void bool15()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());
        
        bool d = (a > 0 && b > 0 && c <= 0) || (b > 0 && a <= 0 && c > 0) || (c > 0 && a > 0 && b <= 0);
        Console.WriteLine(d);
    }
    //Given a positive integer, verify the following proposition: ―The integer
    // is a two-digit even number‖
    public static void bool16()
    {
        var a = int.Parse(Console.ReadLine());
        bool b = a > 9 && a < 100 && a % 2 == 0;
        Console.WriteLine(b);
    }
    //Given a positive integer, verify the following proposition: ―The integer
    // is a three-digit odd number
    public static void bool17()
    {
        var a = int.Parse(Console.ReadLine());
        bool b = a > 99 && a < 1000 && a % 2 != 0;
        Console.WriteLine(b);
    }
    //Verify the following proposition: ―Among three given integers there is
    // at least one pair of equal ones‖
    public static void bool18()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        bool d = (a == b) || (b == c) || (c == a);
        Console.WriteLine(d);
    }
    //Verify the following proposition: ―Among three given integers there is
    // at least one pair of opposite ones
    public static void bool19()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());
        
        bool d = (a == -b) || (b == -c) || (c == -a) || (a == -c);
        Console.WriteLine(d);
    }
    
    //Given a three-digit integer, verify the following proposition: ―All digits
    // of the number are different‖
    public static void bool20()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());
        
        bool d = (a != b) && (b != c) && (c != a);
        Console.WriteLine(d);
    }
    //Given a three-digit integer, verify the following proposition: ―All digits
    // of the number are in ascending order‖
    public static void bool21()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        bool d = (a <= b && b <= c);
        Console.WriteLine(d);
    }
    //Given a three-digit integer, verify the following proposition: ―All digits
    // of the number are in ascending or descending order‖
    public static void bool22()
    {
        var a = int.Parse(Console.ReadLine());

        int h = a / 100; //hundreds
        int t = (a / 10) % 10; //tens
        int o = a % 10; //ones

        bool ac = (h < t && t < o);
        bool dc = (h > t && t > 0);
        Console.WriteLine(ac || dc);
    }
    //Given a four-digit integer, verify the following proposition: ―The
    // number is read equally both from left to right and from right to left
    public static void bool23()
    {
        var a = int.Parse(Console.ReadLine());

        int th = a / 1000; //thousands
        int h = (a / 100) % 10; //hundreds
        int t = (a / 10) % 10; //tens
        int o = a % 10; //ones
        
        bool eq = (th == o && h == t);
        Console.WriteLine(eq);
    }
    //Three real numbers A, B, C are given (A is not equal to 0). By means of
    // a discriminant D = B2
    // − 4·A·C, verify the following proposition: ―The
    // quadratic equation A·x
    // 2 + B·x + C = 0 has real roots‖
    public static void bool24()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        int d = b * b - 4 * a * c;
        bool f = d >= 0;
        Console.WriteLine(f);
    }
    //Given two real numbers x, y, verify the following proposition: ―The
    // point with coordinates (x, y) is in the second coordinate quarter‖
    public static void bool25()
    {
        var x = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        bool f = (x < 0) && (y > 0);
        Console.WriteLine(f);
    }
}