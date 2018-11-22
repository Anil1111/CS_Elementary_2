using System;
using System.Diagnostics;

using static System.Console;
using static System.Diagnostics.Process;

namespace _001_MonitoringLib
{
    public class Recorder
    {
        static Stopwatch timer = new Stopwatch();
        static long bytesPhysicalBefore = 0;
        static long bytesVirtualBefore = 0;

        public static void Start()
        {
            // Вся выделенная в настоящий момент память
            // будет собрана до записи количества использованной памяти.
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            bytesPhysicalBefore = GetCurrentProcess().WorkingSet64;
            bytesVirtualBefore = GetCurrentProcess().VirtualMemorySize64;
        }

        public static void Stop()
        {
            timer.Stop();

            long bytesPhysicalAfter = GetCurrentProcess().WorkingSet64;
            long bytesVirtualAfter = GetCurrentProcess().VirtualMemorySize64;

            WriteLine("Stoped Recording");
            WriteLine($"{bytesPhysicalAfter - bytesPhysicalBefore:N0} physical bytes used");
            WriteLine($"{bytesVirtualAfter - bytesVirtualBefore:N0} physical bytes used");

            WriteLine($"{timer.Elapsed} time span ellapsed");
            WriteLine($"{timer.ElapsedMilliseconds} total milliseconds ellapsed");

        }
    }    
}
