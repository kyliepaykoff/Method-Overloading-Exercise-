using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading;
internal class Methods
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    public static string Add(int a, int b, bool dollars)
    {
        var sum = a + b;

        if (dollars)
        {
            if (sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return $"{sum} dollars";
            }
        }
        else
        {
            return sum.ToString();
        }
    }
}


  
