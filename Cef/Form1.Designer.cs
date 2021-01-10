
using CefSharp;
using CefSharp.WinForms;

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
            this.runButton = new System.Windows.Forms.Button();
            this.passwordDefBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adressButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.debugButton = new System.Windows.Forms.Button();
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
            this.checkRemote = new System.Windows.Forms.CheckBox();
            this.checkAPN = new System.Windows.Forms.CheckBox();
            this.checkWifi = new System.Windows.Forms.CheckBox();
            this.checkAuth = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.addBoxX = new System.Windows.Forms.TextBox();
            this.addBoxY = new System.Windows.Forms.TextBox();
            this.addBoxText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addBoxDel = new System.Windows.Forms.TextBox();
            this.addBoxCount = new System.Windows.Forms.TextBox();
            this.tabControlAdd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxAdd = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxDo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControlAdd.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // runButton
            // 
            this.runButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runButton.Location = new System.Drawing.Point(19, 127);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 26);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
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
            this.label2.Location = new System.Drawing.Point(1013, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Лог:";
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(1027, 404);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(75, 23);
            this.debugButton.TabIndex = 8;
            this.debugButton.Text = "Debug";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(880, 591);
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
            this.loginBox.Text = "lte05819-4";
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
            this.groupBox3.Controls.Add(this.checkRemote);
            this.groupBox3.Controls.Add(this.checkAPN);
            this.groupBox3.Controls.Add(this.checkWifi);
            this.groupBox3.Controls.Add(this.checkAuth);
            this.groupBox3.Controls.Add(this.runButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(1008, 242);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(125, 157);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Шаги";
            // 
            // checkRemote
            // 
            this.checkRemote.AutoSize = true;
            this.checkRemote.Checked = true;
            this.checkRemote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRemote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkRemote.Font = new System.Drawing.Font("Microsoft YaHei", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkRemote.Location = new System.Drawing.Point(8, 102);
            this.checkRemote.Margin = new System.Windows.Forms.Padding(2);
            this.checkRemote.Name = "checkRemote";
            this.checkRemote.Size = new System.Drawing.Size(89, 20);
            this.checkRemote.TabIndex = 3;
            this.checkRemote.Text = "Удаленный";
            this.checkRemote.UseVisualStyleBackColor = true;
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
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(1136, 454);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(124, 150);
            this.logTextBox.TabIndex = 22;
            this.logTextBox.Text = "";
            // 
            // addBoxX
            // 
            this.addBoxX.Location = new System.Drawing.Point(6, 43);
            this.addBoxX.Name = "addBoxX";
            this.addBoxX.Size = new System.Drawing.Size(45, 20);
            this.addBoxX.TabIndex = 23;
            this.addBoxX.Text = "500";
            // 
            // addBoxY
            // 
            this.addBoxY.Location = new System.Drawing.Point(65, 43);
            this.addBoxY.Name = "addBoxY";
            this.addBoxY.Size = new System.Drawing.Size(45, 20);
            this.addBoxY.TabIndex = 25;
            this.addBoxY.Text = "500";
            // 
            // addBoxText
            // 
            this.addBoxText.Location = new System.Drawing.Point(65, 83);
            this.addBoxText.Name = "addBoxText";
            this.addBoxText.Size = new System.Drawing.Size(45, 20);
            this.addBoxText.TabIndex = 26;
            this.addBoxText.Text = "helloW";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(22, 151);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 28;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addBoxDel
            // 
            this.addBoxDel.Location = new System.Drawing.Point(6, 125);
            this.addBoxDel.Name = "addBoxDel";
            this.addBoxDel.Size = new System.Drawing.Size(45, 20);
            this.addBoxDel.TabIndex = 29;
            this.addBoxDel.Text = "500";
            // 
            // addBoxCount
            // 
            this.addBoxCount.Location = new System.Drawing.Point(65, 125);
            this.addBoxCount.Name = "addBoxCount";
            this.addBoxCount.Size = new System.Drawing.Size(45, 20);
            this.addBoxCount.TabIndex = 30;
            this.addBoxCount.Text = "14";
            // 
            // tabControlAdd
            // 
            this.tabControlAdd.Controls.Add(this.tabPage1);
            this.tabControlAdd.Controls.Add(this.tabPage2);
            this.tabControlAdd.Location = new System.Drawing.Point(1136, 242);
            this.tabControlAdd.Name = "tabControlAdd";
            this.tabControlAdd.SelectedIndex = 0;
            this.tabControlAdd.Size = new System.Drawing.Size(124, 206);
            this.tabControlAdd.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxDo);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboBoxAdd);
            this.tabPage1.Controls.Add(this.addBoxX);
            this.tabPage1.Controls.Add(this.addBoxY);
            this.tabPage1.Controls.Add(this.addBoxCount);
            this.tabPage1.Controls.Add(this.addBoxText);
            this.tabPage1.Controls.Add(this.addBoxDel);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(116, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шаг";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Count";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Del";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Do";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "X";
            // 
            // comboBoxAdd
            // 
            this.comboBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdd.FormattingEnabled = true;
            this.comboBoxAdd.Items.AddRange(new object[] {
            "login",
            "wifi",
            "apn",
            "remote"});
            this.comboBoxAdd.Location = new System.Drawing.Point(6, 5);
            this.comboBoxAdd.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAdd.Name = "comboBoxAdd";
            this.comboBoxAdd.Size = new System.Drawing.Size(104, 21);
            this.comboBoxAdd.TabIndex = 31;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(116, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "P2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxDo
            // 
            this.comboBoxDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDo.FormattingEnabled = true;
            this.comboBoxDo.Items.AddRange(new object[] {
            "click",
            "input",
            "delete"});
            this.comboBoxDo.Location = new System.Drawing.Point(6, 82);
            this.comboBoxDo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDo.Name = "comboBoxDo";
            this.comboBoxDo.Size = new System.Drawing.Size(45, 21);
            this.comboBoxDo.TabIndex = 38;
            this.comboBoxDo.SelectedIndexChanged += new System.EventHandler(this.comboBoxDo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 605);
            this.Controls.Add(this.tabControlAdd);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debugButton);
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
            this.tabControlAdd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox passwordDefBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adressButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button debugButton;
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
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.CheckBox checkRemote;
        private System.Windows.Forms.TextBox addBoxX;
        private System.Windows.Forms.TextBox addBoxY;
        private System.Windows.Forms.TextBox addBoxText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addBoxDel;
        private System.Windows.Forms.TextBox addBoxCount;
        private System.Windows.Forms.TabControl tabControlAdd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxAdd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxDo;
    }
}

