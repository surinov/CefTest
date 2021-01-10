using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CefTest
{
    class Log
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int i);

        public delegate void LogHandler(string message);
        public event LogHandler Notify;
        public Log()
        {
            Main();
        }

        //[STAThread]
        private void Main()
        {
            var bw = new BackgroundWorker();
            bw.DoWork += Key_Log;
            bw.RunWorkerAsync();
        }
        private void Key_Log(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(100);
                for (var i = 0; i < 255; i++)
                {
                    var state = GetAsyncKeyState(i);
                    if (state == 0 || (Keys) i != Keys.X) continue;
                    Notify?.Invoke("was click XX");
                    //MessageBox.Show("Click X");
                }
            }
        }
    }
}
