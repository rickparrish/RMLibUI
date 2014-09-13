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

  This code file was downloaded from the following blog post at "Glavs Blog"
  SecurePasswordTextBox update
  Tuesday, March 14, 2006
  http://weblogs.asp.net/pglavich/archive/2006/03/14/440191.aspx
  
  It was modified to move it into the RMLibUI namespace, to use an RMSecureString
  as it's backing instead of a regular SecureString, to add support for the system
  password character, by applying some fixes from "Wout", and to handle the paste function.
*/
using System;
using System.Windows.Forms;
using RandM.RMLib;
using System.Security.Permissions;

namespace RandM.RMLibUI
{
    /// <summary>
    /// This is a TextBox implementation that uses the RandM.RMLib.RMSecureString as its backing
    /// store instead of standard managed string instance. At no time, is a managed string instance
    /// used to hold a component of the textual entry.
    /// It does not display any text and relies on the 'PasswordChar' character to display the amount of
    /// characters entered. If no password char is defined, then an 'asterisk' is used.
    /// </summary>
    /// <remarks>Downloaded from http://weblogs.asp.net/pglavich/archive/2006/10/29/Secure-TextBox-Updated.aspx </remarks>
    public partial class SecureTextBox : TextBox
    {
        #region Component Designer generated code

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                _secureEntry.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion

        #region Private fields

        private bool _displayChar = false;
        RMSecureString _secureEntry = new RMSecureString();

        #endregion

        #region Constructor
        public SecureTextBox()
        {
            InitializeComponent();

            this.PasswordChar = '*';   // default to an asterisk
            this.UseSystemPasswordChar = true;
        }

        #endregion

        #region Public properties

        new public char PasswordChar
        {
            get
            {
                return base.PasswordChar;
            }
            set
            {
                base.PasswordChar = value;
                RedrawMask();
            }
        }

        /// <summary>
        /// The secure string instance captured so far.
        /// This is the preferred method of accessing the string contents.
        /// </summary>
        public RMSecureString SecureText
        {
            get
            {
                return _secureEntry;
            }
            set
            {
                _secureEntry = value;
                RedrawMask();
            }
        }

        public void RedrawMask()
        {
            if (base.UseSystemPasswordChar)
            {
                this.Text = new string(base.PasswordChar, _secureEntry.Length);
            }
            else if (base.PasswordChar == '\0')
            {
                this.Text = _secureEntry.GetPlainText();
            }
            else
            {
                this.Text = new string(base.PasswordChar, _secureEntry.Length);
            }
        }

        new public bool UseSystemPasswordChar
        {
            get
            {
                return base.UseSystemPasswordChar;
            }
            set
            {
                base.UseSystemPasswordChar = value;
                RedrawMask();
            }
        }

        #endregion

        #region ProcessKeyMessage

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override bool ProcessKeyMessage(ref Message m)
        {
            if (_displayChar)
            {
                return base.ProcessKeyMessage(ref m);
            }
            else
            {
                _displayChar = true;
                return true;
            }
        }

        #endregion

        #region IsInputChar

        protected override bool IsInputChar(char charCode)
        {
            int startPos = this.SelectionStart;

            bool isChar = base.IsInputChar(charCode);
            if (isChar)
            {
                int keyCode = (int)charCode;

                // If the key pressed is NOT a control/cursor type key, then add it to our instance.
                // Note: This does not catch the SHIFT key or anything like that
                if (!Char.IsControl(charCode) && !char.IsHighSurrogate(charCode) && !char.IsLowSurrogate(charCode))
                {

                    if (this.SelectionLength > 0)
                    {
                        for (int i = 0; i < this.SelectionLength; i++)
                            _secureEntry.RemoveAt(this.SelectionStart);
                    }

                    if (startPos == _secureEntry.Length)
                    {
                        _secureEntry.AppendChar(charCode);
                    }
                    else
                    {
                        _secureEntry.InsertAt(startPos, charCode);
                    }

                    RedrawMask();

                    _displayChar = false;
                    startPos++;

                    this.SelectionStart = startPos;
                }
                else
                {
                    // We need to check what key has been pressed.

                    switch (keyCode)
                    {
                        case (int)Keys.Back:
                            if (this.SelectionLength == 0 && startPos > 0)
                            {
                                startPos--;
                                _secureEntry.RemoveAt(startPos);
                                // Wout: bug fix: don't mess with the TextBox behavior, it handles the backspace key just fine.
                                // this.Text = new string('*', _secureEntry.Length);
                                // this.SelectionStart = startPos;
                            }
                            else if (this.SelectionLength > 0)
                            {
                                for (int i = 0; i < this.SelectionLength; i++)
                                    _secureEntry.RemoveAt(this.SelectionStart);
                            }
                            // Wout: bug fix: used to be false, but then the TextBox didn't process the backspace key.
                            _displayChar = true;

                            break;

                        case 22: // The paste button
                            // This kinda defeats the purpose of the secure textbox, but it's already
                            // on the clipboard anyway, so who cares.
                            string password = Clipboard.GetText();

                            if (password != null)
                            {
                                int newSelectionStart = SelectionStart + password.Length;
                                if (SelectionLength == 0)
                                {
                                    for (int i = password.Length - 1; i >= 0; i--)
                                    {
                                        _secureEntry.InsertAt(SelectionStart, password[i]);
                                    }
                                }
                                else
                                {
                                    // Remove old chars.
                                    for (int i = 0; i < this.SelectionLength; i++)
                                    {
                                        _secureEntry.RemoveAt(this.SelectionStart);
                                    }

                                    // Insert new chars.
                                    for (int i = password.Length - 1; i >= 0; i--)
                                    {
                                        _secureEntry.InsertAt(SelectionStart, password[i]);
                                    }
                                }

                                Text = new string(PasswordChar, _secureEntry.Length);
                                SelectionStart = newSelectionStart;
                            }
                            _displayChar = false;

                            break;
                    }
                }
            }
            else
                _displayChar = true;

            return isChar;
        }

        #endregion

        #region IsInputKey

        protected override bool IsInputKey(Keys keyData)
        {
            bool result = true;

            // Note: This whole section is only to deal with the 'Delete' key.

            if (keyData == Keys.Delete)
            {
                if (this.SelectionLength == _secureEntry.Length)
                {
                    _secureEntry.Clear();
                }
                else if (this.SelectionLength > 0)
                {
                    for (int i = 0; i < this.SelectionLength; i++)
                        _secureEntry.RemoveAt(this.SelectionStart);

                }
                else
                {
                    if ((keyData & Keys.Delete) == Keys.Delete && this.SelectionStart < this.Text.Length)
                        _secureEntry.RemoveAt(this.SelectionStart);
                }

            }
            else
            {
                result = base.IsInputKey(keyData);
            }

            return result;

        }

        #endregion

    }
}
