using System.Diagnostics;
using System.Reflection;

namespace LeetCode
{
    public static class MethodTimeLogger
    {
        public static void Log(MethodBase methodBase, TimeSpan timeSpan, string message)
        {
            Console.WriteLine($"{methodBase.Name}: {timeSpan}");
        }
    }
}
