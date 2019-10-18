﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using static Interop;

namespace System.Windows.Forms
{
    public partial class MonthCalendar
    {
        /// <summary>
        /// Represents the calendar cell accessible object.
        /// </summary>
        internal class CalendarCellAccessibleObject : CalendarGridChildAccessibleObject
        {
            private int _rowIndex;
            private int _columnIndex;
            private string _name;

            public CalendarCellAccessibleObject(MonthCalendarAccessibleObject calendarAccessibleObject, int calendarIndex, AccessibleObject parentAccessibleObject, int rowIndex, int columnIndex, string name)
                : base(calendarAccessibleObject, calendarIndex, CalendarChildType.CalendarCell, parentAccessibleObject, rowIndex * columnIndex)
            {
                _rowIndex = rowIndex;
                _columnIndex = columnIndex;
                _name = name;
            }

            protected override RECT CalculateBoundingRectangle()
            {
                _calendarAccessibleObject.GetCalendarPartRectangle(_calendarIndex, NativeMethods.MCGIP_CALENDARCELL, _rowIndex, _columnIndex, out RECT rectangle);
                return rectangle;
            }

            internal override int GetChildId() => _columnIndex + 1;

            internal override UnsafeNativeMethods.IRawElementProviderFragment FragmentNavigate(UnsafeNativeMethods.NavigateDirection direction) =>
                direction switch
                {
                    UnsafeNativeMethods.NavigateDirection.Parent => _parentAccessibleObject,
                    UnsafeNativeMethods.NavigateDirection.NextSibling =>
                        _calendarAccessibleObject.GetCalendarChildAccessibleObject(_calendarIndex, CalendarChildType.CalendarCell, _parentAccessibleObject, _columnIndex + 1),
                    UnsafeNativeMethods.NavigateDirection.PreviousSibling =>
                        _calendarAccessibleObject.GetCalendarChildAccessibleObject(_calendarIndex, CalendarChildType.CalendarCell, _parentAccessibleObject, _columnIndex - 1),
                    _ => base.FragmentNavigate(direction)
                };

            internal override object GetPropertyValue(int propertyID) =>
                propertyID switch
                {
                    NativeMethods.UIA_ControlTypePropertyId => (_rowIndex == -1) ? NativeMethods.UIA_HeaderControlTypeId : NativeMethods.UIA_DataItemControlTypeId,
                    NativeMethods.UIA_NamePropertyId => Name,
                    NativeMethods.UIA_HasKeyboardFocusPropertyId => true,
                    NativeMethods.UIA_IsGridItemPatternAvailablePropertyId => true,
                    NativeMethods.UIA_IsTableItemPatternAvailablePropertyId => true,
                    _ => base.GetPropertyValue(propertyID)
                };

            internal override bool IsPatternSupported(int patternId)
            {
                if (patternId == NativeMethods.UIA_GridItemPatternId ||
                    patternId == NativeMethods.UIA_InvokePatternId ||
                    patternId == NativeMethods.UIA_TableItemPatternId)
                {
                    return true;
                }

                return base.IsPatternSupported(patternId);
            }

            internal override void Invoke()
            {
                RaiseMouseClick();
            }

            public override string Name => _name;

            internal override UnsafeNativeMethods.IRawElementProviderSimple[] GetRowHeaderItems() => null;

            internal override UnsafeNativeMethods.IRawElementProviderSimple[] GetColumnHeaderItems()
            {
                if (!_calendarAccessibleObject.HasHeaderRow)
                {
                    return null;
                }

                AccessibleObject headerRowAccessibleObject =
                    _calendarAccessibleObject.GetCalendarChildAccessibleObject(_calendarIndex, CalendarChildType.CalendarRow, _parentAccessibleObject.Parent, -1);
                AccessibleObject headerCellAccessibleObject =
                    _calendarAccessibleObject.GetCalendarChildAccessibleObject(_calendarIndex, CalendarChildType.CalendarCell, headerRowAccessibleObject, _columnIndex);

                return new UnsafeNativeMethods.IRawElementProviderSimple[1] { headerCellAccessibleObject };
            }

            internal override int Row => _rowIndex;

            internal override int Column => _columnIndex;

            internal override UnsafeNativeMethods.IRawElementProviderSimple ContainingGrid => _parentAccessibleObject.Parent;

            internal override int[] RuntimeId
            {
                get
                {
                    int[] runtimeId = new int[5];
                    runtimeId[0] = RuntimeIDFirstItem;
                    runtimeId[1] = _calendarAccessibleObject.Owner.Handle.ToInt32();
                    runtimeId[2] = Parent.Parent.GetChildId();
                    runtimeId[3] = Parent.GetChildId();
                    runtimeId[4] = GetChildId();
                    return runtimeId;
                }
            }
        }
    }
}
