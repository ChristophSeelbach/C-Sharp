# Exam Preparation 70-483 Programming in C#

## LINQ

```C#
class Program {
    static void Main(string [] args) {
        var dataSource = new [] { 1, 2, 3, 4, 5, 6, 7, 8};

        // TODO: var result = 

        foreach(var item in result)
            Console.WriteLine(item);
    }
}
```

Write a LINQ query statement, that returns the square value for every even number in the array `dataSource` (output: `4 16 36 64`), which can used to replace the TODO.

Write the same statement with extension methods.

## LINQ

```C#
class Program {
    static void Main(string [] args) {
        var dataSource = new [] { 
            12, 11, 1, 2, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10, 11 
        };

        // TODO: var result = 

        foreach(var item in result)
            Console.WriteLine(item);
    }
}
```

Write a LINQ extension method statement as replacement for the TODO, that returns a new array from `dataSource` with the following characteristics:

1. take only the distinct and even numbers of `dataSource`
2. the new list is sorted ascending,
3. take only the first 4 number and return it's square root
