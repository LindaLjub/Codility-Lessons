using System;

namespace ConsoleApp1
{
    class Lesson1
    {
        // ---------- Lesson 1
        // SOLUTION 1, lesson 1 (Not optimal)
        public int solution(int N)
        {

            // int to binary
            int b = 2;
            string binaryForm = Convert.ToString(N, b);

            // debug, see if its binary
            Console.WriteLine(binaryForm);

            // split to array
            var charArray = binaryForm.ToCharArray();

            // find longest "binary gap" of zeros
            int lengthOfArray = charArray.Length - 1;

            // debug
            Console.WriteLine(lengthOfArray);

            int count = 0;
            int countTemp = 0;

            for (int i = 0; i < lengthOfArray; i++)
            {
                // search for zeros
                if (charArray[i] == '0')
                {
                    count++;

                    // as long as the index +1 is a zero
                    while (charArray[i + 1] == '0')
                    {
                        count++;
                        i++;

                        // to avoid errors if the last number is a zero
                        if (i >= lengthOfArray)
                        {
                            countTemp = 0;
                            count = 0;
                            break;
                        }
                    }

                }

                // if this "binary gap" is longer then the last one
                // To make sure we are finding the longest gap
                if (count > countTemp)
                {
                    countTemp = count;
                }

                // reset after each int, go to the next one
                count = 0;
            }

            // debug
            Console.WriteLine(countTemp);

            // return the number of zeros in the longest binary gap
            return countTemp;
        }

        // SOLUTION 2, lesson 1 (Best solution)
        public int solution_two(int N)
        {
            // int to binary
            int b = 2;
            string binaryForm = Convert.ToString(N, b);

            // debug, see if its binary
            Console.WriteLine("Binary: " + binaryForm);

            // split to array
            var charArray = binaryForm.ToCharArray();

            // find longest "binary gap" of zeros
            int lengthOfArray = charArray.Length;

            // debug
            Console.WriteLine("length of array: " + lengthOfArray);

            int indexTemp = 0;
            int count = 0;
            int countTemp = 0;

            // find 1:s, find the longest gap
            for (int i = 0; i < lengthOfArray; i++)
            {
                // finds the first 1
                int index1 = Array.FindIndex(charArray, item => item == '1');

                // debug
                Console.WriteLine("first 1: " + index1);

                // if is exists a 1
                if (index1 >= 0)
                {
                    // switch the 1 to an X so I dont find the same one again.
                    charArray[index1] = 'X';

                    // calculate how long the gap is
                    count = (index1 - indexTemp) - 1;
                    indexTemp = index1;

                    // if this "binary gap" is longer then the last one
                    // To make sure we are finding the longest gap
                    if (count > countTemp)
                    {
                        countTemp = count;
                    }
                }
            }

            // debug
            Console.WriteLine("COUNT: " + countTemp);

            // return the number of zeros in the longest binary gap
            return countTemp;

        }
    }
}
