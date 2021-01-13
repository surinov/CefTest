using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;

namespace CefTest
{
    public delegate void SetCoordinates(int x,int y);
    public delegate void AddFileName(string name, string route);
    public partial class Form1 : Form
    {
        public int AddIndex { get; set; } = 0;
        private string _path { get; set; } = Directory.GetCurrentDirectory();
        private string _file = "mr6400v2.json";
        public Form1()
        {
            InitializeComponent();
            RefreshModelsList();
            /*0-mr6400v2 1-mr6400v4 2-lte3202 3-mr600*/
            comboBoxModels.SelectedIndex = 0;
            comboBoxUrls.SelectedIndex = 2;
            comboBoxAdd.SelectedIndex = 3;
            comboBoxDo.SelectedIndex = 0;
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
                logTextBox.Text = model;
                return model;
            }
            catch
            {
                logTextBox.Text = "JSON не найден";
                return null;
            }
        }

        private async void runButton_Click(object sender, EventArgs e)
        {
            if (!TextboxIsNull()) {
                try
                {
                    if (GetModelName() != null)
                    {
                        _file = GetModelName();
                        logTextBox.Text = GetModelName();
                        await MakeStep();
                    }
                }
                catch { // ignored
                }
            }
        }

        public async Task MakeStep()
        {
            var js = new JsonSteps(webBrowser,loginDefBox.Text, passwordDefBox.Text, loginBox.Text, passwordBox.Text,_file);
            logTextBox.Text = $@"Log: {js.GetName()} {js.GetRoute()}";
            js.SetDelay(500);
            webBrowser.Focus();
            if (checkAuth.Checked)
            {
                await js.MakeLogin(false);
                logTextBox.Text += "\n- Login Есть.";
            }

            if (checkWifi.Checked)
            {
                await js.MakeWifi(false);
                logTextBox.Text += "\n- WiFi Есть.";
            }

            if (checkAPN.Checked)
            {
                await js.MakeApn(false);
                logTextBox.Text += "\n- APN Есть.";
            }
            if (checkRemote.Checked)
            {
                await js.MakeRemote(false);
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
                    break;
                case 1:
                    addBoxText.Enabled = true;
                    addBoxX.Enabled = false;
                    addBoxY.Enabled = false;
                    addBoxDel.Enabled = true;
                    addBoxCount.Enabled = false;
                    addOutForm.Enabled = false;
                    break;
                case 2:
                    addBoxCount.Enabled = true;
                    addBoxText.Enabled = false;
                    addBoxX.Enabled = false;
                    addBoxY.Enabled = false;
                    addBoxDel.Enabled = true;
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
                var newForm = new Form2(bmp, AddCoord);
                newForm.Show();
            }
            catch
            { // ignored
            }
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
        private async void AddNameRoute(string name,string route)
        {
            var jm = new JsonMake("");
            await jm.MakeJson(name, route);
            logTextBox.Text += jm.LastChangeResult;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var jc = new JsonChange(GetModelName());
            await jc.AddStepWifi("input", 0, 0, "hello", 14, 5, 300);
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
            catch {//ignored
            }
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
    }
}
