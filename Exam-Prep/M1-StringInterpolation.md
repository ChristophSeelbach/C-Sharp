# Exam Preparation 70-483 Programming in C#

## String Interpolation and String.Format

The desired ouput is: "Hi Lightbringer, Uther. Today is the 24.12.3000. It is 10:00. Please pay your bill of 9000000.93$.".

```c#
var fname = "Uther";
var lname = "Lightbringer";

var dt = new DateTime(3000, 12, 24, 10, 00);
double price = 9000000.932;
```

Create a string interpolation, that generates the desired output.

Create a String.Format equivalent for the string interpolation.
