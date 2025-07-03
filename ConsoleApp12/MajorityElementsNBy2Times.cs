using System;

namespace ConsoleApp12
{
    internal class MajorityElementsNBy2Times
    {
        internal void init()
        {
            int[] input = new int[] { 7, 7, 5, 2, 5, 1, 5, 7, 5, 5, 7, 7, 5, 5, 5, 5 };

            int candidate = 0;
            int count = 0;

            // Step 1: Find the candidate
            for (int i = 0; i < input.Length; i++)
            {
                if (count == 0)
                {
                    candidate = input[i];
                    count = 1;
                }
                else if (input[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            // Step 2: Validate the candidate
            count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == candidate)
                    count++;
            }

            if (count > input.Length / 2)
                Console.WriteLine($"Majority element using Moore's Voting Algorithm is: {candidate} with count: {count}");
            else
                Console.WriteLine("No majority element found.");
        }
    }
}

/*
✅ If a number truly appears more than n/2 times:
👉 Moore's Voting Algorithm will definitely return it as the candidate — and validation will confirm it.

❌ If no such number exists:
👉 Moore's Voting may return a random “survivor” — not guaranteed to be the most frequent at all.
*/
