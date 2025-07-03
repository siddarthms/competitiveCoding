using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class MajorityElementsNBy3Times
    {
        internal void init()
        {
            int[] nums = { 1, 2, 3, 1, 2, 1 };

            var res = GetCandidates(nums);

            int counter1 = 0, counter2 = 0;

            for (int i = 0; i < nums.Length; i++)
            { 
                if(res.candidate1 == nums[i])
                    counter1++;
                else if(res.candidate2 == nums[i])
                    counter2++;
            }

            var tuple = (Candidate1: (int?)null, Candidate2: (int?)null);

            if (counter1 > nums.Length/3)
                tuple.Candidate1 = res.candidate1;

            if (counter2 > nums.Length / 3)
                tuple.Candidate2 = res.candidate2;



            Console.WriteLine($"Majority Elements: {tuple.Candidate1}, {tuple.Candidate2}");
        }

        (int candidate1, int candidate2) GetCandidates(int[] nums)
        {
            int count1 = 0, count2 = 0;
            int candidate1 = 0, candidate2 = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (count1 == 0 && candidate2 != nums[i])
                {
                    candidate1 = nums[i];
                    count1++;
                }
                else if (count2 == 0 && candidate1 != nums[i])
                { 
                    candidate2 = nums[i];
                    count2++;
                }
                else if (candidate1 == nums[i])
                    count1++;

                else if(candidate2 == nums[i])
                    count2++;
                else
                {
                    count1--;
                    count2--;
                }
            }

            return (candidate1 : candidate1 , candidate2: candidate2);
        }
    }
}
