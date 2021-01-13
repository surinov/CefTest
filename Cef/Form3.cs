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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != null && textBoxRoute.Text != null && textBoxName.Text != "" && textBoxRoute.Text != "")
            {
                _addFileName(textBoxName.Text, $"https://{textBoxRoute.Text}/");
                Close();
            }
            else
            {
                logLabel.Text = "Заполните поля";
            }
        }
    }
}
