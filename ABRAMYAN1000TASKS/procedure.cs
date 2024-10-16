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
}