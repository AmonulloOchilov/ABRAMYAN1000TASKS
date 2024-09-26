namespace ABRAMYAN1000TASKS;

public class Beginner
{
    //Given the side a of a square, find the perimeter P of the square: P = 4·a.
    public static void B1()
    {
        var a = double.Parse(Console.ReadLine());
        
        Console.WriteLine(a * 4);
    }
    // Given the side a of a square, find the area S of the square: S = a2
    public static void B2()
    {
        var a = double.Parse(Console.ReadLine());
        Console.WriteLine(a * a);
    }
    //The sides a and b of a rectangle are given. Find the area S = a·b and the
    // perimeter P = 2·(a + b) of the rectangle.
    public static void B3()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        Console.WriteLine("Area = " + a * b);
        
        Console.WriteLine("Perimetr = "+(a + b)*2);
    }
        //Given the diameter d of a circle, find the length L of the circle: L = π·d. Use
        // 3.14 for a value of π.
    public static void B4()
    {
        var d = double.Parse(Console.ReadLine());
        float p = 3.14F;
        Console.WriteLine("Length = " + p * d);
        
    }
    //Given the edge a of a cube, find the volume V = a
    // 3 and the surface
    // area S = 6·a
    // 2 of the cube.
    public static void B5()
    {
        var a = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Volume = " + a * a);
        Console.WriteLine("Area = " + 6 * a);
    }
    //The edges a, b, c of a right parallelepiped are given. Find the volume
    // V = a·b·c and the surface area S = 2·(a·b + b·c + a·c) of the right parallelepiped.
    public static void B6()
    {
        
    var a = double.Parse(Console.ReadLine());    
    var b = double.Parse(Console.ReadLine());
    var c = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Volume = " + a * b * c);
    Console.WriteLine("Area = " + 2 * (a *b + b * c + a * b));
    }

    public static void B7()
    {
        var r = double.Parse(Console.ReadLine());
        float p = 3.14F;
        Console.WriteLine("Length = " + 2*p*r);
        Console.WriteLine("Area = " + (p * (r * r)));
        
        
    }

    public static void B8()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        Console.WriteLine("Average = " + (a + b) / a);
    }

    public static void B9()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        Console.WriteLine("Sqrt = " + Math.Sqrt(a * b));
    }

    public static void B10()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        Console.WriteLine("Sum = " + (a + b));
        Console.WriteLine("Sub = " + (a - b));
        Console.WriteLine("Div = " + (a / b));
        Console.WriteLine("SuOfSq = " + (a * a + b * b));
    }

    public static void B12()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        double c = Math.Sqrt(a*a + b*b);
        Console.WriteLine("C = " + c);
        double p = a + b + c;
        Console.WriteLine("P = " + p);


    }

    public static void B13()
    {
        var r1 = double.Parse(Console.ReadLine());
        var r2 = double.Parse(Console.ReadLine());
        double p = 3.14;
        double s1 = p * (r1 * r1);
        Console.WriteLine(s1);
        double s2 = p * (r2 * r2);
        Console.WriteLine(s2);
        double s3 = s1 - s2;
        Console.WriteLine(s3);
    }

    public static void B14()
    {
        var r = double.Parse(Console.ReadLine());
        double p = 3.14;
        Console.WriteLine(2 * p * r);
        Console.WriteLine(p * r * r);
    }

    public static void B15()
    {
        var s = double.Parse(Console.ReadLine());
        float p = 3.14F;
        double r = Math.Sqrt(s/p);
        double d = 2 * r;
        double l = 2 * p * r;
        Console.WriteLine(l);
        Console.WriteLine(d);
    }

    public static void B16()
    {
        var x1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("distance = " + Math.Abs(x2 - x1));
    }

    public static void B17()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Abs(c - a));
        Console.WriteLine(Math.Abs(c - b));
        Console.WriteLine(Math.Abs(a + b));
    }

    public static void B18()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Abs(c - a));
        Console.WriteLine(Math.Abs(b - c));
        Console.WriteLine(Math.Abs(a * b));
    }

    public static void B19()
    {
        var x1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        
        
        double a = Math.Abs(x2 - x1);
        double b = Math.Abs(y2 - y1);
        double p = Math.Abs(2 * (a + b));
        double s = Math.Abs(a * b);
        Console.WriteLine(p);
        Console.WriteLine(s);
    }

    public static void B20()
    {
        var x1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        
        double p = Math.Sqrt(Math.Abs((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1)));
        Console.WriteLine(p);
    }

    public static void B21()
    {
        var x1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var x3 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var y3 = double.Parse(Console.ReadLine());
        
        double a = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
        double b = Math.Sqrt((x3 - x1)*(x3 - x1) + (y3 - y1)*(y3 - y1));
        double c = Math.Sqrt((x3 - x2)*(x3 - x2) + (y3 - y2)*(y3 - y2));
        double p = a+b+c;
        double HalfPer = (a+b+c)/2;
        double S = Math.Sqrt(HalfPer*(HalfPer - a)*(HalfPer - b)*(HalfPer - c));
        
        Console.WriteLine(p);
        Console.WriteLine(HalfPer);
        Console.WriteLine(S);
    }

    public static void B22()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());

        double c = a;
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);

    }

    public static void B23()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        double d = a;

        a = b;
        b = c;
        c = d;
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }

    public static void B24()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        double d = a;

        a = c;
        c = b;
        b = d;
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }

    public static void B25()
    {
        var x = double.Parse(Console.ReadLine());
        
        double y = (3 * Math.Pow(x, 6) - 6* Math.Pow(x, 2) - 7);
        Console.WriteLine(y);
    }

    public static void B26()
    {
        var x = double.Parse(Console.ReadLine());

        double y = 4 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 3) + 2;
        Console.WriteLine(y);
    }

    public static void B27()
    {
        var a = double.Parse(Console.ReadLine());
        double b, c, d;
        b = a * a;
        c = a * Math.Pow(a, 3);
        d = a * Math.Pow(a, 7);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }

    public static void B28()
    {
        var a = double.Parse(Console.ReadLine());
        double b, c, d, e, f;
            b = a * a;
        c = a * a * a;
        d = Math.Pow(a, 5);
        e = Math.Pow(a, 10);
        f = Math.Pow(a, 15);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
    }

    public static void B29()
    {
        var a = double.Parse(Console.ReadLine());
        double p = 3.14;
        double r = a * (p / 180);
        Console.WriteLine(r);
    }

    public static void B30()
    {
        var a = double.Parse(Console.ReadLine());
        double p = 3.14;
        double r = a * (180 / p);
        Console.WriteLine(r);
    }

    public static void B31()
    {
        var tf = double.Parse(Console.ReadLine());
        double tc = (tf - 32) * 5 / 9;
        Console.WriteLine(tc);
    }

    public static void B32()
    {
        var tc = double.Parse(Console.ReadLine());
        double tf = (tc * 9/5) + 32;
        Console.WriteLine(tf);
    }

    public static void B33()
    {
        var x = double.Parse(Console.ReadLine());
        var a = double.Parse(Console.ReadLine());
        var Y = double.Parse(Console.ReadLine());
        
        double y = a / x;
        double t = Y * y;
        Console.WriteLine(y);
        Console.WriteLine(t);
    }

    public static void B34()
    {
        var x = double.Parse(Console.ReadLine());
        var a = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        
        double c = a / x;
        double d = b / y;
        double f = c / d;
        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(c);
    }

    public static void B35()
    {
        var v = double.Parse(Console.ReadLine());
        var u = double.Parse(Console.ReadLine());
        var t1 = double.Parse(Console.ReadLine());
        var t2 = double.Parse(Console.ReadLine());
        double s = t1 * (v + u) + t2*(v - u);
        Console.WriteLine(s);
    }

    public static void B36()
    {
        var v1 = double.Parse(Console.ReadLine());
        var v2 = double.Parse(Console.ReadLine());
        var t = double.Parse(Console.ReadLine());
        double s = t * v1 + t * v2;
        Console.WriteLine(s);
    }

    public static void B37()
    {
        var v1 = double.Parse(Console.ReadLine());
        var v2 = double.Parse(Console.ReadLine());
        var s = double.Parse(Console.ReadLine());
        var t = double.Parse(Console.ReadLine());
        double a = Math.Abs(s - t * (v1 + v2));
        Console.WriteLine(a);
    }

    public static void B38()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        double x = -b / a;
        Console.WriteLine(x);
    }

    public static void B39()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        
        double d = b * b - 4 * a * c;
        double x1 = (-b + Math.Sqrt(d))/(2*a);
        double x2 = (-b - Math.Sqrt(d))/(2*a);
        
        Console.WriteLine(x1);
        Console.WriteLine(x2);
    }

    public static void B40()
    {
        var a1 = double.Parse(Console.ReadLine());
        var b1 = double.Parse(Console.ReadLine()); 
        var c1 = double.Parse(Console.ReadLine());
        var a2 = double.Parse(Console.ReadLine());
        var b2 = double.Parse(Console.ReadLine());
        var c2 = double.Parse(Console.ReadLine());
        
        double d = a1*b2 - a2*b1;
        double x = (c1*b2 - c2*b1)/d;
        double y = (a1*c2 - a2*c1)/d;
        Console.WriteLine(y);
        Console.WriteLine(x);
    }

}