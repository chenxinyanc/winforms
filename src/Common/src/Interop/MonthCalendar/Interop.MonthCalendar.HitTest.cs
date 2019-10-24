// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        /// <summary>
        /// Represents MonthCalendar Control HitTest values.
        /// Copied form CommCtrl.h
        /// </summary>
        public enum MCHT
        {
            TITLE = 0x00010000,                                             // MCHT_TITLE
            CALENDAR = 0x00020000,                                          // MCHT_CALENDAR
            TODAYLINK = 0x00030000,                                         // MCHT_TODAYLINK
                                                                            //
            TITLEBK = (MCHT.TITLE),                                         // MCHT_TITLEBK
            TITLEMONTH = (MCHT.TITLE | 0x0001),                             // MCHT_TITLEMONTH
            TITLEYEAR = (MCHT.TITLE | 0x0002),                              // MCHT_TITLEYEAR
            TITLEBTNNEXT = (MCHT.TITLE | 0x01000000 | 0x0003),              // MCHT_TITLEBTNNEXT
            TITLEBTNPREV = (MCHT.TITLE | 0x02000000 | 0x0003),              // MCHT_TITLEBTNPREV
                                                                            //
            CALENDARBK = (MCHT.CALENDAR),                                   // MCHT_CALENDARBK
            CALENDARDATE = (MCHT.CALENDAR | 0x0001),                        // MCHT_CALENDARDATE
            CALENDARDATENEXT = ((MCHT.CALENDAR | 0x0001) | 0x01000000),     // MCHT_CALENDARDATENEXT
            CALENDARDATEPREV = ((MCHT.CALENDAR | 0x0001) | 0x02000000),     // MCHT_CALENDARDATEPREV
            CALENDARDAY = (MCHT.CALENDAR | 0x0002),                         // MCHT_CALENDARDAY
            CALENDARWEEKNUM = (MCHT.CALENDAR | 0x0003)                      // MCHT_CALENDARWEEKNUM
        }
    }
}
