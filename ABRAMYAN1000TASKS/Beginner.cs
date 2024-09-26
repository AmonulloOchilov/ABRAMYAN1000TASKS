namespace ABRAMYAN1000TASKS;

public class Beginner
{
    public static void B1()
    {
        var a = double.Parse(Console.ReadLine() ?? "0");
        var b = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine((a + b) * 2);
    }
}