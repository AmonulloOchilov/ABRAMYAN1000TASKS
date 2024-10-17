namespace ABRAMYAN1000TASKS;

public class procedure
{
    //Proc1. Write a procedure PowerA3(A, B) that computes the third degree of a real
    // number A and assigns the result to a real variable B (A is an input parameter,
    // B is an output parameter). Using this procedure, find the third degree of five
    // given real numbers.
    static void PowerA3(double A, out double B)
         {
             B = Math.Pow(A, 3);
         }
    public static void procedure1()
    {
        double A1 = double.Parse(Console.ReadLine());
        double A2 = double.Parse(Console.ReadLine());
        double A3 = double.Parse(Console.ReadLine());
        double A4 = double.Parse(Console.ReadLine());
        double A5 = double.Parse(Console.ReadLine());
        
        PowerA3(A1, out double B1);
        PowerA3(A2, out double B2);
        PowerA3(A3, out double B3);
        PowerA3(A4, out double B4);
        PowerA3(A5, out double B5);
        
        Console.WriteLine($"The cube of {A1} is {B1}");
        Console.WriteLine($"The cube of {A2} is {B2}");
        Console.WriteLine($"The cube of {A3} is {B3}");
        Console.WriteLine($"The cube of {A4} is {B4}");
        Console.WriteLine($"The cube of {A5} is {B5}");
        
    }
    //Proc2. Write a procedure PowerA234(A, B, C, D) that computes the second, the
    // third, and the fourth degrees of a real number A and assigns the results to real
    // variables B, C, and D respectively (A is an input parameter, B, C, D are output
    // parameters). Using this procedure, find the second, the third, and the fourth
    // degrees of five given real numbers.

    static void PowerA234(double A, out double B, out double C, out double D)
    {
        B = Math.Pow(A, 2);
        C = Math.Pow(A, 3);
        D = Math.Pow(A, 4);
    }

    public static void procedure2()
    {
        double A1 = double.Parse(Console.ReadLine());
        double A2 = double.Parse(Console.ReadLine());
        double A3 = double.Parse(Console.ReadLine());
        double A4 = double.Parse(Console.ReadLine());
        double A5 = double.Parse(Console.ReadLine());

        PowerA234(A1, out double B, out double C, out double D);
        PowerA234(A2, out B, out C, out D);
        PowerA234(A3, out B, out C, out D);
        PowerA234(A4, out B, out C, out D);
        PowerA234(A5, out B, out C, out D);
        
        Console.WriteLine($"The second, cube, fourth of {A1} is {B} and {C} and {D}");
        Console.WriteLine($"The second, cube, fourth of {A2} is {B} and {C} and {D}");
        Console.WriteLine($"The second, cube, fourth of {A3} is {B} and {C} and {D}");
        Console.WriteLine($"The second, cube, fourth of {A4} is {B} and {C} and {D}");
        Console.WriteLine($"The second, cube, fourth of {A5} is {B} and {C} and {D}");
        
    }
    //Proc3. Write a procedure Mean(X, Y, AMean, GMean) that computes the
    // arithmetical mean AMean = (X+Y)/2 and the geometrical mean
    // GMean = (X·Y)1/2 of two positive numbers X and Y (X and Y are input
    // parameters, AMean and GMean are output parameters; all parameters are the
    // real-valued ones). Using this procedure, find the arithmetical mean and the
    // geometrical mean of pairs (A, B), (A, C), (A, D) provided that real
    // numbers A, B, C, D are given.

    static void Mean(double x, double y, out double AMean, out double GMean)
    {
        AMean = (x + y) / 2;
        GMean = Math.Sqrt(x * y);
    }

    public static void procedure3()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double D = double.Parse(Console.ReadLine());
        
        Mean(A, B,  out double AMean0, out double GMean0);
        Mean(A, C,  out double AMean1, out double GMean1);
        Mean(A, D,  out double AMean2, out double GMean2);
        
        Console.WriteLine($"(A, B) = {AMean0}, {GMean0}");
        Console.WriteLine($"(A, C) = {AMean1}, {GMean1}");
        Console.WriteLine($"(A, D) = {AMean2}, {GMean2}");
        
    }
    //Proc4. Write a procedure TrianglePS(a, P, S) that computes the perimeter P = 3·a
    // and the area S = a
    // 2·(3)1/2/4 of an equilateral triangle with the side a (a is an
    // input parameter, P and S are output parameters, all parameters are the real-
    // valued ones). Using this procedure, find the perimeters and the areas of three
    // triangles with the given lengths of the sides.

    static void Triangle(double a, out double P, out double S)
    {
        P = 3 * a;
        S = (a * a * Math.Sqrt(3)) / 4;
    }

    public static void procedure4()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        
        Triangle(A, out double P1, out double S1);
        Triangle(B, out double P2, out double S2);
        Triangle(C, out double P3, out double S3);
        
        Console.WriteLine($"Perimetr = {P1}, Area = {S1}");
        Console.WriteLine($"Perimetr = {P2}, Area = {S2}");
        Console.WriteLine($"Perimetr = {P3}, Area = {S3}");
        
    }
    //Proc5. Write a procedure RectPS(x1, y1, x2, y2, P, S) that computes the perimeter P
    // and the area S of a rectangle whose opposite vertices have coordinates (x1, y1)
    // and (x2, y2) and sides are parallel to coordinate axes (x1, y1, x2, y2 are input
    // parameters, P and S are output parameters, all parameters are the real-valued
    // ones). Using this procedure, find the perimeters and the areas of three
    // rectangles with the given opposite vertices.

    static void ReactPs(double x1, double y1, double x2, double y2, out double p, out double s)
    {
        p = 2 * (Math.Abs(x2 - x1) + Math.Abs(y2 - y1));
        s = (Math.Abs(x2 - x1) * Math.Abs(y2 - y1));
    }

    public static void procedure5()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double D = double.Parse(Console.ReadLine());
        ReactPs(A, B, C, D, out double p1, out double s1);
        Console.WriteLine($"Perimeter 1: {p1}, Area 1: {s1}");
        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());
        C = double.Parse(Console.ReadLine());
        D = double.Parse(Console.ReadLine());
        ReactPs(A, B, C, D, out double p2, out double s2);
        Console.WriteLine($"Perimeter 2: {p2}, Area 2: {s2}");
        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());
        C = double.Parse(Console.ReadLine());
        D = double.Parse(Console.ReadLine());
        ReactPs(A, B, C, D, out double p3, out double s3);
        
        Console.WriteLine($"Perimeter 3: {p3}, Area 3: {s3}");
    }
    //Proc6. Write a procedure DigitCountSum(K, C, S) that finds the amount C of digits
    // in the decimal representation of a positive integer K and also the sum S of its
    // digits (K is an input parameter, C and S are output parameters, all parameters
    // are the integer ones). Using this procedure, find the amount and the sum of
    // digits for each of five given integers.
    static void DigitCountSum(int k, out double c, out double s)
    {
        c = 0;
        s = 0;
        int count = k;
        while (count > 0)
        {
            s += count % 10;
            count /= 10;
            c++;
        }
    }

    public static void procedure6()
    {
        int k = int.Parse(Console.ReadLine());
        int k1 = int.Parse(Console.ReadLine());
        int k2 = int.Parse(Console.ReadLine());
        int k3 = int.Parse(Console.ReadLine());
        int k4 = int.Parse(Console.ReadLine());
        
        DigitCountSum(k, out double c0, out double s0);
        DigitCountSum(k1, out double c1, out double s1);
        DigitCountSum(k2, out double c2, out double s2);
        DigitCountSum(k3, out double c3, out double s3);
        DigitCountSum(k4, out double c4, out double s4);
        Console.WriteLine($"For number {k}: Digit Count = {c0}, Digit Sum = {s0}");
        Console.WriteLine($"For number {k1}: Digit Count = {c1}, Digit Sum = {s1}");
        Console.WriteLine($"For number {k2}: Digit Count = {c2}, Digit Sum = {s2}");
        Console.WriteLine($"For number {k3}: Digit Count = {c3}, Digit Sum = {s3}");
        Console.WriteLine($"For number {k4}: Digit Count = {c4}, Digit Sum = {s4}");
    }
    //Proc7. Write a procedure InvDigits(K) that inverts the order of digits of a positive
    // integer K (K is an input and output integer parameter). Using this procedure,
    // invert the order of digits for each of five given integers.
    static void InvDigits(int k, out int k1)
    {
        int s = 0;
        while (k > 0)
        {
           int digit = k % 10;
           s = s * 10 + digit;
           k /= 10;
           
        }
        k1 = s;
    }

    public static void procedure7()
    {
        for (int i = 0; i < 5; i++)
        {
            int a = int.Parse(Console.ReadLine());
            InvDigits(a, out int k1);
            Console.WriteLine($"Original {a}, Inverted {k1}");
        }
    }
}