using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        const int hourGlassWidth = 3;
        const int hourGlassHeight = 3;

        int[][] arr = new int[6][];
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        }

        var biggestSum = int.MinValue;
        for (var i = 0; i <= arr.Length - hourGlassHeight; i++)
        {
            for (var j = 0; j <= arr[i].Length - hourGlassWidth; j++)
            {
                var sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] // first row
                               + arr[i + 1][j + 1] // second row
                               + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]; // third row
                biggestSum = sum > biggestSum ? sum : biggestSum;
            }
        }

        Console.Write(biggestSum);
    }
}
