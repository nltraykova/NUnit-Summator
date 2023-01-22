using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumbers
{
    //Method for average of array of numbers
    public static double Average(int[] arr)
    {
        double sum = 0.0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum / arr.Length;
    
    }


}
