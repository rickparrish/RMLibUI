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

  This code file was downloaded from the following Code Project article:
  ListView Group Sorter
  By Paw Jershauge, 17 Aug 2009 
  http://www.codeproject.com/Articles/39041/ListView-Group-Sorter
  
  It was modified to move it into the RMLibUI namespace, and to add
  argument validation (to make the Code Analysis tool happy)
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RandM.RMLibUI
{
    public class ListViewGroupHeaderSorter : IComparer<ListViewGroup>
    {
        private bool _ascending = true;
        public ListViewGroupHeaderSorter(bool ascending)
        {
            _ascending = ascending;
        }

        #region IComparer<ListViewGroup> Members

        public int Compare(ListViewGroup x, ListViewGroup y)
        {
            if (x == null) throw new ArgumentNullException("x");
            if (y == null) throw new ArgumentNullException("y");

            if (_ascending)
                return string.Compare(((ListViewGroup)x).Header, ((ListViewGroup)y).Header);
            else
                return string.Compare(((ListViewGroup)y).Header, ((ListViewGroup)x).Header);
        }
        #endregion
    }
}
