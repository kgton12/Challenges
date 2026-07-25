namespace CodeWars.Completed;

public class WhatCenturyIsIt
{
    public static string WhatCentury(string year)
    {
        int roudNumber = (int)Math.Ceiling(Convert.ToInt16(year) / 100.0);
        char lastChar = roudNumber.ToString().Last();
        string result;

        if ("11 12 13".Contains(roudNumber.ToString()) || "0 4 5 6 7 8 9".Contains(lastChar))
            result = "th";
        else if (lastChar.Equals('1'))
            result = "st";
        else if (lastChar.Equals('2'))
            result = "nd";
        else
            result = "rd";

        return roudNumber + result;
    }
}