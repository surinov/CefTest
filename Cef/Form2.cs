using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefTest
{
    public partial class Form2 : Form
    {
        private readonly Bitmap _b;
        private readonly SetCoordinates _setCoor;
        private int _x;
        private int _y;
        public Form2(Bitmap bmp, SetCoordinates sender)
        {
            _b = bmp;
            _setCoor = sender;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = _b;
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            var point = pictureBox1.PointToClient(Cursor.Position);
            _x = point.X;
            _y = point.Y;
            await Task.Delay(10);
            label1.Text = @"X: " + _x + ", Y: " + _y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _setCoor(_x, _y);
            Close();
        }
    }
}
