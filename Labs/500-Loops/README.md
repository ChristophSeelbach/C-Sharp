# Lab - Magic Numbers

## Objective
The objective of this lab is to understand the usage of:
* Loops
* Conditions

## Exercise
Write a computer program name `MagicNumbers`, where the program picks a random number `q` between 0 - 1000. Afterwards the user has to guess `q`. Each time the user enters a number `n` that is not `q`, the program provide a hint whether the entered number was higher or lower than `q`.

### Task 1: The computer pick up a random number `q` between 0 - 1000
To create a Random number in C#, use the following snippet:
```
var rnd = new Random(); 
rnd.Next()
```

### Task 2: The user has to guess this number.
* Each time the user enters a incorrect number, the system provide him a hint, whether it is larger or smaller than `q`.

### Task 3: Allowing to repeat
* When the user finds the number, ask him if he would like to repeat the game.
* Use a `while(true)` - loop
