# Variables

## Initialization

What is the output of the following code snippets?

```c#
int a;
Console.WriteLine(a);
```

## Implicit typed variables

### Task 1
What is the output of the following code snippets?

```c#
var b;
Console.WriteLine(b);
```

### Task 2
What is the output of the following code snippets?
```c#
var i = 12,
    d = 12.0;
Console.WriteLine(i);
Console.WriteLine(d);
```

## Implicit conversions

### Task 1
What is the output of the following code snippets?

```c#
int n = 12, // numerator
    d = 5;  // denominator
double a = n / d;
Console.WriteLine(a);
```

### Task 2
What is the output of the following code snippets?

```c#
int n = 12, // numerator
    d = 5;  // denominator
double b = (double) n / d;
Console.WriteLine(b);
```

### Task 3
What is the output of the following code snippets?

```c#
var c = 12 / 5;
Console.WriteLine(c);
```

## Explicit conversions (casts)

What is the difference between `as`-, `is`- and `()`-operator?
