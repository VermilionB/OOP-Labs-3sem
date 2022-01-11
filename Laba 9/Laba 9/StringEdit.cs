﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace Laba_9
{
    public class StringEdit
    {
        public static readonly Func<string, string> ToLower = str => str.ToLower();

        public static readonly Func<string, string> ToUpper = str => str.ToUpper();

        public static readonly Func<string, string> RemoveSpaces = str
            => str.Replace(" ", string.Empty);

        public static readonly Func<string, string> RemovePunctuation = str
            => Regex.Replace(str, "[.,:;!?]", string.Empty);

        public static readonly Func<string, string> AddSymbol = str => str += "?!";
    }
}
