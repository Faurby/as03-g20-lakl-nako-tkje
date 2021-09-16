# Assignment #3

## C&#35;

Clone this repository and bring the code pieces you need into your BDSA Assignments GitHub repository.

### Extension Methods

Consider the two methods you implemented last week:

```csharp
IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)

IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
```

Given the following collections in scope:

```csharp
IEnumerable<int>[] xs;

int[] ys;
```

Solve the following questions with extension methods (one-liners):

1. Flatten the numbers in `xs`.
2. Select numbers in `ys` which are divisible by `7` and greater than `42`.
3. Select numbers in `ys` which are *leap years*.

Write the answers in the ANSWERS.md file.

Implement and test the following extension methods:

1. A method `IsSecure` which extends `Uri` and returns true if the `Uri` is using *Secure Hypertext Transfer Protocol*.
1. A method `WordCount` which extends `string` and returns the number of words in the string. Note a word can only contain *unicode letters* (no numbers or symbols).

Use the supplied `Extensions.cs` and `ExtensionsTests.cs` files.

### Delegates / Anonymous methods

Implement the following anonymous functions using the built-in delegates and lambda expressions:

1. A method which takes a string and prints the content in reverse order (by character)
1. A method which takes two decimals and returns the product
1. A method which takes a whole number and a string and returns `true` if they are numerically equal. Note that the string `"  0042"` should return true if the number is `42`

Write the answers in the ANSWERS.md file.

You probably want to implement a set of tests to validate the methods.

Use the supplied `DelegatesTests.cs` file.

### LINQ

Prerequisite: Extend the `Wizards.csv` file with at least 10 wizard of your choosing to enable the queries above.
Examine the `Wizard` class and its corresponding unit test class.

Then, given the `Wizard` class:

```csharp
public class Wizard
{
    public string Name { get; set; }

    // Book or film or...
    public string Medium { get; set; }

    public int? Year { get; set; }

    public string Creator { get; set; }

    public static Lazy<IReadOnlyCollection<Wizard>> Wizards { get; } = new Lazy<IReadOnlyCollection<Wizard>>(() =>
    {
        var csv = File.OpenText("../../../../Wizards.csv");
        using (var reader = new CsvReader(csv))
        {
            reader.Configuration.Delimiter = ",";
            return reader.GetRecords<Wizard>().ToList().AsReadOnly();
        }
    });
}
```

Use the supplied `Queries.cs` and corresponding tests class to implement and test the following queries using LINQ:
(You need to wrap the queries in suitable methods for testing)

1. Wizards invented by *Rowling*. Only return the names.
1. The year the first *sith lord* was introduced. Let's define a *sith lord* to be one named Darth *something*.
1. Unique list of wizards from the *Harry Potter* books - only return name and year (as a value tuple).
1. List of wizard names grouped by creator in reverse order by creator name and then wizard name.

Each method *must* be implemented twice - once using only *extension methods* and once using as much *LINQ* as possible.
