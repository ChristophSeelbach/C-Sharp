# Variables

## Initialization

```c#
int a;
Console.WriteLine(a);
```

## Implicit typed variables

```c#
var b;
Console.WriteLine(b);
```

```c#
var i = 12,
    d = 12.0;
Console.WriteLine(i);
Console.WriteLine(d);
```

## Type casting

```c#
int n = 12, // numerator
    d = 5;  // denominator
double a = n / d;
Console.WriteLine(a);
```

```c#
int n = 12, // numerator
    d = 5;  // denominator
double b = (double) n / d;
Console.WriteLine(b);
```

```c#
var c = 12 / 5;
Console.WriteLine(c);
```
