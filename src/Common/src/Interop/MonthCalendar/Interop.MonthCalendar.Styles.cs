// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        /// <summary>
        /// Represents MonthCalendar Control styles constatnts.
        /// Copied form CommCtrl.h
        /// </summary>
        public enum MCS
        {
            DAYSTATE = 0x0001,         // MCS_DAYSTATE
            MULTISELECT = 0x0002,      // MCS_MULTISELECT
            WEEKNUMBERS = 0x0004,      // MCS_WEEKNUMBERS
            NOTODAYCIRCLE = 0x0008,    // MCS_NOTODAYCIRCLE
            NOTODAY = 0x0010           // MCS_NOTODAY
        }
    }
}
