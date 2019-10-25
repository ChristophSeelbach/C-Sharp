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

`FirstName` and `LastName` can not be change outside of the class and its derivated classes.
Which of the following options would meet the requirements:
1. Add `protected` access modifier to `set`.
2. Change access modifier from `public` to `protected` and set the `get` method to `public`.
3. Change the properties to fields.
