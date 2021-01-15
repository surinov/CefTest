using System;
using System.Windows.Forms;

namespace CefTest
{
    public partial class Form3 : Form
    {
        private readonly AddFileName _addFileName;
        public Form3(AddFileName afn)
        {
            InitializeComponent();
            _addFileName = afn;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                if (textBoxName.Text != null && textBoxRoute.Text != null && textBoxName.Text != "" &&
                    textBoxRoute.Text != "")
                {
                    _addFileName(textBoxName.Text, $"https://{textBoxRoute.Text}/",null,null);
                    Close();
                }
                else
                {
                    logLabel.Text = "Заполните поля";
                }
            }
            else
            {
                if (textBoxName.Text != null && textBoxRoute.Text != null && textBoxName.Text != "" &&
                    textBoxRoute.Text != "" && textBox1.Text != string.Empty && textBox2.Text != string.Empty)
                {
                    _addFileName(textBoxName.Text, $"https://{textBoxRoute.Text}/",textBox1.Text,textBox2.Text);
                    Close();
                }
                else
                {
                    logLabel.Text = "Заполните поля";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox1.Checked;
            textBox2.Enabled = checkBox1.Checked;
        }
    }
}
