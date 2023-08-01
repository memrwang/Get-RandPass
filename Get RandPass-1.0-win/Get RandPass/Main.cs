using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GetRandPass
{
    public partial class GetRandPass : Form
    {
        /// <summary>
        /// 主窗口启动加载
        /// </summary>
        public GetRandPass()
        {
            InitializeComponent();
            SuccessLabel.Visible = false;
        }

        // 配置文件路径
        string SettingFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Get RandPass.ini");
        // 跟踪当前语言选中的菜单项
        private ToolStripMenuItem selectedMenuItem;

        
        string AboutTitle = "About"; // 关于Title
        string ErrorTitle = "Error"; //错误Title
        string ErrorInfo = "Please select at least one character type"; //错误Info

        /// <summary>
        /// 程序加载
        /// </summary>
        private void GetRandPass_Load(object sender, EventArgs e)
        {
            // 检查配置文件是否存在,如果不存在软件语言和其它设置为默认
            if (File.Exists(SettingFilePath))
            {
                // 获取Language文件夹中的所有txt语言文件
                string[] txtFiles = Directory.GetFiles("Language", "*.txt");

                // 加载全部并添加相应的menuItem
                foreach (string filePath in txtFiles)
                {
                    // 获取文件名（不包括扩展名）
                    string languageName = Path.GetFileNameWithoutExtension(filePath);

                    // 创建并添加menuItem
                    ToolStripMenuItem menuItem = new ToolStripMenuItem(languageName);
                    LanguageToolStripMenuItem.DropDownItems.Add(menuItem);
                }
                // 绑定所有menuItem到同一个事件
                foreach (ToolStripMenuItem menuItem in LanguageToolStripMenuItem.DropDownItems)
                {
                    menuItem.Click += MenuItem_Click;
                }

                // 修改当前Language值
                Dictionary<string, string> setting = LoadResources(SettingFilePath);
                string CurrentLanguage = GetResourceValue(setting, "Language");

                // 切换当前语言
                SwitchLanguage(CurrentLanguage);

                // 设置语言初始选中状态
                foreach (ToolStripMenuItem menuItem in LanguageToolStripMenuItem.DropDownItems)
                {
                    if (menuItem.Text == CurrentLanguage)
                    {
                        menuItem.Checked = true;
                        selectedMenuItem = menuItem;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
            else
            {
                // 隐藏菜单设置
                SettingToolStripMenuItem.Visible = false;
            }
        }

        /// <summary>
        /// 切换软件语言,并重新调整部分视图位置
        /// </summary>
        /// <param name="CurrentLanguage"></param>
        private void SwitchLanguage(string CurrentLanguage)
        {
            // 加载对应语言的文本文件
            string LanguageFilePath = Path.Combine("Language", CurrentLanguage + ".txt");
            Dictionary<string, string> language = LoadResources(LanguageFilePath);

            // 修改视图语言

            // 菜单
            SettingToolStripMenuItem.Text = GetResourceValue(language, "Setting");
            LanguageToolStripMenuItem.Text = GetResourceValue(language, "Language");
            HelpToolStripMenuItem.Text = GetResourceValue(language, "Help");
            WebsiteToolStripMenuItem.Text = GetResourceValue(language, "Website");
            AboutToolStripMenuItem.Text = GetResourceValue(language, "About");
            // 操作区
            PassLabel.Text = GetResourceValue(language, "Pass");
            CopyButton.Text = GetResourceValue(language, "Copy");
            SuccessLabel.Text = GetResourceValue(language, "Succes");
            GetButton.Text = GetResourceValue(language, "Get");
            // 选择区
            UppercaseCheckBox.Text = GetResourceValue(language, "Uppercases");
            LowercaserCheckBox.Text = GetResourceValue(language, "Lowercases");
            NumberCheckBox.Text = GetResourceValue(language, "Numbers");
            SymbolCheckBox.Text = GetResourceValue(language, "Symbols");
            LengthLabel.Text = GetResourceValue(language, "Length");
            IgnoredLabel.Text = GetResourceValue(language, "Ignored");
            // 弹窗
            AboutTitle = GetResourceValue(language, "AboutTitle");
            ErrorTitle = GetResourceValue(language, "ErrorTitle");
            ErrorInfo = GetResourceValue(language, "ErrorInfo");

            // 修改视图组件位置

            // 调整PassLabel的位置
            int PassLabel_Y = PassTextBox.Top + (PassTextBox.Height - PassLabel.Height) / 2;
            PassLabel.Location = new Point(PassTextBox.Left - PassLabel.Width - 15, PassLabel_Y);

            // 调整LengthLabel的位置
            int LengthLabel_Y = PassLengthNumericUpDown.Top + (PassLengthNumericUpDown.Height - LengthLabel.Height) / 2;
            LengthLabel.Location = new Point(PassLengthNumericUpDown.Left - LengthLabel.Width - 5, LengthLabel_Y);

            // 调整IgnoredLabel的位置
            int IgnoredLabel_Y = IgnoredTextBox.Top + (IgnoredTextBox.Height - IgnoredLabel.Height) / 2;
            IgnoredLabel.Location = new Point(IgnoredTextBox.Left - IgnoredLabel.Width - 5, IgnoredLabel_Y);

            // 调整SuccessLabel的位置
            int successLabel_Y = CopyButton.Bottom + 5;
            int successLabel_X = CopyButton.Left + (CopyButton.Width - SuccessLabel.Width) / 2;
            SuccessLabel.Location = new Point(successLabel_X, successLabel_Y);

            // 修改配置文件语言值
            EditResources(SettingFilePath, "Language", CurrentLanguage);
        }

        /// <summary>
        /// 点击语言切换
        /// </summary>
        private void MenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前按下的menuItem
            ToolStripMenuItem clickedMenuItem = (ToolStripMenuItem)sender;
            // 获取当前按下的menuItem的名称
            string menuItemName = clickedMenuItem.Text;
            // 如果已经有选中的菜单项，则取消其选中状态
            if (selectedMenuItem != null)
            {
                selectedMenuItem.Checked = false;
            }

            // 切换语言
            SwitchLanguage(menuItemName);

            // 设置当前语言菜单项为选中状态
            clickedMenuItem.Checked = true;
            selectedMenuItem = clickedMenuItem; // 更新选中的菜单项
        }

        /// <summary>
        /// 加载资源文件
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        static Dictionary<string, string> LoadResources(string FilePath)
        {
            Dictionary<string, string> resources = new Dictionary<string, string>();

            if (File.Exists(FilePath))
            {
                string[] lines = File.ReadAllLines(FilePath);

                foreach (string line in lines)
                {
                    int separatorIndex = line.IndexOf('=');
                    if (separatorIndex > 0)
                    {
                        string key = line.Substring(0, separatorIndex);
                        string value = line.Substring(separatorIndex + 1);
                        resources[key] = value;
                    }
                }
            }

            return resources;
        }

        /// <summary>
        /// 编辑资源文件
        /// </summary>
        /// <param name="FilePath">修改文件的路径</param>
        /// <param name="key"></param>
        /// <param name="value">新值</param>
        static void EditResources(string FilePath, string key, string value)
        {
            string[] lines = File.ReadAllLines(FilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(key))
                {
                    int equalsIndex = lines[i].IndexOf("=");
                    string modifiedLine = lines[i].Substring(0, equalsIndex + 1) + value;
                    lines[i] = modifiedLine;
                    break;
                }
            }

            File.WriteAllLines(FilePath, lines);
        }

        /// <summary>
        /// 获取加载的资源值
        /// </summary>
        /// <param name="resources"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        static string GetResourceValue(Dictionary<string, string> resources, string key)
        {
            if (resources.ContainsKey(key))
            {
                return resources[key];
            }

            return string.Empty;
        }

        /// <summary>
        /// 生成随机密码
        /// </summary>
        /// <param name="length"></param>
        /// <param name="includeUppercase"></param>
        /// <param name="includeLowercase"></param>
        /// <param name="includeNumbers"></param>
        /// <param name="includeSymbols"></param>
        /// <param name="ignoredChars"></param>
        /// <returns></returns>
        private string GenerateRandomPassword(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSymbols, string ignoredChars)
        {
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // 定义大写
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz"; // 定义小写
            const string numberChars = "0123456789"; // 定义数字
            const string symbolChars = "!@#$%&*"; // 定义符号

            string chars = ""; // 基础生成的密码
            string password = ""; // 经过处理的密码

            Random random = new Random();

            if (includeUppercase)
            {
                chars += uppercaseChars;
            }
            if (includeLowercase)
            {
                chars += lowercaseChars;
            }
            if (includeNumbers)
            {
                chars += numberChars;
            }
            if (includeSymbols)
            {
                chars += symbolChars;
            }

            chars = new string(chars.Except(ignoredChars).ToArray());

            if (chars == "")
            {
                return null; // 返回null表示没有选择任何字符类型
            }

            do
            {
                password = new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            while (!IsValidPassword(password, includeUppercase, includeLowercase, includeNumbers, includeSymbols));

            return password;
        }

        static bool IsValidPassword(string password, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSymbols)
        {
            if (includeUppercase && !password.Any(char.IsUpper))
                return false;
            if (includeLowercase && !password.Any(char.IsLower))
                return false;
            if (includeNumbers && !password.Any(char.IsDigit))
                return false;
            if (includeSymbols && !password.Any(IsSymbol))
                return false;

            return true;
        }

        static bool IsSymbol(char c)
        {
            const string symbolChars = "!@#$%&*";
            return symbolChars.Contains(c);
        }

        private void HideLabelTimer_Tick(object sender, EventArgs e)
        {
            SuccessLabel.Visible = false;
        }

        

        // 复制按钮
        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(PassTextBox.Text);
            SuccessLabel.Visible = true;
            HideLabelTimer.Enabled = true;
        }

        // 生成按钮
        private void GetButton_Click(object sender, EventArgs e)
        {
            int length = int.Parse(PassLengthNumericUpDown.Text); // 获取密码长度
            bool includeUppercase = false; // 是否包含大写字母
            bool includeLowercase = false; // 是否包含小写字母
            bool includeNumbers = false; // 是否包含数字
            bool includeSymbolChars = false; // 是否包含符号
            string ignoredChars = IgnoredTextBox.Text; // 获取忽略的字符

            if (UppercaseCheckBox.Checked == true)
            {
                includeUppercase = true;
            }
            if (LowercaserCheckBox.Checked == true)
            {
                includeLowercase = true;
            }
            if (NumberCheckBox.Checked == true)
            {
                includeNumbers = true;
            }
            if (SymbolCheckBox.Checked == true)
            {
                includeSymbolChars = true;
            }

            string password = GenerateRandomPassword(length, includeUppercase, includeLowercase, includeNumbers, includeSymbolChars, ignoredChars);
            if (password == null)
            {
                MessageBox.Show(ErrorInfo, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PassTextBox.Text = password;
            }
        }

        // 官网
        private void WebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ialong.cn");
        }

        // 关于
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Get RandPass 1.0 \n\nCopyright © ialong.cn", AboutTitle);
        }
    }
}