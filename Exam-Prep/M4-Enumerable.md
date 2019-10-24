# Exam Preparation 70-483 Programming in C#

## Enumerable 1

The `Next` method should return a random number. `Next` can be used inside a foreach. 

```C#
class RandomGenerator {
    public IEnumerable<int> Next(int seed) {
        // TODO
    }
}
```

## Enumerable 2

How to make RandomGenerator enumerable (e.g. in a `foreach`). Please specify the required steps. Each present a part of the completed solutions.

```C#
class RandomGenerator {
}
```

Please pick from the following options
1. Implement `IEnumerable<int>`
1. Implement `IEnumerator<int>`
1. Implement `IForEach<int>`
1. Implement `IEnumerator<int> GetEnumerator()`
1. Implement `IEnumerator GetEnumerator()`
1. Implement `IForEach<int> Next()`
1. Implement `IForEach<int> Iterate()`

