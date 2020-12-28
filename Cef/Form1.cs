using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;

namespace CefTest
{
    public partial class Form1 : Form
    {
        private int _step = 0;
        private int _click = 0;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            chromiumWebBrowser1.Load(addressBox.Text);
            GetCursorPos();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeStep();
        }

        public async void MakeStep()
        {
            var steps = new Steps(0, chromiumWebBrowser1, label2, label3, loginDefBox.Text, passwordDefBox.Text,loginBox.Text,passwordBox.Text);
            int i = 0;
            while (i < 10)
            {
                chromiumWebBrowser1.Focus();
                steps.MakeStep(i);
                //await Task.Run(() => steps.MakeStep(i));
                await Task.Delay(1000);
                i++;
            }
        }

        public async void GetCursorPos()
        {
            try
            {
                while (true)
                {
                    var point = label3.PointToClient(Cursor.Position);
                    var cX = point.X;
                    var cY = point.Y;
                    await Task.Delay(10);
                    label3.Text = @"X = " + cX + ", Y = " + cY;
                }
            }
            catch { }
        }

        private void adressButton_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(addressBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Focus();
            chromiumWebBrowser1.SendMouseWheelEvent(5,5,0,-110, CefEventFlags.LeftMouseButton);
        }

    }
}
