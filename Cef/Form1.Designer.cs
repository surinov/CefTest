
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(4, 4);
            this.chromiumWebBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1333, 738);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1409, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(1393, 420);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(132, 22);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.Text = "77290199";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1389, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // adressButton
            // 
            this.adressButton.Location = new System.Drawing.Point(1405, 284);
            this.adressButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adressButton.Name = "adressButton";
            this.adressButton.Size = new System.Drawing.Size(100, 28);
            this.adressButton.TabIndex = 4;
            this.adressButton.Text = "Open page";
            this.adressButton.UseVisualStyleBackColor = true;
            this.adressButton.Click += new System.EventHandler(this.adressButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(1373, 252);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(167, 22);
            this.addressBox.TabIndex = 5;
            this.addressBox.Text = "http://192.168.1.1/";
            // 
            // navigateBox
            // 
            this.navigateBox.Location = new System.Drawing.Point(1373, 130);
            this.navigateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navigateBox.Name = "navigateBox";
            this.navigateBox.Size = new System.Drawing.Size(167, 22);
            this.navigateBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1389, 559);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Step";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1409, 503);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Debug button";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1389, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Login";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(1393, 372);
            this.logBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(132, 22);
            this.logBox.TabIndex = 11;
            this.logBox.Text = "admin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 767);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navigateBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.adressButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "CefTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox logBox;
    }
}

