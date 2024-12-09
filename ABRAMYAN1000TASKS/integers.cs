namespace ABRAMYAN1000TASKS;

public class integers
{
    //Integer1. A distance L is given in centimeters. Find the amount of full meters of this
    // distance (1 m = 1000 cm). Use the operator of integer division.
    public static void int1()
    {
        int l = int.Parse(Console.ReadLine());
        int m = l / 100;
        Console.WriteLine(m);

    }
    //Integer2. A weight M is given in kilograms. Find the amount of full tons of this
    // weight (1 ton = 1000 kg). Use the operator of integer division.
    public static void int2()
    {
        int m = int.Parse(Console.ReadLine());
        int t = m / 1000;
        Console.WriteLine(t);
    }
    //Integer3. A file size is given in bytes. Find the amount of full Kbytes of this size
    // (1 K = 1024 bytes). Use the operator of integer division.
    public static void int3()
    {
        int b = int.Parse(Console.ReadLine());
        int k = b / 1024;
        Console.WriteLine(k);
    }
    //Integer4. Two positive integers A and B are given (A > B). Segment of length A
    // contains the greatest possible amount of inside segments of length B (without
    // overlaps). Find the amount of segments B placed on the segment A. Use the
    // operator of integer division.
    public static void int4()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int s = a / b;
        Console.WriteLine(s);
    }
    //Integer5. Two positive integers A and B are given (A > B). Segment of length A
    // contains the greatest possible amount of inside segments of length B (without
    // overlaps). Find the length of unused part of the segment A. Use the operator of
    // taking the remainder after integer division.
    public static void int5()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int s = a % b;
        Console.WriteLine(s);
    }
    //Integer6. A two-digit integer is given. Output its left digit (a tens digit) and then its
    // right digit (a ones digit). Use the operator of integer division for obtaining the
    // tens digit and the operator of taking remainder for obtaining the ones digit.
    public static void int6()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a / 10;
        int c = a % 10;
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
    //Integer7. A two-digit integer is given. Find the sum and the product of its digits.
    public static void int7()
    {
        int a = int.Parse(Console.ReadLine());
        int e = a / 10;
        int f = a % 10;
        int c = e + f;
        int d = e * f;
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
    //Integer8. A two-digit integer is given. Output an integer obtained from the given one
    // by exchange of its digits.
    public static void int8()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a / 10;
        int c = a % 10;

        int d = c * 10 + b;
        Console.WriteLine(d);
    }
    //Integer9. A three-digit integer is given. Using one operator of integer division find
    // first digit of the given integer (a hundreds digit).
    public static void int9()
    {
        int a = int.Parse(Console.ReadLine());

        int b = a / 100;
        Console.WriteLine(b);
    }
    //Integer10. A three-digit integer is given. Output its last digit (a ones digit) and then
    // its middle digit (a tens digit).
    public static void int10()
    {
        int a = int.Parse(Console.ReadLine());
        int c = a % 100/10;
        int b = a % 10;
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
    //Integer11. A three-digit integer is given. Find the sum and the product of its digits.
    public static void int11()
    {
        int a = int.Parse(Console.ReadLine());
        
        int e = a / 100;
        int f = a % 100 / 10;
        int c = a % 10;
        int d = e + f + c;
        int b = e * f * c;
        Console.WriteLine(d);
        Console.WriteLine(b);
    }
    //Integer12. A three-digit integer is given. Output an integer obtained from the given
    // one by reading it from right to left.
    public static void int12()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a % 10;
        int c = a / 10 % 10;
        int d = a / 100;
        int e = b * 100 + c * 10 + d * 1;
        Console.WriteLine(e);
    }
    //Integer13. A three-digit integer is given. Output an integer obtained from the given
    // one by moving its left digit to the right side.
    public static void int13()
    {
        int a = int.Parse(Console.ReadLine());

        int b = a / 100;
        int c = a / 10 % 10;
        int d = a % 10;

        int e = c * 100 + d * 10 + b;
        Console.WriteLine(e);
        
    }
    //Integer14. A three-digit integer is given. Output an integer obtained from the given
    // one by moving its right digit to the left side.
    public static void int14()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a % 10;
        int c = a / 10 % 10;
        int d = a / 100;

        int e = b * 100 + c * 10 + d;
        Console.WriteLine(e);
    }
    //Integer15. A three-digit integer is given. Output an integer obtained from the given
    // one by exchange a tens digit and a hundreds digit (for example, 123 will be
    // changed to 213).
    public static void int15()
    {
        int a = int.Parse(Console.ReadLine());

        int b = a % 10;
        int c = a / 10 % 10;
        int d = a / 100;
        
        int e = c*100+d*10+b;
        Console.WriteLine(e);
    }
    //Integer16. A three-digit integer is given. Output an integer obtained from the given
    // one by exchange a ones digit and a tens digit (for example, 123 will be
    // changed to 132).
    public static void int16()
    {
        int a = int.Parse(Console.ReadLine());

        int b = a % 10;
        int c = a / 10 % 10;
        int d = a / 100;
        
        int e = d*100+b*10+c;
        Console.WriteLine(e);
    }
    //Integer17. An integer greater than 999 is given. Using one operator of integer
    // division and one operator of taking the remainder find a hundreds digit of the
    // given integer.
    public static void int17()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a / 100 % 10;
        Console.WriteLine(b);
    }
    //Integer18. An integer greater than 999 is given. Using one operator of integer
    // division and one operator of taking the remainder find a thousands digit of the
    // given integer.
    public static void int18()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a / 1000 % 10;
        Console.WriteLine(b);
    }
    //Integer19. From the beginning of the day N seconds have passed (N is integer). Find
    // an amount of full minutes passed from the beginning of the day.
    public static void int19()
    {
        int n = int.Parse(Console.ReadLine());

        int a = n / 60;
        Console.WriteLine(a);
    }
    //Integer20. From the beginning of the day N seconds have passed (N is integer). Find
    // an amount of full hours passed from the beginning of the day.
    public static void int20()
    {
        int n = int.Parse(Console.ReadLine());

        int a = n / (60 * 60);
        Console.WriteLine(a);
    }
    //Integer21. From the beginning of the day N seconds have passed (N is integer). Find
    // an amount of seconds passed from the beginning of the last minute.
    public static void int21()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n % 60;
        Console.WriteLine(a);
    }
    //Integer22. From the beginning of the day N seconds have passed (N is integer). Find
    // an amount of seconds passed from the beginning of the last hour.
    public static void int22()
    {
        int n = int.Parse(Console.ReadLine());

        int a = n % 3600;
        Console.WriteLine(a);
    }
    //Integer23. From the beginning of the day N seconds have passed (N is integer). Find
    // an amount of full minutes passed from the beginning of the last hour.
    public static void int23()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n % 3600;
        int b = a / 60;
        Console.WriteLine(b);
    }
    //Integer24. Days of week are numbered as: 0 — Sunday, 1 — Monday, 2 —
    // Tuesday, …, 6 — Saturday. An integer K in the range 1 to 365 is given. Find
    // the number of day of week for K-th day of year provided that in this year
    // January 1 was Monday.
    public static void int24()
    {
        int k = int.Parse(Console.ReadLine());
        
        Console.WriteLine(k%7);
    }
    //Integer25. Days of week are numbered as: 0 — Sunday, 1 — Monday, 2 —
    // Tuesday, …, 6 — Saturday. An integer K in the range 1 to 365 is given. Find
    // the number of day of week for K-th day of year provided that in this year
    // January 1 was Thursday.
    public static void int25()
    {
        int k = int.Parse(Console.ReadLine());
        int n = (k + 3) % 7;
        Console.WriteLine(n);
    }
    //Integer26. Days of week are numbered as: 1 — Monday, 2 — Tuesday, …, 6 —
    // Saturday, 7 — Sunday. An integer K in the range 1 to 365 is given. Find the
    // number of day of week for K-th day of year provided that in this year
    // January 1 was Tuesday.
    public static void int26()
    {
        int k = int.Parse(Console.ReadLine());
        int n = k % 7 + 1;
        Console.WriteLine(n);
    }
    //Integer27. Days of week are numbered as: 1 — Monday, 2 — Tuesday, …, 6 —
    // Saturday, 7 — Sunday. An integer K in the range 1 to 365 is given. Find the
    // number of day of week for K-th day of year provided that in this year
    // January 1 was Saturday.
    public static void int27()
    {
        int k = int.Parse(Console.ReadLine());
        int n = (k + 4) % 7 + 1;
        Console.WriteLine(n);
    }
    //Integer28. Days of week are numbered as: 1 — Monday, 2 — Tuesday, …, 6 —
    // Saturday, 7 — Sunday. An integer K in the range 1 to 365 and an integer N in
    // the range 1 to 7 are given. Find the number of day of week for K-th day of year
    // provided that in this year January 1 was N-th day of week.
    public static void int28()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine((k + n - 2) % 7 + 1);
    }
    //Integer29. Three positive integers A, B, C are given. A rectangle of the size A × B
    // contains the greatest possible amount of inside squares with the side length C
    // (without overlaps). Find the amount of squares placed on the rectangle and the
    // area of unused part of the rectangle.
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
    //Integer30. Given a year (as a positive integer), find the respective number of the
    // century. Note that, for example, 20th century began with the year 1901.
    public static void int30()
    {
        int a = int.Parse(Console.ReadLine());
        int b = (a + 99) / 100;
        Console.WriteLine(b);
    } 
}