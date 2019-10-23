# Exam Preparation 70-483 Programming in C#

## Passing by Values and Passing by References 

```c#
class Program {
    public static void Swap(int a, int b) {
        var c = a;
        a = b;
        b = c;
    }

    public static void Swap(ref int a, ref int b) {
        Swap(a, b);
    }

    public static void Main() {
        int x = 8, y = 16;
        Console.WriteLine("{0} {1}", x, y);

        Swap(x, y);
        Console.WriteLine("{0} {1}", x, y);

        Swap(ref x, ref y);
        Console.WriteLine("{0} {1}", x, y);
    }
}
```

## `ref` and `out`

What is the difference between `ref` and `out`?
