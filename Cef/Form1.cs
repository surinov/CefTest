using System;
using System.Drawing;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnLoad(EventArgs e)
        {
            chromiumWebBrowser1.Load(addressBox.Text);
        }

        public void RunScript(string script)
        {
            chromiumWebBrowser1.ExecuteScriptAsyncWhenPageLoaded(script);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunScript($@"
            document.getElementById('pc-login-password').value = '{passwordBox.Text}';
            document.getElementById('pc-login-btn').click();");
        }

        private void adressButton_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(addressBox.Text);
        }
    }
}
