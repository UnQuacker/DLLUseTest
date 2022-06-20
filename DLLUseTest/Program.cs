using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DLLUseTest
{
    class Program
    {
        [DllImport("DLLTest.dll")]
        public static extern IntPtr Create();

        [DllImport("DLLTest.dll")]
        public static extern void TestWrite(IntPtr dll, string string1, string string2, StringBuilder newString);
        static void Main(string[] args)
        {
            IntPtr test = Create();
            string string1 = "1st string ";
            string string2 = "2nd string";
            StringBuilder newString = new StringBuilder();
            TestWrite(test, string1, string2, newString);
            Console.WriteLine(newString.ToString());
        }
    }
}
