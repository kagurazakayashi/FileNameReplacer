using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FileNameReplacer
{
    static class DarkMode
    {
        public static Color lightBackColor = SystemColors.Control;
        public static Color lightForeColor = SystemColors.ControlText;
        public static Color darkBackColor = Color.FromArgb(45, 45, 48);
        public static Color darkForeColor = Color.White;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        [DllImport("dwmapi.dll", PreserveSig = true)]
        private static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);

        public static bool IsSystemInDarkMode()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    if (key != null)
                    {
                        int appsUseLightTheme = (int)key.GetValue("AppsUseLightTheme", 1);
                        return appsUseLightTheme == 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DarkMode " + ex.Message);
                return false;
            }
            return false;
        }

        public static bool IsSystemInDarkMode2()
        {
            try
            {
                int useDarkMode = 0;
                int result = DwmGetWindowAttribute(IntPtr.Zero, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useDarkMode, sizeof(int));
                Console.WriteLine("DarkMode result=" + result.ToString() + " useDarkMode=" + useDarkMode.ToString());
                return result == 0 && useDarkMode == 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("DarkMode " + ex.Message);
                return false;
            }
        }

        public static bool AutoDarkMode(Form ctl)
        {
            if (IsSystemInDarkMode())
            {
                ApplyDarkMode(ctl);
                return true;
            }
            else
            {
                ApplyLightMode(ctl);
                return false;
            }
        }

        public static bool IsDarkMode(Form ctl)
        {
            return ctl.BackColor == darkBackColor;
        }

        public static bool ToggleDarkMode(Form ctl)
        {
            if (IsDarkMode(ctl))
            {
                ApplyDarkMode(ctl);
                return true;
            }
            else
            {
                ApplyLightMode(ctl);
                return false;
            }
        }

        public static void ApplyDarkMode(Form ctl)
        {
            ctl.BackColor = darkBackColor;
            ctl.ForeColor = darkForeColor;
            SetControlColors(ctl, darkBackColor, darkForeColor, true);
        }

        public static void ApplyLightMode(Form ctl)
        {
            ctl.BackColor = lightBackColor;
            ctl.ForeColor = lightForeColor;
            SetControlColors(ctl, lightBackColor, lightForeColor, false);
        }

        private static void SetControlColors(Control control, Color backColor, Color foreColor, bool isDarkMode)
        {
            control.BackColor = backColor;
            control.ForeColor = foreColor;
            switch (control)
            {
                case DataGridView c:
                    c.BackgroundColor = backColor;
                    c.DefaultCellStyle.BackColor = backColor;
                    c.DefaultCellStyle.ForeColor = foreColor;
                    c.ColumnHeadersDefaultCellStyle.BackColor = backColor;
                    c.ColumnHeadersDefaultCellStyle.ForeColor = foreColor;
                    c.RowHeadersDefaultCellStyle.BackColor = backColor;
                    c.RowHeadersDefaultCellStyle.ForeColor = foreColor;
                    break;
                case ComboBox c:
                    c.FlatStyle = isDarkMode ? FlatStyle.Flat : FlatStyle.Standard;
                    break;
                case Button c:
                    c.FlatStyle = isDarkMode ? FlatStyle.Flat : FlatStyle.Standard;
                    break;
                case LinkLabel c:
                    c.LinkColor = isDarkMode ? Color.SkyBlue : Color.Blue;
                    c.VisitedLinkColor = c.LinkColor;
                    break;
            }
            foreach (Control childControl in control.Controls)
            {
                SetControlColors(childControl, backColor, foreColor, isDarkMode);
            }
        }

    }
}
