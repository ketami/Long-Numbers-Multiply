using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int b = 10;
            int[] u = { 2, 3, 4, 1, 2, 3, 1 };
            int n = u.Length;
            int[] v = { 1,0,2,0,3,4,0, 1,6,3,4,5,2,6,1,3, 1 };
            int m = v.Length;
            int[] ans = new int[u.Length + v.Length];
            for (int k = 0; k < m; k++)
            {
                Console.Write(v[k]);

            }
            Console.Write("\n");
            for (int k = 0; k < n; k++)
            {
                Console.Write(u[k]);

            }
            Console.Write("\n");
            for (int k = 0; k < ans.Length; k++)
            {
                ans[k] = 0;

            }
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    int t = u[i] * v[j];
                    ans[i + j] += t;
                }
            }

            int cache = 0;
            int[] answer = new int[m + n];
            for (int k = (ans.Length); k > 0; k--)
            {
                int t = ans[k - 1] + cache;
                cache = t / b;
                answer[ans.Length - k] = answer[ans.Length - k] + t % b;

            }
            if (answer[0] == cache)
            {
                for (int iter = 1; iter < answer.Length; iter++)
                {
                    Console.Write(answer[answer.Length - iter]);
                }
                return;

            }
            else
            {
                Console.Write(cache);
                for (int iter = 1; iter < answer.Length; iter++)
                {
                    Console.Write(answer[answer.Length - iter]);
                }
                return;
            }

        }
    }
}