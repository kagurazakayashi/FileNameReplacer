using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Reflection;

namespace FileNameReplacer
{
    static class UIAction
    {
        // 泛型方法用於獲取程式集屬性
        public static T GetAttribute<T>(Assembly assembly) where T : Attribute
        {
            return (T)Attribute.GetCustomAttribute(assembly, typeof(T));
        }

        /// <summary>
        /// 規範化檔案路徑，將多個斜槓替換為單個，並返回絕對路徑。
        /// </summary>
        /// <param name="path">要規範化的路徑</param>
        /// <returns>規範化後的絕對路徑</returns>
        /// <exception cref="ArgumentNullException">如果 path 為空，則丟擲異常</exception>
        public static string NormalizePath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return "";
            }
            // 獲取絕對路徑，並移除末尾的目錄分隔符（除根目錄外）
            return Path.GetFullPath(path).TrimEnd(Path.DirectorySeparatorChar);
        }

        /// <summary>
        /// 檢查 ComboBox 是否為空，如果為空則彈出警告對話方塊。
        /// </summary>
        /// <param name="box">要檢查的 ComboBox 控制元件</param>
        /// <returns>如果 ComboBox 為空，則返回 true，否則返回 false</returns>
        public static bool IsComboBoxEmpty(ComboBox box)
        {
            // 使用 string.IsNullOrWhiteSpace 檢查空白內容
            if (box == null || string.IsNullOrWhiteSpace(box.Text))
            {
                MessageBox.Show("請先輸入要替換的字元。", "沒有要替換的字元", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        /// <summary>
        /// 刪除 ListBox 中所有選中的項。
        /// </summary>
        /// <param name="box">要操作的 ListBox 控制元件</param>
        /// <exception cref="ArgumentNullException">如果 box 為空，則丟擲異常</exception>
        public static void RemoveSelectedItems(ListBox box)
        {
            if (box == null)
            {
                throw new ArgumentNullException(nameof(box), "ListBox 不能為空。");
            }

            // 反向遍歷 SelectedIndices，避免刪除元素時索引變化導致錯誤
            foreach (int index in box.SelectedIndices.Cast<int>().Reverse())
            {
                box.Items.RemoveAt(index);
            }
        }

        /// <summary>
        /// 選中 ListBox 中的所有項。
        /// </summary>
        /// <param name="box">要操作的 ListBox 控制元件</param>
        /// <exception cref="ArgumentNullException">如果 box 為空，則丟擲異常</exception>
        public static void SelectAllItems(ListBox box)
        {
            if (box == null)
            {
                throw new ArgumentNullException(nameof(box), "ListBox 不能為空。");
            }

            if (box.Items.Count == 0) return; // 如果沒有資料，直接返回

            // 選中所有項
            for (int i = 0; i < box.Items.Count; i++)
            {
                box.SetSelected(i, true);
            }
        }

        /// <summary>
        /// 複製 ListBox 中選中的項到剪貼簿。如果沒有選中項，則先選中所有項再複製。
        /// </summary>
        /// <param name="box">要操作的 ListBox 控制元件</param>
        /// <exception cref="ArgumentNullException">如果 box 為空，則丟擲異常</exception>
        public static void CopySelectedItemsToClipboard(ListBox box)
        {
            if (box == null)
            {
                throw new ArgumentNullException(nameof(box), "ListBox 不能為空。");
            }

            if (box.Items.Count == 0) return; // 如果列表為空，直接返回

            // 如果沒有選中任何項，則先全選
            if (box.SelectedItems.Count == 0)
            {
                SelectAllItems(box);
            }

            // 獲取選中的文字並複製到剪貼簿
            string selectedText = string.Join(Environment.NewLine, box.SelectedItems.Cast<string>());

            if (!string.IsNullOrEmpty(selectedText))
            {
                Clipboard.SetText(selectedText);
            }
        }

        /// <summary>
        /// 遞迴設定指定控制元件及其子控制元件的啟用狀態（Enabled）。
        /// </summary>
        /// <param name="parent">父級控制元件</param>
        /// <param name="enabled">是否啟用控制元件，true 表示啟用，false 表示停用</param>
        static public void SetControlsEnabled(Control parent, bool enabled)
        {
            if (parent == null) return;

            // 定義允許修改 Enabled 屬性的控制元件型別列表
            HashSet<Type> allowedTypes = new HashSet<Type>
        {
            typeof(ComboBox),
            typeof(CheckBox),
            typeof(Button),
            typeof(NumericUpDown)
        };

            // 遍歷子控制元件
            foreach (Control control in parent.Controls)
            {
                // 如果控制元件屬於允許修改的型別，則修改 Enabled 屬性
                if (allowedTypes.Contains(control.GetType()))
                {
                    control.Enabled = enabled;
                }

                // 遞迴處理子控制元件
                if (control.Controls.Count > 0)
                {
                    SetControlsEnabled(control, enabled);
                }
            }
        }

        /// <summary>
        /// 在不區分大小寫的情況下，替換字串中的所有指定子字串。
        /// </summary>
        /// <param name="input">輸入字串</param>
        /// <param name="oldValue">要被替換的子字串</param>
        /// <param name="newValue">用於替換的新字串</param>
        /// <returns>返回替換後的字串</returns>
        /// <exception cref="ArgumentNullException">如果 input 或 oldValue 為空，則返回空字串</exception>
        static public string ReplaceIgnoringCase(string input, string oldValue, string newValue)
        {
            // 防止 null 傳入導致異常
            if (input == null) return "";
            if (oldValue == null) return "";
            if (oldValue.Length == 0) return input; // 避免死迴圈

            StringBuilder result = new StringBuilder();
            int index = 0, lastIndex = 0;

            // 遍歷 input，查詢 oldValue（忽略大小寫）
            while ((index = input.IndexOf(oldValue, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                // 追加前一部分未匹配的字串
                result.Append(input, lastIndex, index - lastIndex);

                // 追加替換後的字串
                result.Append(newValue);

                // 移動索引，避免死迴圈
                index += oldValue.Length;
                lastIndex = index;
            }

            // 追加剩餘未匹配的部分
            result.Append(input, lastIndex, input.Length - lastIndex);

            return result.ToString();
        }

        /// <summary>
        /// 根據 `ReplaceJob` 的 `PathLevel` 降序排序。
        /// </summary>
        /// <param name="jobs">待排序的 `ReplaceJob` 陣列</param>
        /// <returns>按照 `PathLevel` 降序排序的新陣列，如果輸入為空則返回空陣列。</returns>
        public static ReplaceJob[] SortJobsByLevel(ReplaceJob[] jobs)
        {
            // 如果 jobs 為空，返回空陣列（相容 .NET 4.5 及以下）
            if (jobs == null || jobs.Length == 0)
            {
#if NET46_OR_GREATER
            return Array.Empty<ReplaceJob>(); // .NET 4.6+ 直接使用 Array.Empty
#else
                return new ReplaceJob[0]; // .NET 4.5 及更早版本
#endif
            }

            // 複製陣列，避免修改原始資料
            ReplaceJob[] sortedJobs = (ReplaceJob[])jobs.Clone();

            // 按 PathLevel 進行降序排序
            Array.Sort(sortedJobs, (job1, job2) => job2.PathLevel.CompareTo(job1.PathLevel));

            return sortedJobs;
        }

        /// <summary>
        /// 將字串表示的數字格式化為帶有千分位分隔符的字串。
        /// </summary>
        /// <param name="numberString">要格式化的數字字串（僅支援整數）</param>
        /// <returns>格式化後的字串（帶千分位），如果輸入無效則返回空字串。</returns>
        public static string FormatNumberWithSeparators(string numberString)
        {
            // 檢查輸入是否為空，避免不必要的解析
            if (string.IsNullOrWhiteSpace(numberString))
            {
                return string.Empty;
            }

            // 嘗試解析字串為 long 型別（支援較大整數）
            if (long.TryParse(numberString, out long number))
            {
                // 按照千分位格式化，不帶小數部分
                return number.ToString("N0", CultureInfo.InvariantCulture);
            }

            return string.Empty; // 解析失敗返回空字串
        }

        /// <summary>
        /// 解析帶有千分位分隔符的數字字串，並轉換為 int 型別。
        /// </summary>
        /// <param name="formattedNumber">帶有千分位分隔符的數字字串</param>
        /// <returns>轉換後的 int 型別數值，如果解析失敗則返回 0。</returns>
        public static int ParseNumberWithSeparators(string formattedNumber)
        {
            // 檢查輸入是否為空
            if (string.IsNullOrWhiteSpace(formattedNumber))
            {
                return 0;
            }

            // 嘗試解析千分位格式的數字字串
            if (int.TryParse(formattedNumber, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out int number))
            {
                return number;
            }

            return 0; // 解析失敗返回 0
        }

        /// <summary>
        /// 啟用或取消啟用視窗，並調整其狀態。
        /// </summary>
        /// <param name="form">目標窗體</param>
        /// <param name="isActivate">是否啟用視窗（true: 置頂並恢復視窗，false: 取消置頂）</param>
        public static void ActivateWindow(Form form, bool isActivate)
        {
            if (form == null) return; // 防止空引用異常

            // 如果需要啟用視窗，且當前視窗是最小化狀態，則恢復正常狀態
            if (isActivate)
            {
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal;
                }

                // 確保視窗在最前面
                form.TopMost = true;
                form.Activate(); // 讓視窗獲得焦點
            }
            else
            {
                // 取消視窗置頂
                form.TopMost = false;
            }
        }

        /// <summary>
        /// 在 DataGridView 中查詢指定單元格值的行，並選中該行。
        /// </summary>
        /// <param name="dataGridView">目標 DataGridView 控制元件</param>
        /// <param name="cellIndex">要查詢的列索引</param>
        /// <param name="cellValue">要匹配的字串值</param>
        public static void SelectDataGridViewRow(DataGridView dataGridView, int cellIndex, string cellValue)
        {
            // 先清除所有已選中行
            dataGridView.ClearSelection();

            // 遍歷所有行
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // 忽略新行
                if (row.IsNewRow) continue;

                // 獲取當前行指定列的單元格值
                var cellObj = row.Cells[cellIndex].Value;

                // 判斷單元格值是否與目標值匹配
                if (cellObj != null && object.Equals(cellObj.ToString(), cellValue))
                {
                    row.Selected = true; // 選中該行
                }
            }
        }

        /// <summary>
        /// 在 DataGridView 中查詢指定單元格的布林值，並選中該行。
        /// </summary>
        /// <param name="dataGridView">目標 DataGridView 控制元件</param>
        /// <param name="cellIndex">要查詢的列索引</param>
        /// <param name="cellValue">要匹配的布林值</param>
        public static void SelectDataGridViewRow(DataGridView dataGridView, int cellIndex, bool cellValue)
        {
            // 先清除所有已選中行
            dataGridView.ClearSelection();

            // 遍歷所有行
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // 忽略新行
                if (row.IsNewRow) continue;

                // 獲取當前行指定列的單元格值並嘗試轉換為布林值
                if (row.Cells[cellIndex].Value is bool isChecked && isChecked == cellValue)
                {
                    row.Selected = true; // 選中該行
                }
            }
        }
    }
}
