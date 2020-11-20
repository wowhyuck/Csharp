using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열
            //int[] scores = new int[5];
            //int[] scores = new int[] { 10, 20, 30, 40 , 50};
            //int[] scores = new int[5] { 10, 20, 30, 40 , 50};
            int[] scores = { 10, 20, 30, 40 , 50};
            int[] scores1 = scores;

            scores1[0] = 9999;

            // 0 1 2 3 4
            //scores[0] = 10;
            //scores[1] = 20;
            //scores[2] = 30;
            //scores[3] = 40;
            //scores[4] = 50;

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
        
            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
