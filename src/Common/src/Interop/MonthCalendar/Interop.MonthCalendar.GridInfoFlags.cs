// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        /// <summary>
        /// Represents MonthCalendar Control Grid Info Flags.
        /// Copied form CommCtrl.h
        /// </summary>
        public enum MCGIF
        {
            DATE = 0x00000001, // MCGIF_DATE
            RECT = 0x00000002, // MCGIF_RECT
            NAME = 0x00000004  // MCGIF_NAME
        }
    }
}
