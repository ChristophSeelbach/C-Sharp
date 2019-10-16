# Lab - Console Calculator

## Objective
The objective of this lab is to understand the usage of:
* Loops
* Exceptions
* Reusing Methods

## Exercise
Creating a basic Console Calculator

### User enters one of the supported operators (+, -, *, /)
* Repeat this as long as the input is not a supported operators.

### Retrieve 2 operands from the Console
* `Console.ReadLine`
* `int.Parse`
* Use a `while(true)` loop to enforce the user to enter a valid value.
* Create a method, that you can use for retrieving the first and second operand.
* Exception
* Optional: `Console.Beep`

###	Create for each operation a dedicated method.

###	Print error in red and the result in green
* `Console.ForegroundColor`
* `Console.ResetColor`
* Define a custom method, that has a default color parameter

### Create an endless loop, so that the user can repeat everything many times
* Entering operation, retrieving numbers, performaning and printing result


## Bonus Exercise

###	Allow the user to enter a variable amount of numbers.
* Print out the invalid ones and work with the valid part.
* `String.Split(" ")`
* Optional: Use variable parameter list `params`

