using System;
using System.Threading;

namespace Microffer
{
    internal class InstanceChecker
    {
        static Mutex mutex = new Mutex(false, "Microffer");
        static bool taken;

        public static bool TakeMemory()
        {
            return taken = mutex.WaitOne(0, true);
        }

        // Освбождение памяти
        public static void ReleaseMemory()
        {
            if (taken)
                try { mutex.ReleaseMutex(); } catch { }
        }
    }
}
