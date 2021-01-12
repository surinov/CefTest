using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefTest
{
    public partial class Form2 : Form
    {
        public string Path { get; set; }
        public Bitmap B;
        private MyDelegate d;
        private int X;
        private int Y;
        public Form2(Bitmap b, MyDelegate sender)
        {
            B = b;
            d = sender;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = B;
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            var point = pictureBox1.PointToClient(Cursor.Position);
            X = point.X;
            Y = point.Y;
            await Task.Delay(10);
            label1.Text = @"X: " + X + ", Y: " + Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d(X,Y);
            Close();
        }
    }
}
