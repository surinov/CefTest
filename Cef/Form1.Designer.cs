
namespace CefTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordDefBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adressButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginDefBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxUrls = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkAPN = new System.Windows.Forms.CheckBox();
            this.checkWifi = new System.Windows.Forms.CheckBox();
            this.checkAuth = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.ActivateBrowserOnCreation = false;
            this.webBrowser.Location = new System.Drawing.Point(1, 1);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(1);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1000, 589);
            this.webBrowser.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(18, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordDefBox
            // 
            this.passwordDefBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordDefBox.Location = new System.Drawing.Point(5, 94);
            this.passwordDefBox.Name = "passwordDefBox";
            this.passwordDefBox.Size = new System.Drawing.Size(100, 24);
            this.passwordDefBox.TabIndex = 2;
            this.passwordDefBox.Text = "77290199";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пароль";
            // 
            // adressButton
            // 
            this.adressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adressButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressButton.Location = new System.Drawing.Point(18, 50);
            this.adressButton.Name = "adressButton";
            this.adressButton.Size = new System.Drawing.Size(75, 26);
            this.adressButton.TabIndex = 4;
            this.adressButton.Text = "Open";
            this.adressButton.UseVisualStyleBackColor = true;
            this.adressButton.Click += new System.EventHandler(this.adressButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1141, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Лог:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1027, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Debug";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1026, 564);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "lable3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Логин";
            // 
            // loginDefBox
            // 
            this.loginDefBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginDefBox.Location = new System.Drawing.Point(5, 45);
            this.loginDefBox.Name = "loginDefBox";
            this.loginDefBox.Size = new System.Drawing.Size(100, 24);
            this.loginDefBox.TabIndex = 11;
            this.loginDefBox.Text = "admin";
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(5, 45);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 24);
            this.loginBox.TabIndex = 15;
            this.loginBox.Text = "te05819-4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Пароль";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(5, 94);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 24);
            this.passwordBox.TabIndex = 12;
            this.passwordBox.Text = "77290199";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passwordDefBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loginDefBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1008, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(124, 138);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Войти:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.passwordBox);
            this.groupBox2.Controls.Add(this.loginBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(1136, 90);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(124, 138);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Установить:";
            // 
            // comboBoxUrls
            // 
            this.comboBoxUrls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxUrls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUrls.FormattingEnabled = true;
            this.comboBoxUrls.Items.AddRange(new object[] {
            "http://192.168.1.1/",
            "http://192.168.0.1/",
            "https://emulator.tp-link.com/TL-MR6400(EU)_V2_new/userRpm/Index.htm"});
            this.comboBoxUrls.Location = new System.Drawing.Point(4, 17);
            this.comboBoxUrls.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUrls.Name = "comboBoxUrls";
            this.comboBoxUrls.Size = new System.Drawing.Size(180, 24);
            this.comboBoxUrls.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkAPN);
            this.groupBox3.Controls.Add(this.checkWifi);
            this.groupBox3.Controls.Add(this.checkAuth);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(1009, 280);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(125, 140);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Шаги";
            // 
            // checkAPN
            // 
            this.checkAPN.AutoSize = true;
            this.checkAPN.Checked = true;
            this.checkAPN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkAPN.Font = new System.Drawing.Font("Microsoft YaHei", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAPN.Location = new System.Drawing.Point(8, 78);
            this.checkAPN.Margin = new System.Windows.Forms.Padding(2);
            this.checkAPN.Name = "checkAPN";
            this.checkAPN.Size = new System.Drawing.Size(102, 20);
            this.checkAPN.TabIndex = 2;
            this.checkAPN.Text = "APN профиль";
            this.checkAPN.UseVisualStyleBackColor = true;
            // 
            // checkWifi
            // 
            this.checkWifi.AutoSize = true;
            this.checkWifi.Checked = true;
            this.checkWifi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWifi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkWifi.Font = new System.Drawing.Font("Microsoft YaHei", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkWifi.Location = new System.Drawing.Point(8, 51);
            this.checkWifi.Margin = new System.Windows.Forms.Padding(2);
            this.checkWifi.Name = "checkWifi";
            this.checkWifi.Size = new System.Drawing.Size(75, 20);
            this.checkWifi.TabIndex = 1;
            this.checkWifi.Text = "Сеть Wifi";
            this.checkWifi.UseVisualStyleBackColor = true;
            // 
            // checkAuth
            // 
            this.checkAuth.AutoSize = true;
            this.checkAuth.Checked = true;
            this.checkAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkAuth.Font = new System.Drawing.Font("Microsoft YaHei", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAuth.Location = new System.Drawing.Point(8, 24);
            this.checkAuth.Margin = new System.Windows.Forms.Padding(2);
            this.checkAuth.Name = "checkAuth";
            this.checkAuth.Size = new System.Drawing.Size(98, 20);
            this.checkAuth.TabIndex = 0;
            this.checkAuth.Text = "Авторизация";
            this.checkAuth.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxUrls);
            this.groupBox4.Controls.Add(this.adressButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(1009, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(188, 81);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Веб адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 605);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1262, 644);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Router Configuration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordDefBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adressButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginDefBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxUrls;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkAPN;
        private System.Windows.Forms.CheckBox checkWifi;
        private System.Windows.Forms.CheckBox checkAuth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        public CefSharp.WinForms.ChromiumWebBrowser webBrowser;
    }
}

