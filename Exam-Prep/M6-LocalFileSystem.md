# Exam Preparation 70-483 Programming in C#

## Local File System

```C#
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Get the directories currently on the C drive.
        var cDirs = new A(@"c:\").GetDirectories();

        // Write each directory name to a file.
        using (var b = new B("CDriveDirs.txt"))
        {
            foreach (A dir in cDirs)
            {
                b.WriteLine(dir.Name);

            }
        }
    }
}
```

Please replace the placeholder `A`, `B` with the following items:
1. DirectoryInfo
1. Directory
1. StreamWriter
1. FileInfo
1. File
