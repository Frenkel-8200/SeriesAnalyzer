using System;
using System.Collections.Generic;

class SeriesAnalysis
{
    // Global variables
    static double[] series;
    static Dictionary<string, Func<dynamic>> menuOptions = new Dictionary<string, Func<dynamic>>
    {
        { "a", () => InputNewSeries() },
        { "b", () => GetOriginalSeries() },
        { "c", () => GetReverseSeries() },
        { "d", () => GetSortedSeries() },
        { "e", () => GetMaxSeries() },
        { "f", () => GetMinSeries() },
        { "g", () => GetAvgSeries() },
        { "h", () => GetCountSeries() },
        { "i", () => GetSumSeries() },
        { "j", () => Exit() }
    };

    // Methods to perform operations on the series
    static string InputNewSeries()
    {
        if (UpdateSeries("Enter a new series numbers:"))
        {
            return "Series updated successfully.";
        }
        return "Invalid input Series";
    }

    static double[] GetOriginalSeries()
    {
    }

    static double[] GetReverseSeries()
    {
    }

    static double[] GetSortedSeries()
    {
    }

    static double GetMaxSeries()
    {
    }

    static double GetMinSeries()
    {
    }

    static double GetAvgSeries()
    {
    }

    static int GetCountSeries()
    {
    }

    static double GetSumSeries()
    {
    }

    static string Exit()
    {
    }

    static double[] ConvertArrayStringToDouble(string[] args)
    {
        return Array.ConvertAll(args, double.Parse);
    }

    static bool UpdateSeries(string message)
    {
        string[] input = PromptAndReadInput(message).Split(' ');
        if (IsValidSeriesInput(input))
        {
            series = ConvertArrayStringToDouble(input);
            return true;
        }
        return false;
    }

    // Validation methods
    static bool IsValidSeriesInput(string[] args)
    {
        return HasLeastThreeArgs(args) && IsNumeric(args) && IsPositiveNums(args);
    }

    static bool IsValidOptionInput(string choice)
    {
        return menuOptions.ContainsKey(choice);
    }

    static bool HasLeastThreeArgs(string[] args)
    {
        return args.Length >= 3;
    }

    static bool IsNumeric(string[] args)
    {
        foreach (string arg in args)
        {

            if (!double.TryParse(arg, out _))
            {
                return false;
            }
        }
        return true;
    }

    static bool IsPositiveNums(string[] args)
    {
        double[] intArgs = ConvertArrayStringToDouble(args);
        foreach (int arg in intArgs)
        {
            if (arg < 0)
            {
                return false;
            }
        }
        return true;
    }


    // Display methods
    static void Print(string str)
    {
        Console.WriteLine(str);
    }

    static void Print(int num)
    {
        Console.WriteLine(num);
    }
    static void Print(double num)
    {
        Console.WriteLine(num);
    }

    static void Print(double[] arr)
    {
        string result = "";
        foreach (double num in arr)
        {
            result += num + " ";
        }
        Console.WriteLine(result);
    }
    
    static string PromptAndReadInput(string messsage)
    {
        Print(messsage);
        return Console.ReadLine();
    }

    // Menu methods
    static string GetMenu()
    {
    }

    static void HandleMenuOption()
    {
    }

    // Main methods
    static void Initialize(string[] args)
    {
    }

    static void Run()
    {
    }

    static void Main(string[] args)
    {
    }
}
