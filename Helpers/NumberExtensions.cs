using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ShoeShop.Helpers
{
    public static class NumberExtensions
{
    public static string ToInvariantString(this decimal value)
    {
        return value.ToString("F2", CultureInfo.InvariantCulture);
    }

    public static string ToInvariantString(this double value)
    {
        return value.ToString("F2", CultureInfo.InvariantCulture);
    }

    public static string ToInvariantString(this float value)
    {
        return value.ToString("F2", CultureInfo.InvariantCulture);
    }
}
}