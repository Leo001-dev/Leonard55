1a. Here's a code snippet to declare and initialize an array in C#:
```csharp
int[] myArray = { 1, 2, 3, 4, 5 };
```
1b. Here's a code snippet to declare and initialize a two-dimensional array in C#:
```csharp
int[,] my2DArray = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
```
1c. Here's a code snippet to traverse an array in C#:
```csharp
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}
```
1d. Here's a code snippet to concatenate a string of an array in C#:
```csharp
string myString = string.Join(",", myArray);
```