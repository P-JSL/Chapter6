using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.Console;

namespace Packt.Shared;

public static class StringExtensions
{
    public static bool IsVaildEmail(this string input)
    {
        return Regex.IsMatch(input,@"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
    }
}
