using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

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
            MakeStepAsync();
        }

        async void MakeStepAsync()
        {
            await Task.Run(() => MakeStep());
        }
        public void MakeStep()
        { 
            switch (_step)
            {
                case 0:
                    //label2.Text = $@"Step {_step} done";
                    RunScript($@"
            document.getElementById('pc-login-password').value = '{passwordBox.Text}';
            document.getElementById('pc-login-btn').click();");
                    _step = 1;
                    break;
                case 1:
                    //label2.Text = $@"Step {_step} done";
                    RunScript($@"document.getElementById('advanced').click();");
                    _step = 2;
                    break;
                case 2:
                    //label2.Text = $@"Step {_step} done";
                    MouseClick(50, 300);
                    _step = 3;
                    break;
                case 3:
                    //label2.Text = $@"Step {_step} done";
                    MouseClick(50, 170);
                    _step = 4;
                    break;
                case 4:
                    //label2.Text = $@"Step {_step} done";
                    string stript = (@"
            document.getElementById('ssid').value = 'Hello';
                    ");
                    RunScript(stript);
                    _step = 5;
                    break;
            }
        }

        private void adressButton_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(addressBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (_click)
            {
                case 0:
                    MouseClick(50, 300);
                    _click = 1;
                    break;
                case 1:
                    MouseClick(50,170);
                    _click = 0;
                    break;
            }
        }

        public void MouseClick(int x, int y)
        {
            chromiumWebBrowser1.GetBrowser().GetHost().SendMouseClickEvent(x, y, MouseButtonType.Left, false, 1, CefEventFlags.None);
            System.Threading.Thread.Sleep(10);
            chromiumWebBrowser1.GetBrowser().GetHost().SendMouseClickEvent(x, y, MouseButtonType.Left, true, 1, CefEventFlags.None);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void chromiumWebBrowser1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Point point = label3.PointToClient(Cursor.Position);
            MessageBox.Show(point.ToString());
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Point point = label3.PointToClient(Cursor.Position);
            MessageBox.Show(point.ToString());
        }
    }
}
