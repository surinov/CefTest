﻿
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
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adressButton = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.navigateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(3, 3);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1000, 600);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1054, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(1042, 323);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.Text = "windows10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1039, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // adressButton
            // 
            this.adressButton.Location = new System.Drawing.Point(1054, 231);
            this.adressButton.Name = "adressButton";
            this.adressButton.Size = new System.Drawing.Size(75, 23);
            this.adressButton.TabIndex = 4;
            this.adressButton.Text = "Open page";
            this.adressButton.UseVisualStyleBackColor = true;
            this.adressButton.Click += new System.EventHandler(this.adressButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(1030, 205);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(126, 20);
            this.addressBox.TabIndex = 5;
            this.addressBox.Text = "http://192.168.0.1/";
            // 
            // navigateBox
            // 
            this.navigateBox.Location = new System.Drawing.Point(1030, 106);
            this.navigateBox.Name = "navigateBox";
            this.navigateBox.Size = new System.Drawing.Size(126, 20);
            this.navigateBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 623);
            this.Controls.Add(this.navigateBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.adressButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CefTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adressButton;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox navigateBox;
    }
}

