﻿
string[] arr1 = new string[5] {"1234", "1567", "-2", "computer science", "world"};
string[] arr2 = new string[arr1.Length];

SecondArray(arr1, arr2);
PrintArray(arr2);

void SecondArray(string[] arr1, string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
