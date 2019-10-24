# Exam Preparation 70-483 Programming in C#

## Monitoring

```c#
void SetupCategoryIfNotExists() {
    if ( A.Exists("AverageCounter64SampleCategory") ) 
        return;
    
    var b = new B();

    // Add the counter.
    var c = new C();
    c.CounterType = E;
    c.CounterName = "AverageCounter64Sample";
    b.Add(c);

    // Add the base counter.
    var d = new D();
    d.CounterType = F;
    d.CounterName = "AverageCounter64SampleBase";
    b.Add(d);

    // Create the category.
    A.Create("AverageCounter64SampleCategory",
        "Demonstrates usage of the AverageCounter64 performance counter type.",
        PerformanceCounterCategoryType.SingleInstance, counterDataCollection);
}
```

The performance counter shows the average number of operations completed during each second of the sample interval.

Please select for each placeholder the correct class:
* A
* B
* C
* D
* E
* F

Possible Values:
1. CounterCreationDataCollection
1. CounterCreationData
1. CounterSample
1. PerformanceCounterCategory
1. PerformanceCounterType.AverageCount64
1. PerformanceCounterType.RateOfCountsPerSecond64

