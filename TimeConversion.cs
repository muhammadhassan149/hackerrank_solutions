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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string ampm = s.Substring(8, 2);
        string hhmmss = s.Substring(0, 8);
        List<int> timeParts = hhmmss.Split(":").Select(a => int.Parse(a)).ToList();
        if (ampm == "AM")
        {
            if (Convert.ToInt32(timeParts[0]) == 12)
                timeParts[0] = 0;
        }
        if (ampm == "PM" && timeParts[0] < 12)
            timeParts[0] = Convert.ToInt32(timeParts[0]) + 12;
        return $"{timeParts[0].ToString("00")}:{timeParts[1].ToString("00")}:{timeParts[2].ToString("00")}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
