// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        /// <summary>
        /// Represents MonthCalendar Control Messages.
        /// Copied form CommCtrl.h
        /// </summary>
        public enum MCM
        {
            FIRST = 0x1000,                            // MCM_FIRST
            GETCURSEL = (MCM.FIRST + 1),               // MCM_GETCURSEL
            SETMAXSELCOUNT = (MCM.FIRST + 4),          // MCM_SETMAXSELCOUNT
            GETSELRANGE = (MCM.FIRST + 5),             // MCM_GETSELRANGE
            SETSELRANGE = (MCM.FIRST + 6),             // MCM_SETSELRANGE
            GETMONTHRANGE = (MCM.FIRST + 7),           // MCM_GETMONTHRANGE
            GETMINREQRECT = (MCM.FIRST + 9),           // MCM_GETMINREQRECT
            SETCOLOR = (MCM.FIRST + 10),               // MCM_SETCOLOR
            SETTODAY = (MCM.FIRST + 12),               // MCM_SETTODAY
            GETTODAY = (MCM.FIRST + 13),               // MCM_GETTODAY
            HITTEST = (MCM.FIRST + 14),                // MCM_HITTEST
            SETFIRSTDAYOFWEEK = (MCM.FIRST + 15),      // MCM_SETFIRSTDAYOFWEEK
            GETRANGE = (MCM.FIRST + 17),               // MCM_GETRANGE
            SETRANGE = (MCM.FIRST + 18),               // MCM_SETRANGE
            SETMONTHDELTA = (MCM.FIRST + 20),          // MCM_SETMONTHDELTA
            GETMAXTODAYWIDTH = (MCM.FIRST + 21),       // MCM_GETMAXTODAYWIDTH
            GETCALENDARGRIDINFO = (MCM.FIRST + 24)     // MCM_GETCALENDARGRIDINFO
        }
    }
}
