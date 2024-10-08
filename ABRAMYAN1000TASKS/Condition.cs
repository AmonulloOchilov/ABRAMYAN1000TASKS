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
    //Given three real numbers, output the sum of two largest values.
    public static void if15()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        double lar, slar;

        if (a >= b && a >= c) 
        {
            lar = a;
            slar = Math.Max(b, c);
        }else if (b >= a && b >= c) 
        {
            lar = b;
            slar = Math.Min(c, a);
        }
        else
        {
            lar = c;
            slar = Math.Max(a, b);
        }

        Console.WriteLine(lar + slar);
    }
    //The values of three real variables A, B, C are given. If the values are in
    // ascending order then double them, otherwise replace the value of each variable
    // by its opposite value. Output the new values of the variables A, B, C.
    public static void if16()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        if (a < b && b < c)
        {
            a *= 2;
            b *= 2;
            c *= 2;
        }
        else
        {
            a = -a;
            b = -b;
            c = -c;
        }
        Console.WriteLine(a +"\n" + b + "\n" + c);
    }
    //The values of three real variables A, B, C are given. If the values are in
    // ascending or descending order then double them, otherwise replace the value
    // of each variable by its opposite value. Output the new values of the
    // variables A, B, C.
    public static void if17()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        if (a < b && b < c || a > b && b > c)
        {
            a *= 2;
            b *= 2;
            c *= 2;
        }
        else
        {
            a = -a;
            b = -b;
            c = -c;
            
        }
        
        Console.WriteLine(a +"\n" + b + "\n" + c);
    }
    //Three integers are given. One of them differs from two other equal integers.
    // Output the order number of the integer that differs from the others.
    public static void if18()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        double differ = 0;
        if (a==b && a != c)
        {
            differ = 3;
        }else if (a == c && a != b) 
        {
            differ = 2;
        }
        else
        {
            differ = 1;
        }
        Console.WriteLine(differ);
    }
    //Four integers are given. One of them differs from three other equal integers.
    // Output the order number of the integer that differs from the others.
    public static void if19()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int differ = 0;

        if (a == b && b == c && c != d) 
        {
            differ = 4;
        }else if (a == b && b != c &&  b== d)
        {
            differ = 3;
        }else if (a != b && a == c && c == d)
        {
            differ = 2;
        }
        else if (a != b && b == c && c == d) 
        {
            differ = 1;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        Console.WriteLine(differ);
    }
    //Three points A, B, C on the real axis are given. Determine whether B or C is
    // closer to A. Output the nearest point and its distance from A.
    public static void if20()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        
        double distab = Math.Abs(b - a);
        double distac = Math.Abs(c - a);
        if (distab < distac)
        {
            Console.WriteLine("Point b is close to a. Dist: " + distab);
        }else if (distab > distac) 
        {
            Console.WriteLine("Point c is close to a. Dist: " + distac);
        }
        else
        {
            Console.WriteLine("Point b && c are equidistant from a. Dist: " + distab);
        }
    }
    //Integer coordinates of a point in the coordinate plane are given. If the point
    // coincides with the origin of coordinates then output 0, otherwise if the point
    //lies on the x-axis or y-axis then output 1 or 2 respectively. If the point does not
    // lie on the coordinate axes then output 3.
    public static void if21()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if (x==0 && y==0)
        {
            Console.WriteLine("0");
        }else if (y == 0) 
        {
            Console.WriteLine("1");
        }else if (x == 0) 
        {
            Console.WriteLine("2");
        }
        else
        {
            Console.WriteLine("3");
        }
        
    }
    //Given coordinates of a point that does not lie on the coordinate axes, find the
    // number of a coordinate quarter containing the point.
    public static void if22()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x == 0 && y == 0) 
        {
            Console.WriteLine("One of the coordinates");
        }
        else
        {
            if (x > 0 && y > 0) 
            {
                Console.WriteLine("quad 1");
            }else if (x < 0 && y > 0) 
            {
                Console.WriteLine("quad 2");
            }else if (x < 0 && y < 0) 
            {
                Console.WriteLine("quad 3");
            }else if (x > 0 && y < 0) 
            {
                Console.WriteLine("quad 4");
            }
        }
    }
    //Given integer coordinates of three vertices of a rectangle whose sides are
    // parallel to coordinate axes, find the coordinates of the fourth vertex of the
    // rectangle.
    public static void if23()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = x1;
        if (x1 == x2)
        {
            x4 = x3;
        }else if (x1 == x3)
        {
            x4 = x2;
        } 
        int y4 = y1;
        if (y1 == y2)
        {
            y4 = y3;
        }else if (y1 == y3)
        {
            y4 = y2;
        }
        Console.WriteLine($"The coordinates of the fourth vertex are: ({x4}, {y4})");


    }
    //Given a real independent variable x, find the value of a real function f defined
    // as:
    // f(x) = 2·sin(x), if x > 0,
    // 6 − x, if x ≤ 0.
    public static void if24()
    {
        var x = double.Parse(Console.ReadLine());
        double a;
        
        if (x > 0)
        {
            a = 2 * Math.Sin(x);
        }
        else
        {
            a = 6 - x;
        }
        Console.WriteLine(a);
        
    }
    //Given an integer independent variable x, find the value of an integer function f
    // defined as:
    // f(x) = 2·x, if x < −2 or x > 2,
    // −3·x otherwise.
    public static void if25()
    {
        int x = int.Parse(Console.ReadLine());
        double a;
        if (x < -2 || x > 2)
        {
            a = 2 * x;
        }
        else
        {
            a = -3 * x;
        }
        Console.WriteLine(a);
    }
    //Given a real independent variable x, find the value of a real function f defined
    // as:
    // −x, if x ≤ 0,
    // f(x) = x
    // 2
    // , if 0 < x < 2,
    // 4, if x ≥ 2.
    public static void if26()
    {
        var x =double.Parse(Console.ReadLine());
        double a = 0;
        if (x <= 0)
        {
            a = -x;
        }else if (0 < x && x < 2)
        {
            a = x * x;
        }
        else
        {
            a = 4;
        }
        Console.WriteLine(a);
        
    }
    //Given a real independent variable x, find the value of an integer function f
    // defined as:
    // 0, if x < 0,
    // f(x) = 1, if x belongs to [0, 1), [2, 3), …,
    // −1, if x belongs to [1, 2), [3, 4), … .
    public static void if27()
    {
        var x =double.Parse(Console.ReadLine());
        int floorx = (int)Math.Floor(x);
        int result;
        if (x < 0)
        {
            result = 0;
        }else if (floorx % 2 == 0)
        {
            result = 1;
        }
        else
        {
            result = -1;
        }
        Console.WriteLine(result);
    }
    //Given a number of year (as a positive integer), find the amount of days in the
    // year. Note that the length of year is 365 days for an ordinary year and 366 days
    // for a leap year. A leap year is every year whose number is divisible by 4,
    // as 1980, except centenary years that are not divisible by 400 (for example,
    // 1300 and 1900 are ordinary years, 1200 and 2000 are leap years).
    public static void if28()
    {
        int x = int.Parse(Console.ReadLine());
        int d;
        if ((x % 4 == 0 && x % 100 != 0) || (x % 400 == 0))
        {
            d = 366;
        }
        else
        {
            d = 365;
        }
        Console.WriteLine(x);
        Console.WriteLine(d);
    }
    //Given an integer, output its description string as: ―negative even number‖
    // ―zero
    // ,
    // number‖
    // ,
    // ―positive odd number‖, etc.
    public static void if29()
    {
        int x = int.Parse(Console.ReadLine());
        if (x < 0)
        {
            if (x % 2 == 0) 
            {
                Console.WriteLine("Neg even num");
            }
            else
            {
                Console.WriteLine("Neg odd num");
            }
        }else if (x == 0)
        {
            Console.WriteLine("Zero");
        }
        else  
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("Pos even num");
            }
            else
            {
                Console.WriteLine("Pos odd num");
            }
        }
    }
    //An integer in the range 1 to 999 is given. Output its description string as: ―two-
    // digit even number‖
    // ,
    // ―three-digit odd number‖, etc.
    public static void if30()
    {
        int x = int.Parse(Console.ReadLine());
        if (x > 9 && x<100 && x % 2 == 0) 
        {
            Console.WriteLine("2 dig even num");
        }
        else if(x > 9 && x<100 && x % 2 != 0)
        {
            Console.WriteLine("2 dig odd num");
        }

        if (x>99 && x<1000 && x % 2 == 0)
        {
            Console.WriteLine("3 dig even num");
        }
        else if(x>99 && x<1000 && x % 2 != 0)
        {
            Console.WriteLine("3 dig odd num");
        }
        else if (x > 0 && x < 10) 
        {
            Console.WriteLine("Your input is 1 dig");
        }
    }
}