using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace BackupDBD
{
    public partial class Form1 : Form
    {

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        string target;

        public Form1()
        {
            InitializeComponent();
            target = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BackupDBD";
            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }
            if (!Directory.Exists(target))
            {
                textBox.AppendText("Konnte Ziel Ordner nicht erstellen: " + target + "\n");
                backup.Enabled = false;
            }
            textBox.AppendText("Backup Ziel: " + target + "\n");
        }

        private void backup_Click(object sender, EventArgs e)
        {

            string date = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            textBox.AppendText("Suche Steam Pfad.\n");
            string steamPath = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null);
            textBox.AppendText("Steam Pfad hier gefunden: " + steamPath + "\n");
            string[] profilesDir = Directory.GetDirectories(steamPath+@"\userdata");
            foreach (string profileDir in profilesDir)
            {
                if( Directory.Exists(profileDir + "\\" + 381210))
                {
                    string profileID = new DirectoryInfo(profileDir).Name;
                    textBox.AppendText("User gefunden: " + profileID + "\n");
                    string sourceDir = profileDir + "\\" + 381210 + "\\remote";
                    textBox.AppendText("Erstelle DBD Backup für: " + profileID + "\n");
                    string targetDir = target + "\\" + date + "\\" + profileID + "\\" + 381210 + "\\remote";
                    Directory.CreateDirectory(targetDir);
                    DirectoryCopy(sourceDir, targetDir, true);
                }
            }
        }

        private void buttonOpenTargetDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", target);
        }
    }
}
