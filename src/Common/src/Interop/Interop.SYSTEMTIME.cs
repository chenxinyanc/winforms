// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Globalization;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    /// <summary>
    /// Represents the system time structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class SYSTEMTIME
    {
        public short wYear;
        public short wMonth;
        public short wDayOfWeek;
        public short wDay;
        public short wHour;
        public short wMinute;
        public short wSecond;
        public short wMilliseconds;

        public override string ToString()
        {
            return "[SYSTEMTIME: "
            + wDay.ToString(CultureInfo.InvariantCulture)
            + "/" + wMonth.ToString(CultureInfo.InvariantCulture)
            + "/" + wYear.ToString(CultureInfo.InvariantCulture)
            + " " + wHour.ToString(CultureInfo.InvariantCulture)
            + ":" + wMinute.ToString(CultureInfo.InvariantCulture)
            + ":" + wSecond.ToString(CultureInfo.InvariantCulture)
            + "]";
        }
    }
}
