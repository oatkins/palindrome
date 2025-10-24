# Palindrome C# Coding Exercise

## Introduction

Thank you for visiting the Palindrome C# coding exercise.

A *palindrome* is “a word, phrase, number, or other sequence of symbols or elements, whose meaning may be interpreted the same way in either forward or reverse direction.”

The program shown below is intended to find the number of palindromes in a text file, “UKACD17.TXT” where each line in the file contains a single word or phrase. You have been assigned to do the code review for the program.

## Code Review

Take a look at the code below. *Without running it,* answer the questions that follow it. Please **do not use AI** for this part of the exercise.

```csharp
namespace Palindrome;

public class Program
{
    public static void Main()
    {
        int c = 0;

        string[] l = File.ReadAllLines("UKACD17.TXT");
        for (int i = 0; i < l.Length; i++)
        {
            string ll = l[i];
            if (T(ll))
            {
                Console.WriteLine(ll);
                c++;
            }
        }

        Console.WriteLine("Found {0} palindromes.", c);
        Console.ReadLine();
    }

    private static bool T(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return false;
        return s.Length == 1 || (s[0] == s[s.Length - 1] && T(s.Substring(1, s.Length - 2)));
    }
}
```

* List as many problems with or observations regarding the above code as possible.
* *Without running the code,* decide whether or not you think it will correctly find palindromes.

**Hint:** The function `T()` is intended to evaluate whether a string is a palindrome. It is a recursive function. The following worksheet demonstrates that the function correctly identifies that “blob” is not a palindrome.

| Iteration | Input | s.Length | s[0] | s[s.Length - 1] | s[0] == s[s.Length - 1] | s.Substring(1, s.Length - 2) |
|-----------|-------|----------|------|-----------------|-------------------------|------------------------------|
| 1         | blob  | 4        | b    | b               | TRUE                    | lo                           |
| 2         | lo    | 2        | l    | o               | **FALSE**               |                              |

## Refactoring

Refactor the code to address your concerns.

The most convenient way to do that is to fork the repository in GitHub and send a pull request containing your suggestions. Alternatively, just zip up your code and email it to the person who asked you to complete this exercise.

You may use AI for this part of the exercise. If you do, explain what prompts you used, and how you evaluated the AI model’s suggestions. (Include that information in your PR or email.)

Hints and suggestions:

* The majority of the code for the above program is in the console application’s Main method. Refactor it to use a more object oriented approach, with at least one new class.

* The original program uses a large text file as the input. Your refactored program should do the same, but it should be easy to modify the program to read its input from, say, a SQL database instead.

* The input data could be very large. Your program will be run on a machine with limited memory.

* This program counts palindromes. Refactor the program in such a way that it would be easy to modify it to count strings that match other rules, for example, all strings containing only consonants. Your program should still count palindromes; just make it easy to change the logic in the future.

* If you are familiar with automated testing, write tests for your refactored program.
