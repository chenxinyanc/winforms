// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        /// <summary>
        /// Represents MonthCalendar control part constants.
        /// Copied form CommCtrl.h
        /// </summary>
        public enum MCGIP : uint
        {
            CALENDARCONTROL = 0,   // MCGIP_CALENDARCONTROL
            NEXT = 1,              // MCGIP_NEXT
            PREV = 2,              // MCGIP_PREV
            FOOTER = 3,            // MCGIP_FOOTER
            CALENDAR = 4,          // MCGIP_CALENDAR
            CALENDARHEADER = 5,    // MCGIP_CALENDARHEADER
            CALENDARBODY = 6,      // MCGIP_CALENDARBODY
            CALENDARROW = 7,       // MCGIP_CALENDARROW
            CALENDARCELL = 8       // MCGIP_CALENDARCELL
        }
    }
}
