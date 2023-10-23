# UoR-Melliora
Code Challenge from University of Rochester, School of Nursing. 

## Description
Write a program that counts from 1 to 50. 
- When the number is a multiple of 3, print `Nursing`. 
- When the number is a multiple of 7, print `Meliora`. 
- If the number is a multiple of both 3 and 7, print `Nursing Meliora`. 
- If the number is not a multiple of either 3 or 7, just print the number.  

Use a separate project to provide the output. You may use any type of project / display / interface you feel would be interesting.

## Solution
The solution includes a `NumberUtils` library with Interfaces and Implementations allowing to customize, extend and reuse the code.
- Interfaces:
  - `IMultipleChecker`: _Interface for checking if a number is a multiple of a given number._
  - `INumbersProvider`: _Interface for providing a sequence of numbers defined by a start and end number._
  - `ITextProvider`: _Interface for providing a text representation of a number._
- Implementations:
  - `MultipleChecker` and `MultipleCheckerSupportingZero`: _Implementation of IMultipleChecker._
  - `TextProvider`: _Implementation of `ITextProvider`. This implementation returns a string representation of a number._
  - `NumbersProvider`: _Implementation of `INumbersProvider`. This implementation returns an enumerable of integers_
  - `MelioraTextProvider`: _Derived from `TextProvider`. Uses an IMultipleChecker to return the text expected by this challenge for each number._
  - `MilioraNumbersProvider`: _Implementation of `INumbersProvider`. Uses `NumbersProvider` as `INumbersProvider` to get the range of numbers, and `MelioraTextProvider` as `ITextProvider` to return the text expected by this challenge._

The solution also includes a Console Application that uses _Dependency Injection_ and the _NumberUtils_ library to print the output to the console.