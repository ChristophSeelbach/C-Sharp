# Exam Preparation 70-483 Programming in C#

## Events

```C#
class Program {
    // TODO

    public event OutOfMoneyHandler OutOfMoney;

    public int GiveMoney(int currentMoney, double longitude, 
    double latitude) {
        // ...
    }

    static void Main(string [] args) {
        OutOfMoney += GiveMoney;

        // ...

        OutOfMoney(0, 19.86, 20.00);
    }
}
```

Please complete the program, so that it will word as intended.
