﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DailyCodingProblem112518
{
    class Program
    {        
        static void Main(string[] args)
        {

            /*
            This problem was recently asked by Google.
            Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
            For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
            Bonus: Can you do this in one pass?
            */

            List<int> itemList = new List<int>();
            int i = 0;
            int k = 14;
            int numRange = 5;
            while (i < numRange)
            {
                Random rand = new Random();
                itemList.Add(rand.Next(1, 13));
                i++;
            }
            for (int x = 0; x < itemList.Count; x++)
            {
                for (int y = 0; y < itemList.Count; y++)
                {
                    if (itemList[x] + itemList[y] != k)
                    {
                        Debug.WriteLine(itemList[x] + " + " + itemList[y] + " not equal to " + k);
                    } else
                    {
                        Debug.WriteLine("***--->" + itemList[x] + " + " + itemList[y] + " is equal to " + k);
                    }
                }
            }
        }
    }
}
