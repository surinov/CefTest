using CefSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace CefTest
{
    public delegate void SetCoordinates(int x, int y);
    public delegate void AddFileName(string name, string route, string deflogin,string defPass);
    public delegate void AddInput(string input);
    public partial class Form1 : Form
    {
        public int AddIndex { get; set; } = 0;
        private string _path { get; set; } = Directory.GetCurrentDirectory();
        private string _file = "mr6400v2.json";
        public Form1()
        {
            var settings = new CefSettings()
            {
                IgnoreCertificateErrors = true
            };
            settings.CefCommandLineArgs.Add("ignore-certificate-errors", string.Empty);
            Cef.Initialize(settings);
            InitializeComponent();
            RefreshModelsList();
            /*0-mr6400v2 1-mr6400v4 2-lte3202 3-mr600*/
            comboBoxModels.SelectedIndex = 0;
            comboBoxUrls.SelectedIndex = 2;
            comboBoxAdd.SelectedIndex = 0;
            comboBoxDo.SelectedIndex = 0;
            groupBox1.Visible = false;
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
        private string GetModelName()
        {
            try
            {
                var model = comboBoxModels.SelectedItem.ToString().ToLower().Replace("\n", "");
                return model;
            }
            catch
            {
                return null;
            }
        }

        private async void runButton_Click(object sender, EventArgs e)
        {
            if (!TextboxIsNull())
            {
                try
                {
                    if (GetModelName() == null) return;
                    _file = GetModelName();
                    logTextBox.Text = GetModelName();
                    await MakeStep();
                }
                catch { logTextBox.Text += @"Что-то пошло не так"; }
            }
        }

        public async Task MakeStep()
        {
            var js = new JsonSteps(webBrowser, loginDefBox.Text, passwordDefBox.Text, loginBox.Text, passwordBox.Text, _file);
            logTextBox.Text = $@"Log: {js.GetName()} {js.GetRoute()}";
            var onjsdel = checkBox1.Checked ? true : false;
            js.SetDelay(500);
            webBrowser.Focus();
            if (checkAuth.Checked)
            {
                await js.MakeLogin(onjsdel);
                logTextBox.Text += "\n- Login Есть.";
            }

            if (checkAPN.Checked)
            {
                await js.MakeApn(onjsdel);
                logTextBox.Text += "\n- APN Есть.";
            }

            if (checkWifi.Checked)
            {
                await js.MakeWifi(onjsdel);
                logTextBox.Text += "\n- WiFi Есть.";
            }

            if (checkRemote.Checked)
            {
                await js.MakeRemote(onjsdel);
                logTextBox.Text += "\n- Удаленный Есть.";
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
                    if(cX < 1025 && cY < 590) label3.Text = @"X: " + cX + ", Y: " + cY;
                    else label3.Text = "";
                }
            }
            catch { logTextBox.Text += @"Что-то пошло не так"; }
        }

        private void adressButton_Click(object sender, EventArgs e)
        {
            webBrowser.Load(comboBoxUrls.SelectedItem.ToString());
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
            catch { logTextBox.Text += @"Что-то пошло не так"; }
        }

        private async Task ChangeStep(string part)
        {
            try
            {
                AddIndex = int.Parse(textBoxStep.Text);
            }
            catch{}
            var x = addBoxX.Enabled ? int.Parse(addBoxX.Text) : 0;
            var y = addBoxY.Enabled ? int.Parse(addBoxY.Text) : 0;
            var @do = comboBoxDo.SelectedItem.ToString();
            var text = addBoxText.Enabled ? addBoxText.Text : null;
            var del = int.Parse(addBoxDel.Text);
            var count = addBoxCount.Enabled ? int.Parse(addBoxCount.Text) : 0;
            var jc = new JsonChange(GetModelName());
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
            textBoxStep.Text = AddIndex.ToString();
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
                    addBoxDel.Enabled = true;
                    addBoxText.Enabled = false;
                    OpenInputForm.Enabled = false;
                    addBoxCount.Visible = false;
                    labelCount.Visible = false;
                    break;
                case 1:
                    addBoxText.Enabled = true;
                    OpenInputForm.Enabled = true;
                    addBoxX.Enabled = false;
                    addBoxY.Enabled = false;
                    addBoxDel.Enabled = true;
                    addBoxCount.Enabled = false;
                    addOutForm.Enabled = false;
                    addBoxCount.Visible = false;
                    labelCount.Visible = false;
                    break;
                case 2:
                    addBoxCount.Enabled = true;
                    addBoxCount.Visible = true;
                    labelCount.Visible = true;
                    addBoxText.Enabled = false;
                    addBoxX.Enabled = false;
                    addBoxY.Enabled = false;
                    addBoxDel.Enabled = true;
                    addOutForm.Enabled = false;
                    OpenInputForm.Enabled = false;
                    break;
            }
        }

        private void addOutForm_Click(object sender, EventArgs e)
        {
            try
            {
                var bmp = new Bitmap(webBrowser.Width, webBrowser.Height);
                Graphics.FromImage(bmp).CopyFromScreen(webBrowser.PointToScreen(Point.Empty).X, webBrowser.PointToScreen(Point.Empty).Y, 0, 0, 
                    new Size(webBrowser.Width, webBrowser.Height));
                var newForm = new Form2(bmp, AddCoord);
                newForm.Show();
            }
            catch { logTextBox.Text += @"Что-то пошло не так"; }
        }
        private void AddCoord(int x, int y)
        {
            addBoxX.Text = x.ToString();
            addBoxY.Text = y.ToString();
        }
        private void makeFileButton_Click(object sender, EventArgs e)
        {
            var newForm = new Form3(AddNameRoute);
            newForm.Show();
        }
        private async void AddNameRoute(string name, string route, string defLogin, string defPass)
        {
            var jm = new JsonMake("");
            if (defLogin == null && defPass == null)
                await jm.MakeJson(name, route);
            else
            {
                await jm.MakeJson(name, route, defLogin, defPass);
            }
            logTextBox.Text += jm.LastChangeResult;
            RefreshModelsList();
        }

        private void OpenInputForm_Click(object sender, EventArgs e)
        {
            var standartInput = new List<string>() { "admin", "password" };
            var newInput = new List<string>() { "_login", "_pass" };
            var newForm = new Form4(standartInput, newInput, AddInput);
            newForm.Show();
        }
        private void AddInput(string input)
        {
            addBoxText.Text = input;
        }

        private void RefreshModelsButton_Click(object sender, EventArgs e)
        {
            RefreshModelsList();
        }

        private void RefreshModelsList()
        {
            comboBoxModels.Items.Clear();
            var path = _path ?? Directory.GetCurrentDirectory();
            var f = Directory.GetFiles(path, "*.json");
            foreach (var p in f)
            {
                comboBoxModels.Items.Add($"{Path.GetFileName(p)}\n");
            }

            try
            {
                comboBoxModels.SelectedIndex = 0;
            }
            catch { logTextBox.Text += @"Что-то пошло не так"; }
        }
        private void OpenModelButton_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                _path = fbd.SelectedPath;
                pathLabel.Text = _path;
            }
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            var jm = new JsonMake(_path);
            jm.DeleteJson(GetModelName());
            logTextBox.Text += jm.LastChangeResult;
            RefreshModelsList();
        }


    }
}
