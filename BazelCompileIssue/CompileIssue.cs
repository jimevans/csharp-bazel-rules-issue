using System.Runtime.InteropServices;

namespace BazelCompileIssue
{
    public class CompileIssue
    {
        public string ShowIssue()
        {
            string platformValue = "Not macOS";
            // Changing the if condition to not reference things
            // in the System.Runtime.InteropServices namespace
            // allows the code to compile both in Visual Studio
            // and under Bazel using the Brightspace C# rules.
            // if (false)
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                platformValue = "macOS";
            }

            return platformValue;
        }
    }
}
