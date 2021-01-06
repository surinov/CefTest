using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;

namespace CefTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxUrls.SelectedIndex = 2;
        }

        protected override void OnLoad(EventArgs e)
        {
            webBrowser.Load(comboBoxUrls.SelectedItem.ToString());
            GetCursorPos();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private bool TextboxIsNull()
        {
            return loginDefBox.Text == string.Empty || loginBox.Text == string.Empty || passwordDefBox.Text == string.Empty || 
                   passwordBox.Text == string.Empty;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!TextboxIsNull()) {
                try{await MakeStep();}
                catch { // ignored
                }
            }
        }

        public async Task MakeStep()
        {
            var js = new JsonSteps(webBrowser,loginDefBox.Text, passwordDefBox.Text, loginBox.Text, passwordBox.Text);
            label2.Text = $@"Log: {js.GetName()}";
            js.SetDelay(500);
            webBrowser.Focus();
            if (checkAuth.Checked)
            {
                await js.MakeLogin(false);
                label2.Text += "\n- Login Есть.";
            }

            if (checkWifi.Checked)
            {
                await js.MakeWifi(false);
                label2.Text += "\n- WiFi Есть.";
            }

            if (checkAPN.Checked)
            {
                await js.MakeApn(false);
                label2.Text += "\n- APN Есть.";
            }
        }

        public async void GetCursorPos()
        {
            try
            {
                while (true)
                {
                    var point = label7.PointToClient(Cursor.Position);
                    var cX = point.X;
                    var cY = point.Y;
                    await Task.Delay(10);
                    label3.Text = @"X: " + cX + ", Y: " + cY;
                }
            }
            catch {// ignored
            }
        }

        private void adressButton_Click(object sender, EventArgs e)
        {
            webBrowser.Load(comboBoxUrls.SelectedItem.ToString());
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var js = new JsonSteps(webBrowser, loginDefBox.Text, passwordDefBox.Text, loginBox.Text, passwordBox.Text);
            await js.ChangeLogin("click", 50, 50, "helloo", 14, 4, 300);
            logTextBox.Text += js.LastChangeResult;
        }
    }
}
