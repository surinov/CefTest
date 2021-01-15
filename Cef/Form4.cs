using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CefTest
{
    public partial class Form4 : Form
    {
        private readonly AddInput _addInput;
        private readonly List<string> _standartInput;
        private readonly List<string> _newInput;
        public Form4(List<string> standartInput, List<string> newInput, AddInput an)
        {
            InitializeComponent();
            radioButton1.Checked = true;
            _standartInput = standartInput;
            _newInput = newInput;
            _addInput = an;
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (var s in _standartInput)
            {
                StandartComboBox.Items.Add(s);
            }
            foreach (var s in _newInput)
            {
                NewComboBox.Items.Add(s);
            }

            StandartComboBox.SelectedIndex = 0;
            NewComboBox.SelectedIndex = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                StandartComboBox.Enabled = false;
                NewComboBox.Enabled = false;
                textBox1.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                StandartComboBox.Enabled = false;
                NewComboBox.Enabled = true;
                textBox1.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                StandartComboBox.Enabled = true;
                NewComboBox.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StandartComboBox.Enabled)
            {
                _addInput(StandartComboBox.SelectedItem.ToString());
                Close();
            }
            if (NewComboBox.Enabled)
            {
                _addInput(NewComboBox.SelectedItem.ToString());
                Close();
            }
            if (textBox1.Enabled && textBox1.Text != string.Empty)
            {
                _addInput(textBox1.Text);
                Close();
            }
            else
            {
                label1.Text = "Заполните\n\t поле";
            }
        }

    }
}
