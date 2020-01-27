using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Solution
    {
        // ---------- Lesson 1
        // SOLUTION 1
        public int solution(int N)
        {

            // gör om int till binary
            int b = 2;
            string binaryForm = Convert.ToString(N, b);

            // debug
            Console.WriteLine(binaryForm);

            // splitta till en array
            var charArray = binaryForm.ToCharArray();

            // hitta största binary gap av 0:or
            int lengthOfArray = charArray.Length - 1;

            // debug
            Console.WriteLine(lengthOfArray);

            int count = 0;
            int countTemp = 0;

            for (int i = 0; i < lengthOfArray; i++)
            {
                if (charArray[i] == '0')
                {
                    count++;

                    while (charArray[i + 1] == '0')
                    {
                        count++;
                        i++;

                        if (i >= lengthOfArray)
                        {
                            Console.WriteLine("nu");
                            countTemp = 0;
                            count = 0;
                            break;


                        }
                    }

                }

                if (count > countTemp)
                {
                    countTemp = count;
                }

                count = 0;

            }

            Console.WriteLine(countTemp);

            // returnera antal 0:or i största binary gap

            return countTemp;
        }

        // SOLUTION 2
        public int solution_two(int N)
        {

            // gör om int till binary
            int b = 2;
            string binaryForm = Convert.ToString(N, b);

            // debug
            Console.WriteLine("Binärtal: " + binaryForm);

            // splitta till en array
            var charArray = binaryForm.ToCharArray();

            // hitta största binary gap av 0:or
            int lengthOfArray = charArray.Length;

            // debug
            Console.WriteLine("längd array: " + lengthOfArray);

            int indexTemp = 0;
            int count = 0;
            int countTemp = 0;

            // hitta 1:or, räkna mellanrum
            for (int i = 0; i < lengthOfArray; i++)
            {
                // hittar första 1:an
                int index1 = Array.FindIndex(charArray, item => item == '1');

                // debug
                Console.WriteLine("Första 1:an: " + index1);

                if (index1 >= 0)
                {
                    // byt ut 1:an
                    charArray[index1] = 'X';

                    count = (index1 - indexTemp) - 1;
                    indexTemp = index1;

                    if (count > countTemp)
                    {
                        countTemp = count;
                    }
                }


            }

            // debug
            Console.WriteLine("COUNT: " + countTemp);

            // return gap
            return countTemp;

        }

        // ---------- Lesson 2




    }
}
