using System;

namespace DataStructure
{
    class Program
    {
        static int GetHighestScore(int[] scores)
        {
            int high_score = 0;
            foreach(int score in scores)
            {
                if (high_score <= score)
                    high_score = score;
            }

            return high_score;
        }

        static int GetAverageScore(int[] scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            if (scores.Length == 0)
                return -1;

            sum /= scores.Length;

            return sum;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value)
                    return i;
            }

            return -1;
        }

        static void Sort(int[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[j] < scores[i])
                    {
                        int temp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = temp;
                    }
                }
            }
            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
        }

        static void Main(string[] args)
        {
            // 배열
            int[] scores = new int[5] { 10, 30, 40, 20 , 50};
            int high_score = GetHighestScore(scores);
            int avg_score = GetAverageScore(scores);
            int idx_score = GetIndexOf(scores, 50);
            Console.WriteLine(high_score);
            Console.WriteLine(avg_score);
            Console.WriteLine(idx_score);
            Sort(scores);
        }
    }
}
