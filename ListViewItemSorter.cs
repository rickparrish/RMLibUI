/*
  RMLibUI: Visual support classes/components used by multiple R&M Software programs
  Copyright (C) 2008-2013  Rick Parrish, R&M Software

  This file is part of RMLibUI.

  RMLibUI is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  any later version.

  RMLibUI is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with RMLibUI.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RandM.RMLibUI
{
    public class ListViewItemSorter : IComparer
    {
        private int _ColumnIndex;
        private bool _IgnoreCase;
        private SortOrder _SortOrder = SortOrder.Ascending;

        public ListViewItemSorter()
        {
            _ColumnIndex = 0;
            _IgnoreCase = true;
        }
        public ListViewItemSorter(int columnIndex)
        {
            _ColumnIndex = columnIndex;
            _IgnoreCase = true;
        }
        public ListViewItemSorter(bool ignoreCase)
        {
            _ColumnIndex = 0;
            _IgnoreCase = ignoreCase;
        }
        public ListViewItemSorter(int columnIndex, bool ignoreCase)
        {
            _ColumnIndex = columnIndex;
            _IgnoreCase = ignoreCase;
        }

        public void ColumnClick(int columnIndex)
        {
            if (columnIndex == _ColumnIndex)
            {
                _SortOrder = (_SortOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                _ColumnIndex = columnIndex;
                _SortOrder = SortOrder.Ascending;
            }
        }

        public int Compare(object x, object y)
        {
            int Result = String.Compare(((ListViewItem)x).SubItems[_ColumnIndex].Text, ((ListViewItem)y).SubItems[_ColumnIndex].Text, _IgnoreCase);
            
            // Flip result if descending order
            if (_SortOrder == SortOrder.Descending) Result *= -1;

            return Result;
        }
    }
}
