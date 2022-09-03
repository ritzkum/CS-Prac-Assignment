//C# Assignments
using System;

namespace AWP_Assignment
{
    class Program1
    {
        //question 1: W.A.P to print hello world in C#
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 1: W.A.P to print hello world in C# \n");
            Console.WriteLine("Hello World");
        }
    }
    class program2
    {
        //question 2: W.A.P to perform arithematic operators
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 2: W.A.P to perform arithematic operators");
            int num1 = 50;
            int num2 = 25;
            int result;
            result = num1 + num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 - num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 * num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 / num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 % num2;
            Console.WriteLine("Value is {0}", result);
            result = num1++;
            Console.WriteLine("Value is {0}", result);
            result = num1--;
            Console.WriteLine("Value is {0}", result);
            Console.ReadLine();
        }
    }
    class program3
    {
        //question 3: W.A.P to perform Assignment operators
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 3: W.A.P to perform Assignment operators \n");
            int a = 21;
            int c;
            c = a;
            Console.WriteLine("Line 1 - =  Value of c = {0}", c);
            c += a;
            Console.WriteLine("Line 2 - += Value of c = {0}", c);
            c -= a;
            Console.WriteLine("Line 3 - -=  Value of c = {0}", c);
            c *= a;
            Console.WriteLine("Line 4 - *=  Value of c = {0}", c);
            c /= a;
            Console.WriteLine("Line 5 - /=  Value of c = {0}", c);
            c = 200;
            c %= a;
            Console.WriteLine("Line 6 - %=  Value of c = {0}", c);
            c <<= 2;
            Console.WriteLine("Line 7 - <<=  Value of c = {0}", c);
            c >>= 2;
            Console.WriteLine("Line 8 - >>=  Value of c = {0}", c);
            c &= 2;
            Console.WriteLine("Line 9 - &=  Value of c = {0}", c);
            c ^= 2;
            Console.WriteLine("Line 10 - ^=  Value of c = {0}", c);
            c |= 2;
            Console.WriteLine("Line 11 - |=  Value of c = {0}", c);
            Console.ReadLine();
        }
    }
    class program4
    {
        //question 4: W.A.P to perform Logical operators
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 4: W.A.P to perform Logical operators \n");
            int x = 15, y = 10;
            bool a = true, result;
            // AND operator
            result = (x <= y) && (x > 10);
            Console.WriteLine("AND Operator: " + result);
            // OR operator
            result = (x >= y) || (x < 5);
            Console.WriteLine("OR Operator: " + result);
            //NOT operator
            result = !a;
            Console.WriteLine("NOT Operator: " + result);
            Console.WriteLine("Program Ends");
            Console.ReadLine();
        }
    }
    class program5
    {
        //question 5: W.A.P to perform Comparison operators
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 5: W.A.P to perform Comparison operators \n");
            // returns False because 5 is not equal to 3
            Console.WriteLine("equal to ==");
            int x1 = 5;
            int y1 = 3;
            Console.WriteLine(x1 == y1);
            // returns True because 5 is not equal to 3
            int x2 = 5;
            int y2 = 3;
            Console.WriteLine(x2 != y2);  
        }
    }
    class program6
    {
        //question 6: W.A.P to perform Conditional operators
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 6: W.A.P to perform Conditional operators \n");
            var smallArray = new int[] { 1, 2, 3, 4, 5 };
            var largeArray = new int[] { 10, 20, 30, 40, 50 };

            int index = 7;
            ref int refValue = ref ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]);
            refValue = 0;

            index = 2;
            ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]) = 100;

            Console.WriteLine(string.Join(" ", smallArray));
            Console.WriteLine(string.Join(" ", largeArray));
        }
    }
    class program7
    {
        //question 7: W.A.P to check the even-odd numbers
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 7: W.A.P to check the even-odd numbers \n");
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
    class program8 {
        //question 8: W.A.P to demonstrate IF-Else Statement
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 8: W.A.P to demonstrate IF-Else Statement \n");
            int a = 10;
            int b = 20;
            if(a== b)
            {
                Console.WriteLine("numbers are equal");
            }
            else
            {
                Console.WriteLine("numbers are not equal");
            }
        }
    }
    class program9 {
        //question 9: W.A.P to demonstrate Else-If Ladder
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 9: W.A.P to demonstrate Else-If Ladder \n");
            Console.WriteLine("Enter a number to check grade:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > 100)
            {
                Console.WriteLine("wrong number");
            }
            else if (num >= 0 && num < 35)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 35 && num < 50)
            {
                Console.WriteLine("D Grade");
            }
            else if (num >= 50 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (num >= 90 && num <= 100)
            {
                Console.WriteLine("O Grade");
            }
        }
    }
    class program10 {
        //question 10: W.A.P to demonstrate Nested If-ELse
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 10: W.A.P to demonstrate Nested If-ELse \n");
            int first = 6, second = -8, third = 18;
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("{0} is the largest", first);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("{0} is the largest", second);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", third);
                }
            }
        }
    }
    class program11 {
        //question 11: W.A.P to demonstrate Switch Case
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 11: W.A.P to demonstrate Switch Case \n");
            int day = 4;
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
            }
        }
    }
    class program12 {
        class program13 {
        //question 13: W.A.P to demonstrate While Loop
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 13: W.A.P to demonstrate While Loop \n");
                int x = 1;

                // Exit when x becomes greater than 4
                while (x <= 4)
                {
                    Console.WriteLine("GeeksforGeeks");

                    // Increment the value of x for
                    // next iteration
                    x++;
                }
            }
    }
    class program14 {
        //question 14: W.A.P to demonstrate following loops
        static void breakLoop(){
            Console.WriteLine("Break Loop");
                for (int i = 0; i < 10; i++)
                {
                    if (i == 4)
                    {
                        break;
                    }
                    Console.WriteLine(i);
                }
            }
        static void GotoLoop()
        {
            Console.WriteLine("Goto Loops");
                for (int i = 0; i < 10; i++)
                {
                    if (i == 4)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }

            }
        static void continueLoop()
        {
            Console.WriteLine("Continue Loops");
                for (int i = 0; i < 10; i++)
                {
                    if (i == 4)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            } 
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 14: W.A.P to demonstrate the following loops: 1. Break, 2. GoTo, 3. Continue \n");
            breakLoop();
            GotoLoop();
            continueLoop();
        }
    }
    class program15 {
            //question 15: W.A.P to demonstrate Do-while loop
            static void Main()
            {
                Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
                Console.WriteLine("question 15: W.A.P to demonstrate Do-while loop \n");
                int i = 0;
                do
                {
                    Console.WriteLine(i);
                    i++;
                }
                while (i < 5);
            }
        }
        class program16 {
            //question 16: W.A.P to demonstrate Foreach loop
            static void Main()
            {
                Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
                Console.WriteLine("question 16: W.A.P to demonstrate Foreach loop \n");
                string[] bikes = { "Pulsar", "Apache", "Shine", "Bullet" };
                foreach (string i in bikes)
                {
                    Console.WriteLine(i);
                }
            }
        }
        class program17 {
            //question 17: W.A.P to perform number Programs
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 17: W.A.P to perform number Programs \n");
            armStrong();
            Fibonacci();

        }
            static void armStrong()
            {
                Console.WriteLine("Check Number Is Armstrong Or Not");
                int number, rem, temp, sum = 0;   
                Console.Write("Enter Your Number To Check :: ");
                number = int.Parse(Console.ReadLine());

                temp = number;
                while (number > 0)
                {
                    rem = number % 10;
                    sum = sum + (rem * rem * rem);
                    number = number / 10;
                }

                if (temp == sum)
                    Console.WriteLine(temp + " Is A Armstrong Number");
                else
                    Console.WriteLine(temp + " Is Not A Armstrong Number");
                Console.ReadKey();
                }
            }
            static void Fibonacci()
            {
                int n1 = 0, n2 = 1, n3, i, number;
                Console.Write("Enter the number of elements: ");
                number = int.Parse(Console.ReadLine());
                Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
                for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
            }

       
    }
    class program18 {
            //question 18: W.A.P to demonstrate program on Floyd's Triangle
            static void Main(string[] args)
            {
                Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
                Console.WriteLine("question 18: W.A.P to demonstrate program on Floyd's Triangle \n");
                int i, j, n, p, q;
                Console.Write("Input number of rows : ");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    { p = 1; q = 0; }
                    else
                    { p = 0; q = 1; }
                    for (j = 1; j <= i; j++)
                        if (j % 2 == 0)
                            Console.Write("{0}", p);
                        else
                            Console.Write("{0}", q);
                    Console.Write("\n");
                }
            }
    }
        class program19 {
            //question 19: W.A.P to perform patterns
            static void pattern1() {
                int x, y, z;
                for (x = 6; x >= 1; x--)
                {
                    for (y = 1; y < x; y++)
                    {
                        Console.Write(" ");
                    }
                    for (z = 6; z >= x; z--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void pattern2() {
                int x, y;
                for (x = 1; x <= 6; x++)
                {
                    for (y = 1; y <= x; y++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void pattern3() {
                int x, y;
                for (x = 5; x >= 1; x--)
                {
                    for (y = 1; y <= x; y++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void pattern4() {
                int x, y, z;
                for (x = 5; x >= 1; x--)
                {
                    for (y = 5; y > x; y--)
                    {
                        Console.Write(" ");
                    }
                    for (z = 1; z <= x; z++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void pattern5() {
                int x, y, z;
                for (x = 1; x <= 5; x++)
                {
                    for (y = x; y < 5; y++)
                    {
                        Console.Write(" ");
                    }
                    for (z = 1; z < (x * 2); z++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
                Console.WriteLine("question 19: W.A.P to perform patterns \n");
                pattern1();
                pattern2();
                pattern3();
                pattern4();
                pattern5();
            }
    }
        class program20 {
        //question 20: W.A.P to find a number is palindrome or not
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 20: W.A.P to find a number is palindrome or not \n");
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");

        }
    }class program21 {
        //question 21: W.A.P to reverse a number
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 21: W.A.P to reverse a number \n");
        }
    }class program22 {
        //question 22: W.A.P to sum of digit of numbers
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 22: W.A.P to sum of digit of numbers \n");
        }
    }class program23 {
        //question 23: W.A.P to swap numbers using 2 variables
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 23: W.A.P to swap numbers using 2 variables \n");
        }
    }class program24 {
        //question 24: W.A.P to find factorial of number
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 24: W.A.P to find factorial of number \n");
        }
    }class program25 {
            //question 25: W.A.P to demonstrate Arrays
            static void singleD() { }
            static void multiD() { }
            static void jagged() { }
            static void Main(string[] args)
            {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 25: W.A.P to demonstrate Arrays \n");
                singleD();
                multiD();
                jagged();
            }
    }class program26 {
        //question 26: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 26: W.A.P to perform \n");
        }
    }class program27 {
        //question 27: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 27: W.A.P to perform \n");
        }
    }class program28 {
        //question 28: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 28: W.A.P to perform \n");
        }
    }class program29 {
        //question 29: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 29: W.A.P to perform \n");
        }
    }class program30 {
        //question 30: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 30: W.A.P to perform \n");
        }
    }class program31 {
        //question 31: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 31: W.A.P to perform \n");
        }
    }class program32 {
        //question 32: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 32: W.A.P to perform \n");
        }
    }class program33 {
        //question 33: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 33: W.A.P to perform \n");
        }
    }class program34 {
        //question 34: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 34: W.A.P to perform \n");
        }
    }class program35 {
        //question 35: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 35: W.A.P to perform \n");
        }
    }class program36 {
        //question 36: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 36: W.A.P to perform \n");
        }
    }class program37 {
        //question 37: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 37: W.A.P to perform \n");
        }
    }class program38 {
        //question 38: W.A.P to perform
        static void Main(string[] args)
        {
            Console.WriteLine("Adnan Shafiq Mangoankar, TYIT - 333 \n");
            Console.WriteLine("question 38: W.A.P to perform \n");
        }
    }
}

