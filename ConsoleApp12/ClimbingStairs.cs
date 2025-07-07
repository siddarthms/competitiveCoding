using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class ClimbingStairs // BEST APPROACH IS FIBANOCCI SERIES 
    {
        internal void init()
        {

            int res = CountWays(3);

        }
        private int CountWays(int n)
        {

            if (n == 0)
                return 1;

            if (n < 0)
                return 0;

            int takeOneStep = CountWays(n - 1);
            int takeTwoSteps = CountWays(n - 2);

            return takeOneStep + takeTwoSteps;
        }
    }
}
//RECRUSSION TREE 
//                                 (3, [])
//                                /        \
//                          +1 /             \ +2
//                           /                 \
//                (2, [1])                   (1, [2])
//               /       \                   /       \
//         +1  /         \ +2         +1  /           \ +2
//           /             \             /               \
//   (1, [1,1])        (0, [1,2])   (0, [2,1])        (-1, [2,2])
//      /     \        
// +1 /       \ +2     
//   /           \      
// (0,[1,1,1])  (-1,[1,1,2])

//CountWays(3)
//├── CountWays(2)
//│   ├── CountWays(1)
//│   │   ├── CountWays(0) → 1 ✅
//│   │   └── CountWays(-1) → 0 ❌
//│   └── CountWays(0) → 1 ✅
//├── CountWays(1)
//│   ├── CountWays(0) → 1 ✅
//│   └── CountWays(-1) → 0 ❌


// BEST APPROACH IS FIBANOCCI SERIES 

//Start with small n values: n is the no of stairs

//➤ n = 1:
//Only one way → 1

//➤ n = 2:
//1 + 1 
//2
//→ 2 ways

//➤ n = 3:
//1 + 1 + 1
//1 + 2
//2 + 1
//→ 3 ways

//➤ n = 4:
//1 + 1 + 1 + 1
//1 + 1 + 2
//1 + 2 + 1
//2 + 1 + 1
//2 + 2
//→ 5 ways


//🧠 Why? reach n=0 is 1 way 
//Because we’re counting the number of valid ways to reach a goal.
//So, if:
//🎯 Your goal is to reach step 0
//🧍 You're already at step 0
//Then guess what?
//✅ You have already succeeded — 1 valid way (by taking no steps)
