﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1.ArraysAndHashing.Easy;

public class MaximumNumberOfBalloons
{
    // Time complexity: O(n); Space complexity: O(n).
    public int MaxNumberOfBalloons(string text)
    {
        var dict = new Dictionary<char, (int countInWord, int totalCount)>
        {
            ['b'] = (1, 0),
            ['a'] = (1, 0),
            ['l'] = (2, 0),
            ['o'] = (2, 0),
            ['n'] = (1, 0),
        };

        foreach (var c in text)
        {
            if (dict.ContainsKey(c))
                dict[c] = (dict[c].countInWord, dict[c].totalCount + 1);
        }

        var result = dict['b'].totalCount / dict['b'].countInWord;

        foreach (var (key, val) in dict)
        {
            var count = val.totalCount / val.countInWord;
            result = Math.Min(count, result);
        }

        return result;
    }
}