﻿using System;
using System.Collections.Generic;

namespace NLog.Targets.Syslog.Extensions
{
    internal static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable)
                action(item);
        }
    }
}