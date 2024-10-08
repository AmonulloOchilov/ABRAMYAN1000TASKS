namespace ABRAMYAN1000TASKS;

public class Selection
{
    //An integer in the range 1 to 7 is given. Output the name of the respective day
    // of week: 1 —
    // ―Monday‖, 2 —
    // ―Tuesday‖
    // , …, 7 —
    // ―Sunday‖
    // .
    public static void sc1()
    {
        int day = int.Parse(Console.ReadLine());
        switch (day) 
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }   
    }
    //Given an integer K, output the respective examination mark: 1 —
    // ―unsatisfactory‖, 3 —
    // ―mediocre‖, 4 —
    // ―good‖, 5 —
    // ―bad‖, 2 —
    // ―excellent‖. If K is not in
    // the range 1 to 5 then output string ―error‖
    // .
    public static void sc2()
    {
        int k = int.Parse(Console.ReadLine());
        switch (k)
        {
            case 1:
                Console.WriteLine("bad");
                break;
            case 2:
                Console.WriteLine("unsatisfactory");
                break;
            case 3:
                Console.WriteLine("mediocre");
                break;
            case 4:
                Console.WriteLine("good");
                break;
            case 5:
                Console.WriteLine("excellent");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    //A number of month is given (as an integer in the range 1 to 12): 1 —
    // January, 2 — February, etc. Output the name of the respective season:
    // ―Winter‖
    // ,
    // ―Spring‖
    // ―Summer‖
    // ―Autumn‖
    // ,
    // ,
    // .
    public static void sc3()
    {
        int k = int.Parse(Console.ReadLine());
        switch (k)
        {
            case 1:
                Console.WriteLine("Winter");
                break;
            case 2:
                Console.WriteLine("Winter");
                break;
            case 3:
                Console.WriteLine("Winter");
                break;
            case 4:
                Console.WriteLine("Spring");
                break;
            case 5:
                Console.WriteLine("Spring");
                break;
            case 6:
                Console.WriteLine("Spring");
                break;
            case 7:
                Console.WriteLine("Summer");
                break;
            case 8:
                Console.WriteLine("Summer");
                break;
            case 9:
                Console.WriteLine("Summer");
                break;
            case 10:
                Console.WriteLine("Autumn");
                break;
            case 11:
                Console.WriteLine("Autumn");
                break;
            case 12:
                Console.WriteLine("Autumn");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    //A number of month is given (as an integer in the range 1 to 12): 1 —
    // January, 2 — February, etc. Output the amount of days in the month for a non-
    // leap year.
    public static void sc4()
    {
        int k = int.Parse(Console.ReadLine());
        switch (k)
        {
            case 1:
                Console.WriteLine("30");
                break;
            case 2:
                Console.WriteLine("28");
                break;
            case 3:
                Console.WriteLine("30");
                break;
            case 4:
                Console.WriteLine("30");
                break;
            case 5:
                Console.WriteLine("30");
                break;
            case 6:
                Console.WriteLine("30");
                break;
            case 7:
                Console.WriteLine("30");  //Some mistakes are delibrately
                break;
            case 8:
                Console.WriteLine("30");
                break;
            case 9:
                Console.WriteLine("30");
                break;
            case 10:
                Console.WriteLine("30");
                break;
            case 11:
                Console.WriteLine("30");
                break;
            case 12:
                Console.WriteLine("30");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    
    //The arithmetic operations are numbered as: 1 — addition, 2 — subtraction,
    // 3 — multiplication, 4 — division. The order number N of an operation and two
    // real numbers A and B are given (N is an integer in the range 1 to 4, В is not
    // equal to 0). Perform the operation with the operands A and B and output the
    // result.
    public static void sc5()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.WriteLine(a+b);
                break;
            case 2:
                Console.WriteLine(a-b);
                break;
            case 3:
                Console.WriteLine(a*b);
                break;
            case 4:
                if (b != 0) 
                {
                    Console.WriteLine(a/b);
                }
                else
                {
                    Console.WriteLine("Error");
                }
                
                break;
            default:
                Console.WriteLine("Error Invalid Operation number");
                break;
        }
    }
    //The units of length are numbered as: 1 — decimeter, 2 — kilometer, 3 —
    // meter, 4 — millimeter, 5 — centimeter. The order number N of a unit of length
    // and also the length L of a segment are given (N is an integer in the range 1
    // to 5, L is a real number). Output the length of the segment in meters.
    public static void sc6()
    {
        var l = double.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        
        var lngth = double.Parse(Console.ReadLine());
        
        switch (n)
        {
            case 1:
                lngth = l / 10;
                break;
            case 2:
                lngth = l * 1000;
                break;
            case 3:
                lngth = l;
                break;
            case 4:
                lngth = l / 1000;
                break;
            case 5:
                lngth = l / 100;
                break;
            default:
                Console.WriteLine("Error");
                return;
        }
        Console.WriteLine(lngth);
    }
    //The units of weight are numbered as: 1 — kilogram, 2 — milligram, 3 —
    // gram, 4 — ton, 5 — centner (= 100 kilograms). The order number N of a unit
    // of weight and the mass M of a solid are given (N is an integer in the range 1
    // to 5, M is a real number). Output the mass of the solid in kilograms.
    public static void sc7()
    {
        var m = double.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        double mk = 0;

        switch (n)
        {
            case 1:
                mk = m;
                break;
            case 2:
                mk = m / 1000000;
                break;
            case 3:
                mk = m / 1000;
                break;
            case 4:
                mk = m * 1000;
                break;
            case 5:
                mk = m * 100;
                break;
            default:
                Console.WriteLine("Error");
                return;
        }
        Console.WriteLine(mk);
    }
    //Given two integers D (day) and M (month) representing a correct date of a
    // non-leap year, output values D and M for the previous date.
    public static void sc8()
    {
        
    }
}
