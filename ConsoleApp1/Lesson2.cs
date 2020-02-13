using System;

namespace ConsoleApp1
{
    class Lesson2
    {
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

        // SOLUTION Lesson 2.2
        public int solution2(int[] A)
        {
            // Check that array is not empty
            if (A.Length != 0)
            {
                // Check that is is a odd number of numbers.
                if (A.Length % 2 != 0)
                {
                    // Right answer
                    int answer = 0;

                    // debug
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine(A[i] + " ");
                    }

                    // sortera array i nummerordning
                    Array.Sort(A);

                    // debug
                    Console.WriteLine("sorted: ");
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine(A[i] + " ");
                    }

                    // loop, check if number next to index is same (Should be same when sorted)
                    for (int i = 0; i < A.Length; i++)
                    {
                        // last number, must be "unpaired" if reached this index
                        if (i == (A.Length-1))
                        {
                            answer = A[i];
                            break;
                        }
                        else
                        {
                            // check is number next to index is the same, if not it is "unpaired"
                            if (A[i] == A[(i + 1)])
                            {
                                // jump 2 steps
                                i++;
                            }
                            else
                            {
                                answer = A[i];
                                break;
                            }
                        }

                    }

                    // return the number the thats not in a pair.
                    return answer;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }
    }
}
