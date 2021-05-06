using System;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("대성마이맥 수학 점수");

            int[] scores = new int[10];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 94;
            scores[4] = 100;
            scores[5] = 40;
            scores[6] = 55;
            scores[7] = 96;
            scores[8] = 70;
            scores[9] = 88;

            int sum = 0;
            /*for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }*/
            foreach (var item in scores)
            {
                sum += item;
            }
            float average = (float)sum / scores.Length;

            Console.WriteLine($"수학 점수 총합 : {sum}, 평균 : {average}");
        }
    }
}
