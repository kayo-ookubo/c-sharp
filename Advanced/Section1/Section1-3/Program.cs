using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Section103
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateAndUse();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void CreateAndUse()
        {
            var sample = new Sample();
            sample.Func1();
        }
    }
}