using System;
using System.Linq;

namespace _02.RefactorWithBestPractice
{
    public class RefactorCode
    {
        public void PrintStatistics(double[] arr)
        {
            Console.WriteLine(this.FindMaxNumber(arr));
            Console.WriteLine(this.FindMinNumber(arr));
            Console.WriteLine(this.FindAvarage(arr));
        }

        private double FindAvarage(double[] numbers)
        {
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double avg = sum / numbers.Length;

            return avg;
        }

        private double FindMinNumber(double[] numbers)
        {
            double minNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }

        private double FindMaxNumber(double[] numbers)
        {
            double maxNumber = double.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }
    }
}
