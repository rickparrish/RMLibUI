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
using RandM.RMLib;

/* Sample Usage
        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView LV = (ListView)sender;
            if (LV.ListViewItemSorter == null) LV.ListViewItemSorter = new ListViewItemSorter();
            
            ListViewItemSorter LVIS = ((ListViewItemSorter)LV.ListViewItemSorter);
            LVIS.IgnoreCase = true;
            LVIS.SortAsInt = ((LV.Columns[e.Column].Tag != null) && (LV.Columns[e.Column].Tag.ToString() == "int"));
            LVIS.ColumnClick(e.Column);
            
            LV.Sort();
        }
*/

namespace RandM.RMLibUI
{
    public class ListViewItemSorter : IComparer
    {
        public int ColumnIndex { get; set; }
        public bool IgnoreCase { get; set; }
        public bool SortAsInt { get; set; }
        public SortOrder SortOrder { get; set; }

        public ListViewItemSorter()
        {
            ColumnIndex = 0;
            IgnoreCase = true;
            SortAsInt = false;
            SortOrder = SortOrder.None;
        }
        
        public void ColumnClick(int columnIndex)
        {
            if (columnIndex == ColumnIndex)
            {
                SortOrder = (SortOrder == SortOrder.Descending) ? SortOrder.Ascending : SortOrder.Descending;
            }
            else
            {
                ColumnIndex = columnIndex;
                SortOrder = SortOrder.Ascending;
            }
        }

        public int Compare(object x, object y)
        {
            int Result = 0;

            if (SortAsInt)
            {
                int A = StringUtils.StrToIntDef(((ListViewItem)x).SubItems[ColumnIndex].Text, int.MinValue);
                int B = StringUtils.StrToIntDef(((ListViewItem)y).SubItems[ColumnIndex].Text, int.MinValue);
                if (A < B)
                {
                    Result = -1;
                }
                else if (A == B)
                {
                    Result = 0;
                }
                else if (A > B)
                {
                    Result = 1;
                }
            }
            else
            {
                Result = String.Compare(((ListViewItem)x).SubItems[ColumnIndex].Text, ((ListViewItem)y).SubItems[ColumnIndex].Text, IgnoreCase);
            }
            
            // Flip result if descending order
            if (SortOrder == SortOrder.Descending) Result *= -1;

            return Result;
        }
    }
}
