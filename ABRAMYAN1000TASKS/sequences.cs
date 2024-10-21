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
    //Series26. Positive integers K, N and a sequence of N real numbers A1, A2, …, AN are
    // given. For each element of the sequence find its value raised to the power of K:
    // (A1)K, (A2)K, …, (AN)K

    public static void s26()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var a = double.Parse(Console.ReadLine());
            double result = 1;
            for (int j = 0; j < k; j++)
            {
                result *= a;
            }
            Console.WriteLine(result);
        }
    }
    //Series31. Integers K, N and K sequences of integers are given. Each given sequence
    // contains N elements. Find the amount of the sequences containing an element
    // with the value 2.
    public static void s31()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < k; i++)
        {
            bool containstwo = false;
            for (int j = 0; j < n; j++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 2)
                {
                    containstwo = true;
                }
            }

            if (containstwo)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
    //Series32. Integers K, N and K sequences of integers are given. Each given sequence
    // contains N elements. Output the order number of the first element with the
    // value 2 for each given sequence (if a sequence does not contain elements with
    // the required value then output 0).
    public static void s32()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < k; i++)
        {
            bool containstwo = false;
            int position = 0;
            for (int j = 0; j < n; j++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 2)
                {
                    containstwo = true;
                    position = j + 1;
                    break;
                }
            }

            if (containstwo)
            {
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
    //Series33. Integers K, N and K sequences of integers are given. Each given sequence
    // contains N elements. Output the order number of the last element with the
    // value 2 for each given sequence (if a sequence does not contain elements with
    // the required value then output 0)
    public static void s33()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < k; i++)
        {
            bool containstwo = false;
            int position = 0;
            for (int j = 0; j < n; j++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 2)
                {
                    containstwo = true;
                    position = j + 1;
                }
            }

            if (containstwo)
            {
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
    //Series34. Integers K, N and K sequences of integers are given. Each given sequence
    // contains N elements. Process each sequence as follows: output the sum of the
    // values of all its elements if the sequence contains an element with the value 2,
    // otherwise output 0
    public static void s34()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        
        
        for (int i = 0; i < k; i++)
        {
            int sum = 0;
            bool containstwo = false;
            for (int j = 0; j < n; j++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                if (a == 2)
                {
                    containstwo = true;
                    
                }
            }
            if (containstwo)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
    //Series35. An integer K and K sequences of nonzero integers are given. Each given
    // sequence is terminated by zero, which is not an element of the sequence.
    // Output the length of each given sequence. Also output the total length of all
    // given sequences.
    public static void s35()
    {
        int k = int.Parse(Console.ReadLine());
        int tl = 0;
        for (int i = 0; i < k; i++)
        {
            int l = 0;
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 0) 
                {
                    break;
                }

                l++;
            }

            tl += l;
            Console.WriteLine(l);
        }
        Console.WriteLine(tl);
    }
    //Series36. An integer K and K sequences of nonzero integers are given. Each given
    // sequence contains at least two elements and is terminated by zero, which is not
    // an element of the sequence. Output the amount of the sequences whose
    // element values are in ascending order.
    public static void s36()
    {
        int k = int.Parse(Console.ReadLine());
        int ac = 0;
        for (int i = 0; i < k; i++)
        {
            int a = int.Parse(Console.ReadLine());
            int pre = int.MinValue;
            bool isA = true;
            int curr;
            while (true)
            {
                curr = int.Parse(Console.ReadLine());
                if (curr == 0) 
                {
                    break;
                }

                if (curr <= pre)
                {
                    isA = false;
                }
                pre = curr;
            }

            if (isA)
            {
                ac++;
            }
        }
        Console.WriteLine(ac);
    }
    //Series37. An integer K and K sequences of nonzero integers are given. Each given
    // sequence contains at least two elements and is terminated by zero, which is not
    // an element of the sequence. Output the amount of sequences whose element
    // values are in ascending or in descending order.
    public static void s37()
    {
        int k = int.Parse(Console.ReadLine());
        int count = 0;
        
        for (int i = 0; i < k; i++)
        {
            int pre = int.MinValue;
            bool isA = true;
            bool isdc = true;
            int curr;
            
            while (true)
            {
                curr = int.Parse(Console.ReadLine());
                if (curr == 0) 
                {
                    break;
                }

                if (curr < pre)
                {
                    isA = false;
                }

                if (curr > pre) 
                {
                    isdc = false;
                }
                pre = curr;
            }

            if (isA || isdc)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
    //Series38. An integer K and K sequences of nonzero integers are given. Each given
    // sequence contains at least two elements and is terminated by zero, which is not
    // an element of the sequence. Process each sequence as follows: output 1 or −1
    // if its element values are in ascending or in descending order respectively,
    // otherwise output 0.
    public static void s38()
    {
        int k = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < k; i++)
        {
            int pre = int.MinValue;
            bool isA = true;
            bool isdc = true;
            int curr;
            
            while (true)
            {
                curr = int.Parse(Console.ReadLine());
                if (curr == 0) 
                {
                    break;
                }

                if (curr < pre)
                {
                    isA = false;
                }else if (curr > pre) 
                {
                    isdc = false;
                }
                pre = curr;
            }

            if (isA)
            {
                Console.WriteLine(1);
            }

            if (isdc)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
    //Series39. An integer K and K sequences of nonzero integers are given. Each given
    // sequence contains at least three elements and is terminated by zero, which is
    // not an element of the sequence. Output the amount of the sawtooth sequences
    // (see the definition of a sawtooth sequence in Series23).
    public static void s39()
    {
        int k = int.Parse(Console.ReadLine());
        int sawt = 0;
        
        for (int i = 0; i < k; i++)
        {
            int pre = int.Parse(Console.ReadLine());
            int curr = int.Parse(Console.ReadLine());
            int next;
            bool issawt = true;
            
            while (true)
            {
                next = int.Parse(Console.ReadLine());
                if (next == 0) 
                {
                    break;
                }

                if (!((pre < curr && curr > next) || (pre > curr && curr < next)))
                {
                    issawt = false;
                }

                pre = curr;
                curr = next;
            }

            if (issawt)
            {
                sawt++;
            }
        }
        Console.WriteLine(sawt);
    }
    //Series40. An integer K and K sequences of nonzero integers are given. Each given
    // sequence contains at least three elements and is terminated by zero, which is
    // not an element of the sequence. Process each sequence as follows: output its
    // length if the sequence is a sawtooth one (see Series23), otherwise output the
    // order number of its first element that is not a tooth.
    public static void s40()
    {
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            int pre = int.Parse(Console.ReadLine());
            int curr = int.Parse(Console.ReadLine());
            int next;
            int pos = 2; 
            bool isSawt = true;
            int breakingPosition = 0; 
            int length = 2; 

            while (true)
            {
                next = int.Parse(Console.ReadLine());
                if (next == 0)
                {
                    break;
                }

                length++;
                pos++;

                if (!((pre < curr && curr > next) || (pre > curr && curr < next)))
                {
                    if (isSawt) 
                    {
                        breakingPosition = pos;
                    }
                    isSawt = false;
                }

                pre = curr;
                curr = next;
            }

            if (isSawt)
            {
                Console.WriteLine(length); 
            }
            else
            {
                Console.WriteLine(breakingPosition); 
            }
        }
    }
}