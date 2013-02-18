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

  This code file was downloaded from the following Stack Overflow question/answer:
  Color different parts of a RichTextBox string
  by Nathan Baulch
  http://stackoverflow.com/a/1926822
  
  It was modified to move it into the RMLibUI namespace
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandM.RMLibUI
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
