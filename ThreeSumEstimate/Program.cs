﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSumEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                int N = int.Parse(arg);
                int[] a = new int[N];


                Random rnd = new Random();
                for (int i = 0; i < N; i++)
                    a[i] = rnd.Next(-100000, 100000);

                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                int cnt = ThreeSum.count(a);
                stopwatch.Stop();
                var time = stopwatch.Elapsed;

                Console.WriteLine($"{arg};{cnt};{time.TotalMilliseconds}");
            }
        }
    }
}
