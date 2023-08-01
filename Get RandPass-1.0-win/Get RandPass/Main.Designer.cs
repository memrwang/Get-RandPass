namespace GetRandPass
{
    partial class GetRandPass
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetRandPass));
            this.GetButton = new System.Windows.Forms.Button();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.LowercaserCheckBox = new System.Windows.Forms.CheckBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.UppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.NumberCheckBox = new System.Windows.Forms.CheckBox();
            this.SymbolCheckBox = new System.Windows.Forms.CheckBox();
            this.PassLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.HideLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.IgnoredLabel = new System.Windows.Forms.Label();
            this.IgnoredTextBox = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PassLengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.BackColor = System.Drawing.SystemColors.Control;
            this.GetButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GetButton.Location = new System.Drawing.Point(456, 75);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(60, 35);
            this.GetButton.TabIndex = 0;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // PassTextBox
            // 
            this.PassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.PassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTextBox.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.PassTextBox.Location = new System.Drawing.Point(89, 79);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(285, 27);
            this.PassTextBox.TabIndex = 1;
            // 
            // LowercaserCheckBox
            // 
            this.LowercaserCheckBox.AutoSize = true;
            this.LowercaserCheckBox.Checked = true;
            this.LowercaserCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowercaserCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LowercaserCheckBox.Location = new System.Drawing.Point(84, 171);
            this.LowercaserCheckBox.Name = "LowercaserCheckBox";
            this.LowercaserCheckBox.Size = new System.Drawing.Size(114, 16);
            this.LowercaserCheckBox.TabIndex = 2;
            this.LowercaserCheckBox.Text = "Lowercases(a-z)";
            this.LowercaserCheckBox.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.SystemColors.Control;
            this.CopyButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CopyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CopyButton.Location = new System.Drawing.Point(390, 75);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(60, 35);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // UppercaseCheckBox
            // 
            this.UppercaseCheckBox.AutoSize = true;
            this.UppercaseCheckBox.Checked = true;
            this.UppercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UppercaseCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.UppercaseCheckBox.Location = new System.Drawing.Point(84, 149);
            this.UppercaseCheckBox.Name = "UppercaseCheckBox";
            this.UppercaseCheckBox.Size = new System.Drawing.Size(114, 16);
            this.UppercaseCheckBox.TabIndex = 4;
            this.UppercaseCheckBox.Text = "Uppercases(A-Z)";
            this.UppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumberCheckBox
            // 
            this.NumberCheckBox.AutoSize = true;
            this.NumberCheckBox.Checked = true;
            this.NumberCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumberCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.NumberCheckBox.Location = new System.Drawing.Point(84, 193);
            this.NumberCheckBox.Name = "NumberCheckBox";
            this.NumberCheckBox.Size = new System.Drawing.Size(96, 16);
            this.NumberCheckBox.TabIndex = 5;
            this.NumberCheckBox.Text = "Numbers(0-9)";
            this.NumberCheckBox.UseVisualStyleBackColor = true;
            // 
            // SymbolCheckBox
            // 
            this.SymbolCheckBox.AutoSize = true;
            this.SymbolCheckBox.Checked = true;
            this.SymbolCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SymbolCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SymbolCheckBox.Location = new System.Drawing.Point(84, 215);
            this.SymbolCheckBox.Name = "SymbolCheckBox";
            this.SymbolCheckBox.Size = new System.Drawing.Size(114, 16);
            this.SymbolCheckBox.TabIndex = 6;
            this.SymbolCheckBox.Text = "Symbols(!@#$%&*)";
            this.SymbolCheckBox.UseVisualStyleBackColor = true;
            // 
            // PassLengthNumericUpDown
            // 
            this.PassLengthNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.PassLengthNumericUpDown.Location = new System.Drawing.Point(300, 148);
            this.PassLengthNumericUpDown.Name = "PassLengthNumericUpDown";
            this.PassLengthNumericUpDown.Size = new System.Drawing.Size(60, 21);
            this.PassLengthNumericUpDown.TabIndex = 7;
            this.PassLengthNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LengthLabel.Location = new System.Drawing.Point(246, 150);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(47, 12);
            this.LengthLabel.TabIndex = 8;
            this.LengthLabel.Text = "Length:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PassLabel.Location = new System.Drawing.Point(30, 83);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(44, 19);
            this.PassLabel.TabIndex = 9;
            this.PassLabel.Text = "Pass:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.pictureBox1.Location = new System.Drawing.Point(84, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 37);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pictureBox2.Location = new System.Drawing.Point(79, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 47);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SuccessLabel.Location = new System.Drawing.Point(397, 123);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(47, 12);
            this.SuccessLabel.TabIndex = 12;
            this.SuccessLabel.Text = "Success";
            // 
            // HideLabelTimer
            // 
            this.HideLabelTimer.Interval = 1000;
            this.HideLabelTimer.Tick += new System.EventHandler(this.HideLabelTimer_Tick);
            // 
            // IgnoredLabel
            // 
            this.IgnoredLabel.AutoSize = true;
            this.IgnoredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.IgnoredLabel.Location = new System.Drawing.Point(240, 184);
            this.IgnoredLabel.Name = "IgnoredLabel";
            this.IgnoredLabel.Size = new System.Drawing.Size(53, 12);
            this.IgnoredLabel.TabIndex = 14;
            this.IgnoredLabel.Text = "ignored:";
            // 
            // IgnoredTextBox
            // 
            this.IgnoredTextBox.Location = new System.Drawing.Point(300, 181);
            this.IgnoredTextBox.Name = "IgnoredTextBox";
            this.IgnoredTextBox.Size = new System.Drawing.Size(60, 21);
            this.IgnoredTextBox.TabIndex = 15;
            this.IgnoredTextBox.Text = "1iIl0oO";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.White;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(556, 25);
            this.MenuStrip.TabIndex = 16;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageToolStripMenuItem});
            this.SettingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.SettingToolStripMenuItem.Text = "Setting";
            // 
            // LanguageToolStripMenuItem
            // 
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            this.LanguageToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.LanguageToolStripMenuItem.Text = "Language";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WebsiteToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // WebsiteToolStripMenuItem
            // 
            this.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem";
            this.WebsiteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.WebsiteToolStripMenuItem.Text = "Website";
            this.WebsiteToolStripMenuItem.Click += new System.EventHandler(this.WebsiteToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // GetRandPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(556, 276);
            this.Controls.Add(this.IgnoredTextBox);
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.PassLengthNumericUpDown);
            this.Controls.Add(this.SymbolCheckBox);
            this.Controls.Add(this.NumberCheckBox);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.IgnoredLabel);
            this.Controls.Add(this.UppercaseCheckBox);
            this.Controls.Add(this.LowercaserCheckBox);
            this.Controls.Add(this.MenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "GetRandPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get RandPass";
            this.Load += new System.EventHandler(this.GetRandPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PassLengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.CheckBox LowercaserCheckBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.CheckBox UppercaseCheckBox;
        private System.Windows.Forms.CheckBox NumberCheckBox;
        private System.Windows.Forms.CheckBox SymbolCheckBox;
        private System.Windows.Forms.NumericUpDown PassLengthNumericUpDown;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Timer HideLabelTimer;
        private System.Windows.Forms.Label IgnoredLabel;
        private System.Windows.Forms.TextBox IgnoredTextBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WebsiteToolStripMenuItem;
    }
}

