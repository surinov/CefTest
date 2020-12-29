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
            chromiumWebBrowser1.Load(comboBoxUrls.SelectedItem.ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TextboxIsNull())
            {
                try{MakeStep();}
                catch
                {
                    // ignored
                }
            }
        }

        public async void MakeStep()
        {
            label2.Text = "Log: ";
            var steps = new Steps(chromiumWebBrowser1, loginDefBox.Text, passwordDefBox.Text,loginBox.Text,passwordBox.Text);
            if (checkAuth.Checked)
            {
                var l = 0;
                while (l < 3)
                {
                    chromiumWebBrowser1.Focus();
                    steps.MakeLogIn(l);
                    await Task.Delay(1000);
                    l++;
                }
                label2.Text += "\n- Login Есть.";
            }

            if (checkWifi.Checked)
            {
                var i = 0;
                while (i < 10)
                {
                    chromiumWebBrowser1.Focus();
                    steps.MakeStepWifi(i);
                    await Task.Delay(1000);
                    i++;
                }
                label2.Text += "\n- WiFi Есть.";
            }

            if (checkAPN.Checked)
            {
                var k = 0;
                while (k < 7)
                {
                    chromiumWebBrowser1.Focus();
                    steps.MakeStepApn(k);
                    await Task.Delay(1000);
                    k++;
                }
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
            catch
            {
                // ignored
            }
        }

        private void adressButton_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(comboBoxUrls.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedState = comboBoxUrls.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }
    }
}
