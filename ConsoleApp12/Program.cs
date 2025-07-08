using ConsoleApp12;
using System.Data.SqlTypes;

class Program
{
    public static void Main(string[] args)
    {
       
        var input = Console.ReadLine();


        dynamic Executor = input switch
        {
            "1" => new BubbleSort(),
            "2" => new ValidParenthesis(),
            "3" => new RemoveDuplicateInArrayAndString(),
            "4" => new CapitalizeTheFirstLetterOfSentance(),
            "5" => new FrequencyOfEachLetterInAString(),
            "6" => new FrequencyOfEachWordInAString(),
            "7" => new CountWordsInAString(),
            "8" => new ConvertToTitleCase(),
            "9" => new IsTheArrayIsSorted(),
            "10" => new BalacedParenthesis(),
            "11" => new RotateArrayBy_N_Places(),
            "12" => new FindTheFirstAndSecondLargestElementInAnArray(),
            "13" => new MoveZerosToENd(),
            "14" => new MaxConsecutiveOccurenceOf1(),
            "15" => new FindNumberAppereancingOnceInATwiceArray(),
            "16" => new FindTheMissingElementInAnArray(),
            "17" => new LongestSubArrayWithSumK(),
            "18" => new _2Sum(),
            "19" => new MajorityElementsNBy2Times(),
            "20" => new MaxSubArraySum(),
            "21" => new LongestConsecutiveSubArray(),
            "22" => new BuyAndSellStocks(),
            "23" => new LeadersInArray(),
            "24" => new PrimeNumbers(),
            "25" => new CircularArray(),
            "26" => new GenerateCombinations(),
            "27" => new StringCompression(),
            "28" => new LongestSubarrayWithoutRepeatingCharacters(),
            "29" => new LongestCommonPrefix(),
            "30" => new NextGreaterElementOfEachElemet(),
            "31" => new CheckifStringisRotationofAnother(),
            "32" => new CheckTheInputIsPanagram(),
            "33" => new PalindromicPairs(),
            "34" => new Sortanarraycontaining0_s_1_sand2_s(),
            "35" => new MajorityElementsNBy3Times(),
            "36" => new ClimbingStairs(),
            "37" => new LongestSubstringWithAlmostKDistinctCharacters(),
            _ => throw new Exception("Invalid Input")
        };

        Executor.init();
    }

}





