/*
  RMLibUI: Visual support classes/components used by multiple R&M Software programs
  Copyright (C) 2008-2014  Rick Parrish, R&M Software

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
using System.Windows.Forms;
using RandM.RMLib;
using System;

namespace RandM.RMLibUI
{
    static public class Dialog
    {
        public static DialogResult CancelOK(string text, string caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, false);
        }

        public static void Error(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, false);
        }

        public static void Information(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, false);
        }

        static public string InputBox(string prompt, string caption, string defaultText)
        {
            using (frmRMInputBox IB = new frmRMInputBox(prompt, caption, defaultText))
            {
                IB.ShowDialog();
                return IB.InputText;
            }
        }

        public static DialogResult NoYes(string text, string caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, false);
        }


        public static DialogResult OKCancel(string text, string caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, false);
        }

        static public RMSecureString SecureInputBox(string prompt, string caption)
        {
            using (frmRMSecureInputBox SIB = new frmRMSecureInputBox(prompt, caption))
            {
                SIB.ShowDialog();
                return SIB.SecureText;
            }
        }

        public static bool ValidateIsEmailAddress(Control controlToValidate)
        {
            if (controlToValidate == null) throw new ArgumentException("controlToValidate");

            if (!StringUtils.IsValidEmailAddress(controlToValidate.Text.Trim()))
            {
                string ControlName = (controlToValidate.Tag == null) ? controlToValidate.Name : controlToValidate.Tag.ToString();
                Dialog.Error("Invalid email address in field '" + ControlName + "'", "Error");
                controlToValidate.Focus();
                return false;
            }

            // If we get here, we have a value
            return true;
        }

        public static bool ValidateIsIPAddress(Control controlToValidate)
        {
            if (controlToValidate == null) throw new ArgumentException("controlToValidate");

            if (!StringUtils.IsValidIPAddress(controlToValidate.Text.Trim()))
            {
                string ControlName = (controlToValidate.Tag == null) ? controlToValidate.Name : controlToValidate.Tag.ToString();
                Dialog.Error("Invalid IP address in field '" + ControlName + "'", "Error");
                controlToValidate.Focus();
                return false;
            }

            // If we get here, we have a value
            return true;
        }

        public static bool ValidateIsInRange(Control controlToValidate, long minValue, long maxValue)
        {
            if (controlToValidate == null) throw new ArgumentException("controlToValidate");

            long value = 0;
            if ((!long.TryParse(controlToValidate.Text, out value)) || (value < minValue) || (value > maxValue))
            {
                string ControlName = (controlToValidate.Tag == null) ? controlToValidate.Name : controlToValidate.Tag.ToString();
                Dialog.Error("Value in field '" + ControlName + "' is outside acceptable range\r\n\r\nValid range: " + minValue.ToString() + " to " + maxValue.ToString(), "Error");
                controlToValidate.Focus();
                return false;
            }

            // If we get here, we have a value
            return true;
        }

        public static bool ValidateIsNotEmpty(Control controlToValidate)
        {
            if (controlToValidate == null) throw new ArgumentException("controlToValidate");
            if (string.IsNullOrEmpty(controlToValidate.Text.Trim()))
            {
                string ControlName = (controlToValidate.Tag == null) ? controlToValidate.Name : controlToValidate.Tag.ToString();
                Dialog.Error("Required field '" + ControlName + "' cannot be left blank", "Error");
                controlToValidate.Focus();
                return false;
            }

            // If we get here, we have a value
            return true;
        }

        public static DialogResult YesNo(string text, string caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, false);
        }
    }
}
