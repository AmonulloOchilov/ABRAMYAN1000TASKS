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
    //Proc8. Write a procedure AddRightDigit(D, K) that adds a digit D to the right side of
    // the decimal representation of a positive integer K (D is an input integer
    // parameter with the value in the range 0 to 9, K is an input and output integer
    // parameter). Having input an integer K and two one-digit numbers D1, D2 and
    // using two calls of this procedure, sequentially add the given digits D1, D2 to
    // the right side of the given K and output the result of each adding.
    static void AddRightDigit(int d, int k, out int s)
    {
        
        k = 10 * k + d;
        s = k;
    }

    public static void procedure8()
    {
        int k = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());
        
        AddRightDigit(d1, k, out int s);
        AddRightDigit(d2, s, out s);
        
        Console.WriteLine(s);
    }
    //Proc9. Write a procedure AddLeftDigit(D, K) that adds a digit D to the left side of
    // the decimal representation of a positive integer K (D is an input integer
    // parameter with the value in the range 0 to 9, K is an input and output integer
    // parameter). Having input an integer K and two one-digit numbers D1, D2 and
    // using two calls of this procedure, sequentially add the given digits D1, D2 to
    // the left side of the given K and output the result of each adding.
    static void AddLeftDigit(int d, int k, out int s)
    {
        int org = k;
        int nd = 0;
        while (k>0)
        {
            k /= 10;
            nd++;
        }

        s = d * (int)Math.Pow(10, nd) + org;
    }

    public static void procedure9()
    {
        int k = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());
        
        AddLeftDigit(d1, k, out int s);
        AddLeftDigit(d2, s, out s);
        
        Console.WriteLine(s);
    }
    //Proc10. Write a procedure Swap(X, Y) that exchanges the values of variables X
    // and Y (X and Y are input and output real-valued parameters). Having input
    // integers A, B, C, D and using three calls of this procedure, sequentially
    // exchange the values of the pairs A and B, C and D, B and C. Output the new
    // values of A, B, C, D.
    static void Swap(double x, double y, out double z, out double w)
    {
        z = x;
        w = y;
    }

    public static void procedure10()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        
        Swap(A, B, out double z1, out double w1);
        Swap(C, D, out double z2, out double w2);
        Swap(B, C, out double z3, out double w3);
        Console.WriteLine($"(A, B) = {z1}, {w1}");
        Console.WriteLine($"(C, D) = {z2}, {w2}");
        Console.WriteLine($"(B, C) = {z3}, {w3}");
    }
    // Proc16. Write an integer function Sign(X) that returns the following value:
    // −1, if X < 0; 0, if X = 0; 1, if X > 0
    // (X is a real-valued parameter). Using this function, evaluate an expression
    // Sign(A) + Sign(B) for given real numbers A and B. I dont know how to solve this question and u show me pls how mny ways that I can solve it in c#
    static int Sign(double x)
    {
        if (x < 0) return -1;
        else if (x == 0) return 0; 
        return 1;
    }

    public static void procedure16()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        int result = Sign(A) + Sign(B);
        Console.WriteLine(result);
    }
    //Proc31. Write a logical function IsPalindrome(K) that returns True, if the decimal
    // representation of a positive parameter K is a palindrome (i. e., it is read equally
    // both from left to right and from right to left), and False otherwise. Using this
    // function, find the amount of palindromes in a given sequence of 10 positive
    // integers.

    static bool IsPalindrome(int k)
    {
        int rn = 0;
        int on = k;
        while (k > 0)
        {
            rn = (rn * 10) + (k % 10);
            k /= 10;
        }
        return on == rn;
    }

    public static void procedure31()
    {
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (IsPalindrome(number))
            {
                count++;
            }
        }

        Console.WriteLine("Number of palindromes " + count);
    }
    //Proc32. Write a real-valued function DegToRad(D) that converts the angle value D
    // in degrees into the one in radians (D is a real number, 0 ≤ D < 360). Note that
    // 180° = π radians and use 3.14 for a value of π. Using this function, convert five
    // given angles from degrees into radians.
    static double DegToRad(double d)
    {
        if (d < 0 || d >= 360) 
        {
            Console.WriteLine("U have to choose 0 <= D < 360");
            return double.NaN;
        }
        return d * (3.14 / 180);
    }

    public static void procedure32()
    {
        for (int i = 0; i < 5; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double radians = DegToRad(x);
            Console.WriteLine(radians);
        }
    }
    //Proc33. Write a real-valued function RadToDeg(R) that converts the angle value R
    // in radians into the one in degrees (R is a real number, 0 ≤ R < 2·π). Note that
    // 180° = π radians and use 3.14 for a value of π. Using this function, convert five
    // given angles from radians into degrees.
    static double RadToDeg(double r)
    {
        if (r < 0 || r > 2 * 3.14) 
        {
            return double.NaN;
        }
        return r * (180.0 / 3.14);
    }

    public static void procedure33()
    {
        for (int i = 0; i < 5; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double degrees = RadToDeg(x);
            Console.WriteLine(degrees);
        }
    }
    //Proc34. Write a real-valued function Fact(N) that returns a factorial of a positive
    // integer N: N! = 1·2·…·N (the real return type allows to avoid the integer
    // overflow during the calculation of the factorials for large values of the
    // parameter N). Using this function, find the factorials of five given integers.
    static double fact(int n)
    {
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static void procedure34()
    {
        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            double factorial = fact(x);
            Console.WriteLine(factorial);
        }
    }
    //Proc37. Write a real-valued function Power1(A, B) that returns the power AB
    // calculated by the formula AB
    // = exp(B·ln(A)) (A and B are real-valued
    // parameters). In the case of zero-valued or negative parameter A the function
    // returns 0. Having input real numbers P, A, B, C and using this function, find
    // the powers AP
    // , BP
    // , CP

    static double Power(double A, double B)
    {
        if (A <= 0) return 0;
        return Math.Exp(B*Math.Log(A));
        
    }

    public static void procedure37()
    {
        double p = double.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double ap = Power(a, p);
        double bp = Power(b, p);
        double cp = Power(c, p);
        Console.WriteLine($"a^p = {ap}");
        Console.WriteLine($"b^p = {bp}");
        Console.WriteLine($"c^p = {cp}");
        
    }
    
}