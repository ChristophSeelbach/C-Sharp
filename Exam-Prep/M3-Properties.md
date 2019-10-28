# Exam Preparation 70-483 Programming in C#

## Properties

```C#
class Hero {
    public Hero(string fname, string lname) {
        this.FirstName = fname;
        this.LastName = lname;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Fullname { get => $"{LastName}, {FirstName}"; }
}
```

The `FirstName` and `LastName` properties can only be changed inside of the class `Hero` or within a class derived from the `Hero` class.

Which of the following options would meet the requirements:

1. Add `protected` access modifier to `set`.
2. Change access modifier from `public` to `protected` and set the `get` method to `public`.
3. Change the properties to fields.
4. Add `private` access modifier to `get`.
5. Remove the `set` method of `FirstName` and `LastName`.
