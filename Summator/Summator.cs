﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        
        //Method for sum of array of numbers
        public static int Sum(int[] arr)
        {
            int sum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;

        }
    }
}