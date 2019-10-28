# Exam Preparation 70-483 Programming in C#

## Rethrowing Exceptions
What is the difference between the following blocks

```C#
// Version 1
try {}
catch(Exception ex) {
    throw;
}
```

```C#
// Version 2
try {}
catch(Exception ex) {
    throw ex;
}
```

```C#
// Version 3
try {}
catch(Exception ex) {
    throw new Exception("Error caught", ex);
}
```

## Creating custom Exception
Which class should be use as the base class for custom Exceptions?

## Exceptions
Which block do you use, so that `OverflowException` are thrown?

* try
* unchecked
* checked
* using
