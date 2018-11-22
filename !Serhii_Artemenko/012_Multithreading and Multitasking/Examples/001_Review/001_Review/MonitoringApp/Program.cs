﻿using _001_MonitoringLib;
using System;
using System.Linq;
using static System.Console;


namespace _002_MonitoringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write("Press ENTER to start the timer: ");
            //ReadLine();
            //Recorder.Start();
            //int[] largeArrayOfInts = Enumerable.Range(1, 100000).ToArray();
            //Write("Press ENTER to stop the timer: ");
            //ReadLine();
            //Recorder.Stop();

            int[] numbers = Enumerable.Range(1, 50000).ToArray();
            Recorder.Start();
            WriteLine("Using string");
            string s = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                s += numbers[i] + ", ";
            }
            Recorder.Stop();
            Recorder.Start();
            WriteLine("Using StringBuilder");
            var builder = new System.Text.StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                builder.Append(numbers[i]);
                builder.Append(", ");
            }
            Recorder.Stop();
            ReadLine();


            ReadLine();
        }
    }
}
