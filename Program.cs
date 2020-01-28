using System;
using System.Diagnostics;

namespace Project01_Introduction
{
    // All organizing structures use { and } to define their boundaries
    class L1_Program
    {
        // All .NET programs begin with the main method
        // It looks like this
        static void Main(string[] args)
        {
            // example 0 - first program
            // Console.WriteLine("Hello World!");
            // Console.ReadKey();
            // Debug.WriteLine("Hello World!");

            // obtaining user input
            // Console.WriteLine("Please provide your input");
            //string userInput = Console.ReadLine();

            // parsing to specific data types
            // int inputNumber = Convert.ToInt32(userInput);

            // parsing with error handling
            // Console.WriteLine("Please provide your input");
            // string userInputToCheck = Console.ReadLine();
            /*
            try
            {
                int inputNumberChecked = Convert.ToInt32(userInputToCheck);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            // example 1 - simple computation
            // M disambiguates between double and decimal
            /*
            decimal income = 10000000.45M;
            decimal taxRate = 0.1M;
            decimal taxLiability = income * taxRate;
            Debug.WriteLine("Tax liability is " + taxLiability);

            // example 2 - API usage
            double rate = 0.06;
            double doublingTime = Math.Log(2) / Math.Log(1 + rate);

            Debug.WriteLine("Doubling time is " + doublingTime + " years");
            */

            // Exercise 1
            // Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            // Eg. a=3, b=4, c=5. Area = 6

            //Write your code here
            Console.WriteLine("1/24/2020 CLASS EXERCISES");
            Console.WriteLine("Exercise 1: Calculate the area of a triangle using Heron's formula");

            Console.WriteLine("Please provide your input for a");
            string A = Console.ReadLine();
            double a = Convert.ToDouble(A);

            Console.WriteLine("Please provide your input for b");
            string B = Console.ReadLine();
            double b = Convert.ToDouble(B);

            Console.WriteLine("Please provide your input for c");
            string C = Console.ReadLine();
            double c = Convert.ToDouble(C);

            double s = (a + b + c) / 2;

            double Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("Area is" + Area);


            /*
             *
            // example 3 - selection
            /*
            if (income < 400000)
                taxLiability = 0;
            else
            {
                taxRate = 0.5M;
                taxLiability = taxRate * income;
            }

            Debug.WriteLine("Tax liability is " + taxLiability);
            */
            // example 4 - numeric input
            /*
            string incomeInput = Console.ReadLine();

            Debug.WriteLine("Thanks, you entered " + incomeInput);

            income = Convert.ToDecimal(incomeInput);
            if (income > 400000)
            {
                taxRate = 0.5M;
                taxLiability = taxRate * income;
            }
            else
            {
                taxLiability = 0;
            }

            Debug.WriteLine("Tax liability is " + taxLiability);

            */

            // Exercise 2
            // Input a number (n) from the user and check if it is even or odd.

            // Write your code here
            Console.WriteLine("Exercise 2 : Input a number and check if it is even or odd");

            Console.WriteLine("Please provide your input number");

            string D = Console.ReadLine();

            int d = Convert.ToInt32(D);

            if (d % 2 == 0)

                Console.WriteLine("Number is even");

            else

                Console.WriteLine("Number is odd");



            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.

            // Write your code here
            Console.WriteLine("Exercise 3 : Input 3 numbers  (f,g,h) and find the greatest of them");
            Console.WriteLine("Please provide your input for f");
            string F = Console.ReadLine();
            int f = Convert.ToInt32(F);

            Console.WriteLine("Please provide your input for g");
            string G = Console.ReadLine();
            int g = Convert.ToInt32(G);

            Console.WriteLine("Please provide your input for h");
            string H = Console.ReadLine();
            int h = Convert.ToInt32(H);

            if (f == g && g == h)
                Console.WriteLine("numbers are same");

            else if ( f > g && f > h)
                Console.WriteLine("f is greatest" +f);

            else if (g > f && g > h)

                Console.WriteLine("g is greatest" +g);

            else

                Console.WriteLine("h is greatest" +h);



            /*
            // example 5 - loop
            bool stopProgram = false;

            while (stopProgram == false)
            {
                Console.Write("Please enter income: $");
                income = Convert.ToDecimal(Console.ReadLine());

                if (income > 400000)
                {
                    taxRate = 0.5M;
                    taxLiability = taxRate * income;
                }
                else if (income >= 0)
                {
                    taxLiability = 0;
                }
                else
                {
                    stopProgram = true;
                }

                Console.WriteLine("Tax liability is " + taxLiability);
            } // end while loop
            */

            // Exercise 4
            // Input a value (n) from the user and calculate the sum of first n natural numbers.
            // Eg. n=5. sum = 1+2+3+4+5 = 15

            // Write your code here

            Console.WriteLine("Exercise 4 : Input a value (n) and calculate the sum of first n natural numbers.");
            Console.WriteLine("Please provide your input number");
            string N = Console.ReadLine();
            int n = Convert.ToInt32(N);

            int sum = 0;

            for (int i = 1; i <= n; i++)

            {
                sum = sum + i;
            }

            Console.WriteLine("Sum of first n natural numbers is" + sum);


            // Exercise 5
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            // *
            // **
            // ***
            // ****
            // *****

            // Write your code here
            Console.WriteLine("Exercise 5 : Input a value (n)  and display the following * patter");
            Console.WriteLine("Please provide your input number");
            string E = Console.ReadLine();
            int e = Convert.ToInt32(E);

            for (int i = 0; i < e; i++)
            {
                for (int j = 0; j <= i; j++)

                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }



            // Exercise 6
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            //     *
            //    **
            //   ***
            //  ****
            // *****

            // Write your code here
            Console.WriteLine("Exercise 6 : Input a value (n)  and display the following * patter");
            Console.WriteLine("Please provide your input number");
            string P = Console.ReadLine();
            int p = Convert.ToInt32(P);

            for (int i = 1; i <= p; i++)
            {
                for (int j = p-1; j >=i; j--)

                {
                    Console.Write(" ");
                }
                for (int z = 1; z<=i; z++)

                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }



            // example 6 - method
            // income = Convert.ToDecimal(Console.ReadLine());
            // taxLiability = ComputeTaxes(income);
            // Debug.WriteLine("Tax liability is " + taxLiability);


            // Exercise 7
            // Write a method that accepts a parameter (n) and returns the sum of first n natural numbers.

            // Write your code here

            Console.WriteLine("Exercise 7 : Input a value (n) and calculate the sum of first n natural numbers.");
            Console.WriteLine("Please provide your input number");
            string K = Console.ReadLine();
            int k = Convert.ToInt32(K);

            int sum_n = 0;

            for (int i = 1; i <= k; i++)

            {
                sum_n = sum_n + i;
            }

            Console.WriteLine("Sum of first n natural numbers is" + sum_n);


            // example 7 - arrays
            /*
            decimal[] incomes = new decimal[] { 100.0M, 234532, 2443245.1M, 123443 };

            for (int i = 0; i < 4; i++)
            {
                Debug.WriteLine(incomes[i]);
            }
            */

            // Exercise 8
            // Enter n numbers in an array and print all the even numbers.

            // Write your code here
            Console.WriteLine("Exercise 8 : Enter n numbers in an array and print all the even numbers");
            Console.WriteLine("Please provide total number (n) in an array ");
            string M = Console.ReadLine();
            int m = Convert.ToInt32(M);
            int[] arr = new int[m];

            Console.WriteLine("Please provide your n input numbers");

            for (int i = 0; i < m; i++)
            {
                
                    arr[i] = Convert.ToInt32(Console.ReadLine());
               
            }

            Console.WriteLine("Your array is");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Even numbers are");
            for (int i = 0; i < m; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.WriteLine(arr[i]);
            }

            // Exercise 9
            // Enter n numbers in an array and find the highest and the smallest number.

            // Write your code here
            Console.WriteLine("Exercise 8 : Enter n numbers in an array and find the highest and the smallest number");
            Console.WriteLine("Please provide total number (n) in an array ");
            string O = Console.ReadLine();
            int o = Convert.ToInt32(O);
            int[] arra = new int[o];

            Console.WriteLine("Please provide your n input numbers");

            for (int i = 0; i < o; i++)
            {

                arra[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Your array is");
            foreach (int item in arra)
            {
                Console.WriteLine(item);
            }
          
           
            int large = arra[0];
            int small = arra[0];
            for (int i = 1; i < n; i++)
            {
                if (arra[i] > large)
                    large = arra[i];
                else if (arra[i] < small)
                    small = arra[i];
            }
            Console.WriteLine("Largest element in the array is "+ large);
            Console.WriteLine("Smallest element in the array is "+ small);

        }
        /*
         static decimal ComputeTaxes(decimal income)
         {
             decimal taxLiability;
             decimal taxRate;

             if (income < 400000)
                 taxLiability = 0;
             else
             {
                 taxRate = 0.5M;
                 taxLiability = taxRate * income;
             }

             return taxLiability;
         }
         */

    }
}