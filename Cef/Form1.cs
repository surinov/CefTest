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
            var steps = new Steps(0, chromiumWebBrowser1, label2, label3, logBox.Text, passwordBox.Text);
            int i = 0;
            while (_step < 5)
            {
                await Task.Delay(1000);
                steps.MakeStep(i);
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
            for (int i = 0; i < 9; i++)
            {
                SendKeys.Send("{BS}");
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
