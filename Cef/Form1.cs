using System;
using System.Drawing;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefTest
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser _browser;
        public Form1()
        {
            InitializeComponent();
            InitializeChromium();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnLoad(EventArgs e)
        {
            _browser.Load(addressBox.Text);
        }

        public void InitializeChromium()
        {
            var settings = new CefSettings();
            Cef.Initialize(settings);
            _browser = new ChromiumWebBrowser();
            this.Controls.Add(_browser);
            _browser.Dock = DockStyle.None;
            _browser.Width = 1000;
            _browser.Height = 600;
            _browser.Location = new Point(12,12);
        }

        public void RunScript(string script)
        {
            _browser.ExecuteScriptAsyncWhenPageLoaded(script);
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
            _browser.Load(addressBox.Text);
        }
    }
}
