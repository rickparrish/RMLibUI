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
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using RandM.RMLib;

namespace RandM.RMLibUI
{
    static public class AutoUpdateUI
    {
        static public bool Update(Uri url, bool displayNoUpdateMessage)
        {
            if (AutoUpdate.Available(url))
            {
                if (Dialog.YesNo("A new version of " + ProcessUtils.ProductName + " is available!" + Environment.NewLine + Environment.NewLine + "Your version: " + ProcessUtils.ProductVersion + Environment.NewLine + "New version: " + AutoUpdate.Version + Environment.NewLine + Environment.NewLine + AutoUpdate.Comments + Environment.NewLine + Environment.NewLine + "Do you want to download and install the newest version?" + Environment.NewLine + "(Doing so will close " + ProcessUtils.ProductName + ")", "New Version Available!") == DialogResult.Yes)
                {
                    string DownloadFile = StringUtils.PathCombine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Application.CompanyName, Path.GetFileName(AutoUpdate.Url.ToString()));
                    using (frmRMFileDownloader FD = new frmRMFileDownloader(new Uri(AutoUpdate.Url), DownloadFile))
                    {
                        if (FD.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                // Launch installer and return
                                Process.Start(DownloadFile);
                                return true;
                            }
                            catch (Exception)
                            {
                                // User didn't allow the installer to run, so don't quit
                                Dialog.Error("Unable to launch installer", "Error Updating");

                                // Clean up the failed installer
                                FileUtils.FileDelete(DownloadFile);
                            }
                        }
                    }
                }
            }
            else if (displayNoUpdateMessage)
            {
                Dialog.Information("You've got the latest and greatest!", "No Update Available");
            }

            return false;
        }
    }
}
