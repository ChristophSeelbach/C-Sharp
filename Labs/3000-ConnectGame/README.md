# Lab - Connect Game

## Objective
The objective of this lab is to understand the usage of:
* 3-dimensionsal Array
* Properties
* Static Methods
* Creating Class and Structs

## Exercise
Create a ConnectGame, where user can specify the length of the board and the length required for the winning state.

### Drawing the Board
* Console.Clear
* Console.Write
* Console.WriteLine
* Console.ForegroundColor
```c#
for (int r=0; r<this.rows; r++) {
    for(int c=0; c<this.cols; c++) {
        // ...
    }
}
```

### Create a ConnectGame class
* Create properties and fields to maintain the state of the game such as Board, Rows, Cols, ActivePlayer
* Create a constructor to initialize a new game.
* To simplify things, you should save the number of rows and cols of your board.
* Put the logic for drawing the board into this class

### Create custom exception for your game.
* Remember all exceptions need to inherit from `Exception`
* InvalidMoveException
* GameEndedException

### Parse user input and create a new Move object out of it
* Create a struct `Move` for move
* Use regular expression (RegEx.Match)
```c#
var input = Console.ReadLine();
var match = Regex.Match(input, "([0-9]+),?([0-9]+)");

if (!match.Success) {
    // Input does not fit the pattern
}

// Don't forget to parse the string to integer
var firstPart = match.Groups[1].Value;
var secondPart = match.Groups[2].Value;
```
