using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    class Test
    {

        //return the minimum amount of coins needed to match a value
        public int min(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            int[] cents = { 1, 5, 10, 25 };
            int minVal = 0;

            while (n != 0)
            {
                for (int x = cents.Length - 1; x >= 0; x--)
                {

                    if (cents[x] <= n)
                    {
                        n -= cents[x];
                        minVal++;
                    }
                }
            }
            return minVal;
        }
        private void betterRotate(int spaces, string direction)
        {
            //rotates to the right
            int[] arr = { 1, 2, 3, 4 };
            int[] rotatedArray = new int[arr.Length];
            if (direction == "r")
            {
                for (int x = spaces; x < (arr.Length + spaces); x++)
                {
                    rotatedArray[x % arr.Length] = arr[x - spaces];
                }
            }

            if (direction == "l")
            {
                for (int x = spaces; x < (arr.Length + spaces); x++)
                {
                    rotatedArray[x - spaces] = arr[x % arr.Length];
                }
            }

            foreach (int element in rotatedArray)
            {
                Console.Write($"{element} ");
            }
        }
        private void rotate(int spaces, string direction)
        {

            int[] arr = { 1, 2, 3, 4 };
            int[] rotated = new int[arr.Length];

            if (spaces > arr.Length && (spaces % arr.Length != 0))
                spaces %= arr.Length;

            if (spaces % arr.Length == 0 && spaces > arr.Length)
                spaces = arr.Length;

            switch (direction)
            {

                case "r":
                    for (int x = 0; x < arr.Length; x++)
                    {
                        int index = x + spaces;

                        if (spaces == arr.Length)
                            rotated[x] = arr[x];

                        if (x == arr.Length - 1)
                            index = spaces - 1;

                        if (index >= arr.Length && x != arr.Length - 1)
                            index -= arr.Length;

                        rotated[index] = arr[x];
                    }
                    break;

                case "l":
                    for (int x = 0; x < arr.Length; x++)
                    {
                        int index = x - spaces;

                        if (spaces == arr.Length)
                            rotated[x] = arr[x];

                        if (x == 0)
                            index = arr.Length - spaces;

                        if (index < 0 && x != 0)
                        {
                            index += arr.Length;
                            index = Math.Abs(index);
                        }

                        rotated[index] = arr[x];
                    }
                    break;



            }

            for (int y = 0; y < rotated.Length; y++)
            {
                Console.Write(rotated[y] + " ");
            }
        }
        public int trailingZero(int n)
        {
            long nfact = 1;
            int count = 0;

            for (int x = 1; x <= n; x++)
            {
                nfact *= x;
            }


            while (nfact % 10 == 0)
            {
                count++;
                nfact /= 10;
            }
            return count;
        }

        //write a method that takes int x and returns the sum of the first x odd numbers
        public int SumOfOddNums(int x)
        {
            int sum = 0;
            int count = 0;
            int i = 1;
            while (count != x)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    count++;
                }
                i++;
            }
            return sum;
        }

        //given a string return how many numerical numbers are in the string
        public int CountNums(string s)
        {
            int count = 0;

            foreach (char c in s)
            {
                if (Char.IsNumber(c))
                    count++;
            }
            return count;
        }


        static void Main(String[] ar)
        {
            Test t = new Test();
            //t.rotate(145, "l");
            //Console.WriteLine("\n");
            //Console.WriteLine("better array");
            //t.betterRotate(145, "l");

            learnIcompare comp = new learnIcompare("jay", 25);
            learnIcompare comp2 = new learnIcompare("ing", 25);
            //int x = comp.CompareTo(comp2);
            //Console.WriteLine(t.trailingZero(13));
            Console.WriteLine(t.CountNums("1800askgary"));

        }
    }
}
