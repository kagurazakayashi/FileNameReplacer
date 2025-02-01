using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileNameReplacer
{
    static class SysInfo
    {
        public static string[] GetDrives()
        {
            List<string> drives = new List<string>();
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();
            for (int i = 0; i < drivesInfo.Length; i++)
            {
                drives.Add(drivesInfo[i].Name);
            }
            return drives.ToArray();
        }

        public static string[] GetRegisteredFileExtensions()
        {
            List<string> extensions = new List<string>();
            using (RegistryKey classesRoot = Registry.ClassesRoot)
            {
                if (classesRoot != null)
                {
                    foreach (string subKeyName in classesRoot.GetSubKeyNames())
                    {
                        if (subKeyName.StartsWith("."))
                        {
                            extensions.Add(subKeyName);
                        }
                    }
                }
            }
            return extensions.ToArray();
        }

        public static string[] GetCommonUserFolders()
        {
            HashSet<string> folderPaths = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            Environment.SpecialFolder[] specialFolders = new Environment.SpecialFolder[]
            {
            Environment.SpecialFolder.UserProfile,
            Environment.SpecialFolder.Desktop,
            Environment.SpecialFolder.MyDocuments,
            Environment.SpecialFolder.MyPictures,
            Environment.SpecialFolder.MyMusic,
            Environment.SpecialFolder.MyVideos,
            Environment.SpecialFolder.ApplicationData,
            Environment.SpecialFolder.LocalApplicationData,
            Environment.SpecialFolder.StartMenu,
            Environment.SpecialFolder.DesktopDirectory,
            Environment.SpecialFolder.ProgramFiles,
            Environment.SpecialFolder.ProgramFilesX86,
            Environment.SpecialFolder.System,
            Environment.SpecialFolder.Windows
            };
            foreach (var folder in specialFolders)
            {
                try
                {
                    string path = Environment.GetFolderPath(folder);
                    if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
                    {
                        folderPaths.Add(path);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{folder}: {ex.Message}");
                }
            }
            return folderPaths.ToArray();
        }
    }
}
