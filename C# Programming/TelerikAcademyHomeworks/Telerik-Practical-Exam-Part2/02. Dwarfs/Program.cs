using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Dwarfs
{
    class Program
    {
        static int GetSum(int[] coins, int[] pattern)
        {
            int sum = coins[0];
            int coinsLenght = coins.Length;
            int patternLenght = pattern.Length;
            bool[] isVisited = new bool[coinsLenght];
            isVisited[0] = true;
            int patternIndex = 0;
            int coinIndex = 0;
            coinIndex = coinIndex + pattern[patternIndex % patternLenght];
            patternIndex++;

            while (coinIndex >= 0 && coinIndex < coins.Length && !isVisited[coinIndex])
            {
                int temp = patternIndex % patternLenght;
                isVisited[coinIndex] = true;
                sum = sum + coins[coinIndex];
                coinIndex = coinIndex + pattern[temp];
                patternIndex++;

            }
            return sum;
        }
        static int[] Split(string line)
        {
            string[] arrayToSplit = line.Split(new string[] { ", " }, StringSplitOptions.None);
            int[] splittedArray = new int[arrayToSplit.Length];
            for (int i = 0; i < arrayToSplit.Length; i++)
            {
                splittedArray[i] = int.Parse(arrayToSplit[i]);
            }
            return splittedArray;

        }
        static int GetMaxSum(int[] coins, int patternCount, int[][] pattern)
        {
            int maxSum = coins[0];
            for (int i = 0; i < patternCount; i++)
            {
                pattern[i] = Split(Console.ReadLine());
                int currSum = GetSum(coins, pattern[i]);
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }
            }
            return maxSum;
        }
        static void Main()
        {
            int[] coins = Split(Console.ReadLine());
            int patternCount = int.Parse(Console.ReadLine());
            int[][] pattern = new int[patternCount][];
            Console.WriteLine(GetMaxSum(coins, patternCount, pattern));
        }
  
        
    }
}
