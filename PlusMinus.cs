using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal positives = 0;
        decimal negatives = 0;
        decimal zeroes = 0;
        foreach (var item in arr)
        {
            if (item > 0)
                ++positives;
            else if (item < 0)
                ++negatives;
            else
                ++zeroes;
        }
        positives = positives / arr.Count;
        negatives = negatives / arr.Count;
        zeroes = zeroes / arr.Count;

        Console.WriteLine(positives.ToString("N6"));
        Console.WriteLine(negatives.ToString("N6"));
        Console.WriteLine(zeroes.ToString("N6"));


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}