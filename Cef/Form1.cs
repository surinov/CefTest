﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefTest
{
    public delegate void MyDelegate(int x,int y);
    public partial class Form1 : Form
    {
        public int AddIndex { get; set; } = 0;
        public string mess { get; set; }
        public Form1()
        {
            InitializeComponent();
            comboBoxUrls.SelectedIndex = 2;
            comboBoxAdd.SelectedIndex = 3;
            comboBoxDo.SelectedIndex = 0;
        }

        protected override void OnLoad(EventArgs e)
        {
            webBrowser.Load(comboBoxUrls.SelectedItem.ToString());
            GetCursorPos();
            //var l = new Log();
            //l.Notify += L_Notify;
        }

        public async void L_Notify(string message)
        {
            await Task.Delay(10);
            label2.Text = message;
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

        public async Task GetCursorPos()
        {
            try
            {
                while (true)
                {
                    var point = webBrowser.PointToClient(Cursor.Position);
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

        private void debugButton_Click(object sender, EventArgs e)
        {
            //ignored
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxAdd.SelectedIndex)
                {
                    case 0:
                        await ChangeStep("login");
                        break;
                    case 1:
                        await ChangeStep("wifi");
                        break;
                    case 2:
                        await ChangeStep("apn");
                        break;
                    case 3:
                        await ChangeStep("remote");
                        break;
                }
            }
            catch { //ignored
            }
        }

        private async Task ChangeStep(string part)
        {
            var x = addBoxX.Enabled? int.Parse(addBoxX.Text) : 0;
            var y = addBoxY.Enabled? int.Parse(addBoxY.Text) : 0;
            var @do = comboBoxDo.SelectedItem.ToString();
            var text = addBoxText.Enabled? addBoxText.Text: null;
            var del = int.Parse(addBoxDel.Text);
            var count = addBoxCount.Enabled? int.Parse(addBoxCount.Text) : 0;
            var jc = new JsonChange();
            if (part == "login")
                await jc.AddStepLogin(@do, x, y, text, count, AddIndex, del);
            if (part == "wifi")
                await jc.AddStepWifi(@do, x, y, text, count, AddIndex, del);
            if (part == "apn")
                await jc.AddStepApn(@do, x, y, text, count, AddIndex, del);
            if (part == "remote")
                await jc.AddStepRemote(@do, x, y, text, count, AddIndex, del);
            logTextBox.Text += jc.LastChangeResult;
            AddIndex += 1;
        }

        private void comboBoxDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDo.SelectedIndex)
            {
                case 0:
                    addBoxX.Enabled = true;
                    addBoxY.Enabled = true;
                    addOutForm.Enabled = true;
                    addBoxCount.Enabled = false;
                    addBoxDel.Enabled = false;
                    addBoxText.Enabled = false;
                    break;
                case 1:
                    addBoxText.Enabled = true;
                    addBoxX.Enabled = false;
                    addBoxY.Enabled = false;
                    addBoxDel.Enabled = false;
                    addBoxCount.Enabled = false;
                    addOutForm.Enabled = false;
                    break;
                case 2:
                    addBoxCount.Enabled = true;
                    addBoxText.Enabled = false;
                    addBoxX.Enabled = false;
                    addBoxY.Enabled = false;
                    addBoxDel.Enabled = false;
                    addOutForm.Enabled = false;
                    break;
            }
        }

        private void addOutForm_Click(object sender, EventArgs e)
        {
            try
            {
                var bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                var g = Graphics.FromImage(bmp);
                var size = new Size(Screen.PrimaryScreen.Bounds.Size.Height - 100,
                    Screen.PrimaryScreen.Bounds.Size.Width - 100);
                g.CopyFromScreen(0, 25, 0, 0,
                    Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                var newForm = new Form2(bmp, Add);
                newForm.Show();
            }
            catch
            { // ignored
            }
        }
        private void Add(int x, int y)
        {
            addBoxX.Text = x.ToString();
            addBoxY.Text = y.ToString();
        }
    }
}
