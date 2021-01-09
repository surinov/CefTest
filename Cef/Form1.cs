using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;

namespace CefTest
{
    public partial class Form1 : Form
    {
        public int AddIndex { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
            comboBoxUrls.SelectedIndex = 2;
            comboBoxAdd.SelectedIndex = 3;
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

        private async void runButton_Click(object sender, EventArgs e)
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
            if (checkRemote.Checked)
            {
                await js.MakeRemote(false);
                label2.Text += "\n- Удаленный Есть.";
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

        private async void debugButton_Click(object sender, EventArgs e)
        {
            var js = new JsonSteps(webBrowser, loginDefBox.Text, passwordDefBox.Text, loginBox.Text, passwordBox.Text);
            await js.ChangeLogin("click", 50, 50, "remote", 14, 7, 300);
            logTextBox.Text += js.LastChangeResult;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (comboBoxAdd.SelectedIndex == 0)
                await ChangeStep("login");
            if (comboBoxAdd.SelectedIndex == 1)
                await ChangeStep("wifi");
            if (comboBoxAdd.SelectedIndex == 2)
                await ChangeStep("apn");
            if (comboBoxAdd.SelectedIndex == 3)
                await ChangeStep("remote");
        }

        private async Task ChangeStep(string part)
        {
            var x = int.Parse(addBoxX.Text);
            var y = int.Parse(addBoxY.Text);
            var @do = addBoxDo.Text;
            var text = addBoxText.Text;
            var del = int.Parse(addBoxDel.Text);
            var count = int.Parse(addBoxCount.Text);
            var jc = new JsonChange();
            if (part == "login")
                await jc.AddStepLogin(@do, x, y, text, count, AddIndex, del);
            if (part == "wifi")
                await jc.AddStepWifi(@do, x, y, text, count, AddIndex, del);
            if (part == "apn")
                await jc.AddStepApn(@do, x, y, text, count, AddIndex, del);
            if (part == "remote")
                await jc.AddStepRemote(@do, x, y, text, count, AddIndex, del);
            logTextBox.Text += jc.LastChangeResult + AddIndex;
            AddIndex += 1;
        }
    }
}
