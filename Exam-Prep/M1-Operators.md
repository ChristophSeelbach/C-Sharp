# Exam Preparation 70-483 Programming in C#

## Null-coalescing and conditional operator

What is the ouput of this program?

```C#
class CSharp
{
    public int? x;
    public int? y;

    public CSharp(int? x)
    {
        this.x = x;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var c = new CSharp(10)?.y ?? new CSharp(20)?.x;
        var d = new CSharp(c ?? 100)?.x ?? 200;
        var e = d == 200 ? 1000 : 2000;

        Console.WriteLine($"{c} {d} {e}");
    }
}
```
