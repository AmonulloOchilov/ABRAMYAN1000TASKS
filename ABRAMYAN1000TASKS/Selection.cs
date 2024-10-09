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
                Console.WriteLine("30"); //Some mistakes are delibrately
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
                Console.WriteLine(a + b);
                break;
            case 2:
                Console.WriteLine(a - b);
                break;
            case 3:
                Console.WriteLine(a * b);
                break;
            case 4:
                if (b != 0)
                {
                    Console.WriteLine(a / b);
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
        var d = double.Parse(Console.ReadLine());
        var m = double.Parse(Console.ReadLine());
        switch (m)
        {
            case 1:
                if (d == 1)
                {
                    d = 31;
                    m = 12;
                }
                else
                {
                    d--;
                }

                break;
            case 2:
                if (d == 1)
                {
                    d = 31;
                    m = 1;
                }
                else
                {
                    d--;
                }

                break;
            case 3:
                if (d == 1)
                {
                    d = 28;
                    m = 2;
                }
                else
                {
                    d--;
                }

                break;
            case 4:
                if (d == 1)
                {
                    d = 31;
                    m = 3;
                }
                else
                {
                    d--;
                }

                break;
            case 5:
                if (d == 1)
                {
                    d = 30;
                    m = 4;
                }
                else
                {
                    d--;
                }

                break;
            case 6:
                if (d == 1)
                {
                    d = 31;
                    m = 5;
                }
                else
                {
                    d--;
                }

                break;
            case 7:
                if (d == 1)
                {
                    d = 30;
                    m = 6;
                }
                else
                {
                    d--;
                }

                break;
            case 8:
                if (d == 1)
                {
                    d = 31;
                    m = 7;
                }
                else
                {
                    d--;
                }

                break;
            case 9:
                if (d == 1)
                {
                    d = 31;
                    m = 8;
                }
                else
                {
                    d--;
                }

                break;
            case 10:
                if (d == 1)
                {
                    d = 30;
                    m = 9;
                }
                else
                {
                    d--;
                }

                break;
            case 11:
                if (d == 1)
                {
                    d = 31;
                    m = 10;
                }
                else
                {
                    d--;
                }

                break;
            case 12:
                if (d == 1)
                {
                    d = 30;
                    m = 11;
                }
                else
                {
                    d--;
                }

                break;
            default:
                Console.WriteLine("Error");
                break;
        }

        Console.WriteLine(d);
        Console.WriteLine(m);
    }

    //Given two integers D (day) and M (month) representing a correct date of a
    // non-leap year, output values D and M for the next date.
    public static void sc9()
    {
        int d = int.Parse(Console.ReadLine()); // Input day
        int m = int.Parse(Console.ReadLine()); // Input month
        int y = int.Parse(Console.ReadLine()); // Input year (added)

        switch (m)
        {
            case 1: // January
            case 3: // March
            case 5: // May
            case 7: // July
            case 8: // August
            case 10: // October
                if (d == 31)
                {
                    d = 1;
                    m++;
                }
                else
                {
                    d++;
                }

                break;

            case 4: // April
            case 6: // June
            case 9: // September
            case 11: // November
                if (d == 30)
                {
                    d = 1;
                    m++;
                }
                else
                {
                    d++;
                }

                break;

            case 2: // February
                if (d == 28) // Non-leap year (since it's given as non-leap)
                {
                    d = 1;
                    m++;
                }
                else
                {
                    d++;
                }

                break;

            case 12: // December
                if (d == 31)
                {
                    d = 1;
                    m = 1; // Next month is January
                    y++; // Increment the year
                }
                else
                {
                    d++;
                }

                break;

            default:
                Console.WriteLine("Error: Invalid month input");
                return;
        }

        Console.WriteLine($"Next Date: {d}/{m}/{y}");

    }

    //A robot can move in four directions (―N‖
    // — north, ―W‖
    // — west, ―S‖
    // —
    // south, ―E‖
    // — east) and perform three digital instructions: 0 —
    // ―move in the
    // former direction‖, 1 —
    // ―turn left‖, −1 —
    // ―turn right‖. A symbol C (an initial
    // direction of the robot) and an integer N (an instruction) are given. Output the
    // direction of the robot (as symbol) after performing the instruction.
    public static void sc10()
    {
        char id = char.Parse(Console.ReadLine());
        int ins = int.Parse(Console.ReadLine());
        char nd = id;
        switch (id)
        {
            case 'n':
                switch (ins)
                {
                    case 0:
                        nd = 'n';
                        break;
                    case 1:
                        nd = 'w';
                        break;
                    case -1:
                        nd = 'e';
                        break;
                }

                break;
            case 'e':
                switch (ins)
                {
                    case 0:
                        nd = 'e';
                        break;
                    case 1:
                        nd = 'n';
                        break;
                    case -1:
                        nd = 's';
                        break;
                }

                break;
            case 's':
                switch (ins)
                {
                    case 0:
                        nd = 's';
                        break;
                    case 1:
                        nd = 'e';
                        break;
                    case -1:
                        nd = 'w';
                        break;
                }

                break;
            case 'w':
                switch (ins)
                {
                    case 0:
                        nd = 'w';
                        break;
                    case 1:
                        nd = 's';
                        break;
                    case -1:
                        nd = 'n';
                        break;
                }

                break;
            default:
                Console.WriteLine("Error");
                return;
        }

        Console.WriteLine(nd);

    }

    //A locator can be focused on the directions ―N‖ (north),
    // ―W‖ (west), ―S‖
    // (south), ―E‖ (east) and perform three digital instructions: 1 —
    // ―turn left‖
    // ,
    // −1 —
    // ―turn right‖, 2 —
    // ―turn on 180°‖). A symbol C (an initial direction of the
    // locator) and two integers N1 and N2 (instructions) are given. Output the
    // direction of the locator (as symbol) after performing the instructions.
    public static void sc11()
    {
        char cd = 'n';
        int ins1 = 1;
        int ins2 = -1;

        switch (ins1)
        {
            case 1:
                switch (cd)
                {
                    case 'n':
                        cd = 'w';
                        break;
                    case 'w':
                        cd = 's';
                        break;
                    case 's':
                        cd = 'e';
                        break;
                    case 'e':
                        cd = 'n';
                        break;
                }

                break;
            case -1:
                switch (cd)
                {

                    case 'n':
                        cd = 'e';
                        break;
                    case 'e':
                        cd = 's';
                        break;
                    case 's':
                        cd = 'w';
                        break;
                    case 'w':
                        cd = 'n';
                        break;
                }

                break;
            case 2:
                switch (cd)
                {

                    case 'n':
                        cd = 's';
                        break;
                    case 's':
                        cd = 'n';
                        break;
                    case 'e':
                        cd = 'w';
                        break;
                    case 'w':
                        cd = 'e';
                        break;
                }

                break;
        }

        switch (ins2)
        {
            case 1:
                switch (cd)
                {
                    case 'n':
                        cd = 'w';
                        break;
                    case 'w':
                        cd = 's';
                        break;
                    case 's':
                        cd = 'e';
                        break;
                    case 'e':
                        cd = 'n';
                        break;
                }

                break;
            case -1:
                switch (cd)
                {

                    case 'n':
                        cd = 'e';
                        break;
                    case 'e':
                        cd = 's';
                        break;
                    case 's':
                        cd = 'w';
                        break;
                    case 'w':
                        cd = 'n';
                        break;
                }

                break;
            case 2:
                switch (cd)
                {

                    case 'n':
                        cd = 's';
                        break;
                    case 's':
                        cd = 'n';
                        break;
                    case 'e':
                        cd = 'w';
                        break;
                    case 'w':
                        cd = 'e';
                        break;
                }

                break;
        }

        Console.WriteLine(cd);
    }

    //Elements of a circle are numbered as: 1 — radius R, 2 — diameter D = 2·R,
    // 3 — length L = 2·π·R of the circumference, 4 — area S = π·R2. The order
    // number of one element and its value (as a real number) are given. Output
    // values of other elements in the same order. Use 3.14 for a value of π.
    public static void sc12()
    {
        int orderNumber = int.Parse(Console.ReadLine());
        double value = double.Parse(Console.ReadLine());

        double R, D, L, S;
        const double p = 3.14;

        switch (orderNumber)
        {
            case 1:
                R = value;
                D = 2 * R; // Diameter
                L = 2 * p * R; // Circumference length
                S = p * R * R; // Area
                Console.WriteLine($"D: {D}, L: {L}, S: {S}");
                break;

            case 2:
                D = value;
                R = D / 2;
                L = 2 * p * R;
                S = p * R * R;
                Console.WriteLine($"R: {R}, L: {L}, S: {S}");
                break;

            case 3:
                L = value;
                R = L / (2 * p);
                D = 2 * R;
                S = p * R * R;
                Console.WriteLine($"R: {R}, D: {D}, S: {S}");
                break;

            case 4:
                S = value;
                R = Math.Sqrt(S / p);
                D = 2 * R;
                L = 2 * p * R;
                Console.WriteLine($"R: {R}, D: {D}, L: {L}");
                break;

            default:
                Console.WriteLine("Invalid order number");
                break;
        }
    }

    //Elements of a right isosceles triangle are numbered as: 1 — leg a, 2 —
    // hypotenuse c = a·(2)1/2, 3 — altitude h drawn onto hypotenuse (h = c/2), 4 —
    //area S = c·h/2. The order number of one element and its value (as a real
    // number) are given. Output values of other elements in the same order.
    public static void sc13()
    {
        int orderNumber = int.Parse(Console.ReadLine());
        double value = double.Parse(Console.ReadLine());

        switch (orderNumber)
        {
            case 1: // Leg a
                double a = value;
                double c = a * Math.Sqrt(2); // Hypotenuse
                double h = c / 2; // Altitude
                double S = (c * h) / 2; // Area
                Console.WriteLine($"1: {a}, 2: {c}, 3: {h}, 4: {S}");
                break;

            case 2:
                c = value;
                a = c / Math.Sqrt(2);
                h = c / 2;
                S = (c * h) / 2;
                Console.WriteLine($"1: {a}, 2: {c}, 3: {h}, 4: {S}");
                break;

            case 3:
                h = value;
                c = h * 2;
                a = c / Math.Sqrt(2);
                S = (c * h) / 2;
                Console.WriteLine($"1: {a}, 2: {c}, 3: {h}, 4: {S}");
                break;

            case 4:
                S = value;

                c = 2 * Math.Sqrt(S);
                h = c / 2;
                a = c / Math.Sqrt(2);
                Console.WriteLine($"1: {a}, 2: {c}, 3: {h}, 4: {S}");
                break;

            default:
                Console.WriteLine("Invalid order number");

                break;
        }
    }

    //One of the Asian calendars uses 60-years periods divided into 12-years
    // cycles, which are associated with a color: green, red, yellow, white, black.
    // Each year in a cycle is connected with some animal: rat, cow, tiger, hare,
    // dragon, snake, horse, sheep, monkey, hen, dog, pig. Given some year (as
    // positive integer), output its name provided that 1984 is ―The Green Rat`s
    // year‖
    // .
    public static void sc19()
    {
        int year = int.Parse(Console.ReadLine());

        string result = "";

        switch (year)
        {
            case 1984:
                result = "Green Rat";
                break;
            case 1985:
                result = "Red Ox";
                break;
            case 1986:
                result = "Yellow Tiger";
                break;
            case 1987:
                result = "White Rabbit";
                break;
            case 1988:
                result = "Black Dragon";
                break;
            case 1989:
                result = "Green Snake";
                break;
            case 1990:
                result = "Red Horse";
                break;
            case 1991:
                result = "Yellow Goat";
                break;
            case 1992:
                result = "White Monkey";
                break;
            case 1993:
                result = "Black Rooster";
                break;
            case 1994:
                result = "Green Dog";
                break;
            case 1995:
                result = "Red Pig";
                break;
            case 1996:
                result = "Yellow Rat";
                break;
            case 1997:
                result = "White Ox";
                break;
            case 1998:
                result = "Black Tiger";
                break;
            case 1999:
                result = "Green Rabbit";
                break;
            case 2000:
                result = "Red Dragon";
                break;
            case 2001:
                result = "Yellow Snake";
                break;
            case 2002:
                result = "White Horse";
                break;
            case 2003:
                result = "Black Goat";
                break;
            case 2004:
                result = "Green Monkey";
                break;
            case 2005:
                result = "Red Rooster";
                break;
            case 2006:
                result = "Yellow Dog";
                break;
            case 2007:
                result = "White Pig";
                break;
            case 2008:
                result = "Black Rat";
                break;
            case 2009:
                result = "Green Ox";
                break;
            case 2010:
                result = "Red Tiger";
                break;
            case 2011:
                result = "Yellow Rabbit";
                break;
            case 2012:
                result = "White Dragon";
                break;
            case 2013:
                result = "Black Snake";
                break;
            case 2014:
                result = "Green Horse";
                break;
            case 2015:
                result = "Red Goat";
                break;
            case 2016:
                result = "Yellow Monkey";
                break;
            case 2017:
                result = "White Rooster";
                break;
            case 2018:
                result = "Black Dog";
                break;
            case 2019:
                result = "Green Pig";
                break;
            case 2020:
                result = "Red Rat";
                break;
            case 2021:
                result = "Yellow Ox";
                break;
            case 2022:
                result = "White Tiger";
                break;
            case 2023:
                result = "Black Rabbit";
                break;
            case 2024:
                result = "Green Dragon";
                break;
            default:
                result = "The year is not in the known range.";
                break;
        }

        Console.WriteLine($"{year} is the {result}'s year.");
    }


    //Given two integers D (day) and M (month) that represent a correct date,
    // output the zodiacal name corresponding to this date: ―Aquarius‖ 20.1–18.2,
    // ―Pisces‖ 19.2–20.3, ―Aries‖ 21.3–19.4, ―Taurus‖ 20.4–20.5,
    // ―Gemini‖ 21.5–
    // 21.6, ―Cancer‖ 22.6–22.7, ―Leo‖ 23.7–22.8, ―Virgo‖ 23.8–22.9, ―Libra‖ 23.9–
    // 22.10, ―Scorpio‖ 23.10–22.11, ―Sagittarius‖ 23.11–21.12, ―Capricorn‖ 22.12–
    // 19.1.
    public static void sc20()
    {
        int day = int.Parse(Console.ReadLine());

        int month = int.Parse(Console.ReadLine());

        string zodiacSign = "";

        switch (month)
        {
            case 1: 
                if (day >= 20)
                {
                    zodiacSign = "Aquarius";
                }
                else
                {
                    zodiacSign = "Capricorn";
                }
                break;

            case 2: 
                if (day >= 19)
                {
                    zodiacSign = "Pisces";
                }
                else
                {
                    zodiacSign = "Aquarius";
                }
                break;

            case 3: 
                if (day >= 21)
                {
                    zodiacSign = "Aries";
                }
                else
                {
                    zodiacSign = "Pisces";
                }
                break;

            case 4: 
                if (day >= 20)
                {
                    zodiacSign = "Taurus";
                }
                else
                {
                    zodiacSign = "Aries";
                }
                break;

            case 5: 
                if (day >= 21)
                {
                    zodiacSign = "Gemini";
                }
                else
                {
                    zodiacSign = "Taurus";
                }
                break;

            case 6: 
                if (day >= 22)
                {
                    zodiacSign = "Cancer";
                }
                else
                {
                    zodiacSign = "Gemini";
                }
                break;

            case 7: 
                if (day >= 23)
                {
                    zodiacSign = "Leo";
                }
                else
                {
                    zodiacSign = "Cancer";
                }
                break;

            case 8: 
                if (day >= 23)
                {
                    zodiacSign = "Virgo";
                }
                else
                {
                    zodiacSign = "Leo";
                }
                break;

            case 9: 
                if (day >= 23)
                {
                    zodiacSign = "Libra";
                }
                else
                {
                    zodiacSign = "Virgo";
                }
                break;

            case 10: 
                if (day >= 23)
                {
                    zodiacSign = "Scorpio";
                }
                else
                {
                    zodiacSign = "Libra";
                }
                break;

            case 11: 
                if (day >= 23)
                {
                    zodiacSign = "Sagittarius";
                }
                else
                {
                    zodiacSign = "Scorpio";
                }
                break;

            case 12: 
                if (day >= 22)
                {
                    zodiacSign = "Capricorn";
                }
                else
                {
                    zodiacSign = "Sagittarius";
                }
                break;

            default:
                zodiacSign = "Invalid month"; 
                break;
        }

        Console.WriteLine($"The zodiac sign for {day}/{month} is: {zodiacSign}");
    }
    }

