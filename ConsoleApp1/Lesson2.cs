using System;

namespace ConsoleApp1
{
    class Lesson2
    {
        // ---------- Lesson 2
        // SOLUTION Lesson 2.1
        public int[] solution(int[] A, int K)
        {
            // Anteckningar
            // En Array A innehållande integers, har 0-100 platser. Varje plats kan vara -1000 till 1000.
            // Antal steg K, kan vara en int 0-100

            // check if array is empty
            if (A.Length != 0)
            {
                // debug, print array
                Console.WriteLine("Array: ");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine(A[i]);
                }

                // loop K times
                for (int x = 0; x < K; x++)
                {
                    int lastOne = A.Length - 1;
                    int lastValue;

                    // value of last index saved(the value will be overritten but we need it for index 0)
                    lastValue = A[lastOne];

                    for (int i = A.Length - 1; i > 0; i--)
                    {
                        // move all values 1 step
                        A[i] = A[i - 1];

                    }

                    // value of first index is replaced with value of last index
                    A[0] = lastValue;

                }

                // debug, print array. All values moved
                Console.WriteLine("Array: ");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine(A[i]);
                }

            }
            else
            {
                Console.WriteLine("empty");
            }

            // return array when done
            return A;

        }

    }
}
