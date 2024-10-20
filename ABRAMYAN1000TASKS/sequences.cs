namespace ABRAMYAN1000TASKS;

public class sequences
{
    //Series1. Given ten real numbers, find their sum.
    public static void s1()
    {
        double sum = 0;
        for (int i = 0; i < 10; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine(sum);
    }
    //Series2. Given ten real numbers, find their product.
    public static void s2()
    {
        double pr = 1;
        for (int i = 0; i < 10; i++)
        {
            double a = double.Parse(Console.ReadLine());
            pr *= a;
        }
        Console.WriteLine(pr);
    }
    //Series3. Given ten real numbers, find their average.
    public static void s3()
    {
        double sum = 0;
        for (int i = 0; i < 10; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }
        double avg = sum / 10;
        Console.WriteLine(avg);
    }
    //Series4. An integer N and a sequence of N real numbers are given. Output the sum
    // and the product of all elements of this sequence.
    public static void s4()
    {
        double sum = 0;
        double pr = 1;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
            pr *= num;
        }
        Console.WriteLine(sum);
        Console.WriteLine(pr);
    }
    //Series5. An integer N and a sequence of N positive real numbers are given. Output
    // in the same order the integer parts of all elements of this sequence (as real
    // numbers with zero fractional part). Also output the sum of all integer parts.
    public static void s5()
    {
        double sum = 0;
        double n = double.Parse(Console.ReadLine()); 
        
        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());

            sum += Math.Floor(num);
        }
            
        Console.WriteLine(sum);
    }
    //Series6. An integer N and a sequence of N positive real numbers are given. Output
    // in the same order the fractional parts of all elements of this sequence (as real
    // numbers with zero integer part). Also output the product of all fractional parts.
    public static void s6()
    {
        double pr = 1;
        double n = double.Parse(Console.ReadLine()); 
        
        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());

            pr *= num - Math.Floor(num);
        }
            
        Console.WriteLine(pr);
    }
    //Series7. An integer N and a sequence of N real numbers are given. Output in the
    // same order the rounded values of all elements of this sequence to the nearest
    // whole number (as integers). Also output the sum of all rounded values.
    
    public static void s7()
    {
        double sum = 0;
        int n = int.Parse(Console.ReadLine()); 
        
        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());

            sum += Math.Round(num);
        }
            
        Console.WriteLine(sum);
    }
    //Series8. An integer N and a sequence of N integers are given. Output in the same
    // order all even-valued elements of the sequence and also their amount K.
    public static void s8()
    {
        int n = int.Parse(Console.ReadLine());
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
                k++;
            }
        }
           Console.WriteLine($"Even num = {k}");
    }
    //Series9. An integer N and a sequence of N integers are given. Output in the same
    // order the order numbers of all odd-valued elements of the sequence and also
    // their amount K.
    public static void s9()
    {
        int n = int.Parse(Console.ReadLine());
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 != 0)
            {
                Console.WriteLine(i + 1);
                k++;
            }
        }
        Console.WriteLine($"Odd num = {k}");
    }
    //Series10. An integer N and a sequence of N integers are given. Output the logical
    // value True if the sequence contains positive-valued elements, otherwise output
    // False.
    public static void s10()
    {
        int n = int.Parse(Console.ReadLine());
        bool pos = false;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0) 
            {
                pos = true;
                break;
            }
        }
        Console.WriteLine(pos);
    }
}