# Understanding Algorithms Book

This project was created with the initiative of implementing the algorithms presented in the book "Understanding Algorithms" in C#. Its purpose is to study, practice, and deepen the understanding of fundamental algorithms and data structures through practical examples.

This repository contains a simple C# console application that demonstrates the binary search algorithm discussed in the book "Understanding Algorithms". The project is implemented as a .NET 10 console app and serves as a practical example of efficient searching in a sorted array.

## Overview

Binary search is an algorithm that finds a target value in a sorted array by repeatedly dividing the search interval in half. Its average time complexity is O(log n), making it much faster than linear search for large datasets.

## Project Structure

- `Program.cs`: entry point of the application.
- `BinarySearch.cs`: implementation of the binary search algorithm.
- `UnderstandingAlgorithmsBook.csproj`: project configuration.
- `UnderstandingAlgorithmsBook.slnx`: solution file.

## Requirements

- .NET 10 SDK

## How to Run

From the project directory, run:

    dotnet build
    dotnet run

## Example

The current sample uses the following sorted array:

    int[] arr = [1, 3, 5, 7, 9];
    int target = 11;

The program calls the `BinarySearch.Search` method and prints the result.

## Notes

- The input array must be sorted in ascending order.
- The method returns the zero-based index when the target is found, or `null` when it is not.