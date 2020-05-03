using System;
using System.Collections.Generic;

namespace tests
{
    class Program
    {
        static public int[] TwoSum()
        {
            int[] nums = { 0, 7, 4, 15 };
            int target = 11;

            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = 0; y < nums.Length; y++)
                {
                    if (nums[x] + nums[y] == target)
                        return new[] { x, y };
                }
            }
            return null;
        }

        static int maxValue()
        {
            int[] ar = { 5, 8, 10, 6, 14, 88 };
            int max = 0;
            for (int x = 0; x < ar.Length; x++)
            {
                int tmp = ar[x];
                if (tmp > max)
                    max = tmp;
            }
            return max;
        }
        //bubble sort
        static void sortAr()
        {
            int[] ar = { 88, 8, 10, 6, 14, 5 };
            for (int x = 0; x < ar.Length - 1; x++)
            {
                for (int y = 0; y < ar.Length - 1; y++)
                {
                    if (ar[y] > ar[y + 1])
                    {
                        int temp = ar[y];
                        ar[y] = ar[y + 1];
                        ar[y + 1] = temp;
                    }
                }
            }
            for (int y = 0; y < ar.Length; y++)
            {
                Console.WriteLine(ar[y]);
            }
        }
        //SELECTION SORT
        static void pickerSort()
        {
            int[] ar = { 88, 8, 6, 14, 5, 1, 40, 42, -5879, -568, 0 };

            for (int x = 0; x < ar.Length; x++)
            {

                for (int y = x; y < ar.Length; y++)
                {
                    int min = ar[y];
                    if (min < ar[x])
                    {
                        int tmp2 = ar[x];
                        ar[x] = min;
                        ar[y] = tmp2;
                    }

                }

            }
            for (int y = 0; y < ar.Length; y++) { Console.WriteLine(ar[y]); }
        }
        static int multiplyNum(int num)
        {
            if (num > 0)
                return num * num;

            else
                return 0;
        }

        static void print()
        {
            String x;
            //Math.Round(Math.PI, 6);
            Console.WriteLine(Math.Round(Math.PI, 6));
        }

        static void strManipulation()
        {
            String input = "17";
            int count = Convert.ToInt32(input);
            ++count;
            Console.WriteLine(count);
        }

        int sumInts(String input)
        {
            //Char[] cArray = new char[input.Length];
            //cArray = input.ToCharArray();
            int sum = 0;
            for (int x = 0; input.Length > x; x++)
            {

                sum += Convert.ToInt32(Char.GetNumericValue(input[x]));
            }
            //Console.WriteLine("sum is " + sum);
            return sum;

        }

        public int Collatz(int n)
        {
            if (n == 1)
                return 1;

            else if (n % 2 == 0)
                return Collatz(n / 2) + 1;

            return Collatz((3 * n + 1)) + 1;
        }

        public int Murder(int[] arr, int k)
        {
            var seen = new List<int>();
            int start = -1;

            while (seen.Count < arr.Length - 1)
            {
                start += k;
                if (seen.Contains(start))
                {
                    start += 1;
                }
                if (start > arr.Length - 1)
                {
                    start %= arr.Length;
                }
                if (!seen.Contains(start))
                {
                    seen.Add(start);
                }


            }
            return 5;
        }

        public double DreamHorse(int attempts)
        {
            double baseChance = 0.98;
            double oddsOfgettingHorse = baseChance;
            for (int x = 0; x < attempts; x++)
            {
                if (x != 0)
                {
                    baseChance = (baseChance - (.002));
                }
                oddsOfgettingHorse *= baseChance;
            }

            return (1 - oddsOfgettingHorse) * 100;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string t = "nooooo";

            int attempt = 30;
            double chance = p.DreamHorse(attempt);
            Console.WriteLine("chance of getting horse with " + attempt + "attempts is " + chance);

        }

    }
}
