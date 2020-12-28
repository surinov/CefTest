using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefTest
{
    public class Steps
    {
        private int _step;
        private readonly ChromiumWebBrowser _browser;
        private readonly string _login;
        private readonly string _password;
        private readonly string _setlogin;
        private readonly string _setpassword;

        public Steps(int step, ChromiumWebBrowser browser, string login, string password,string setLogin,string setPassword)
        {
            _step = step;
            _browser = browser;
            _login = login;
            _password = password;
            _setlogin = setLogin;
            _setpassword = setPassword;
        }

        public async void MakeLogIn(int step)
        {
            switch (step)
            {
                case 0:
                    await Task.Run(() => MouseClick(450, 310));
                    await Task.Run(() => KeyInput(_login));
                    break;
                case 1:
                    await Task.Run(() => MouseClick(450, 350));
                    await Task.Run(() => KeyInput(_password));
                    await Task.Run(() => MouseClick(500, 390));
                    break;
            }
        }
        public async void MakeStepWifi(int step)
        {
            _step = step;
            switch (step)
            {
                case 0:
                    await Task.Run(() => MouseClick(45, 270));
                    break;
                case 1:
                    await Task.Run(() => MouseClick(500, 220));
                    break;
                case 2:
                    await Task.Run(() => DelInput(12));
                    break;
                case 3:
                    await Task.Run(() => KeyInput(_setlogin));
                    await Task.Run(() => MouseClick(460, 510));
                    break;
                case 4:
                    await Task.Run(() => MouseClick(50, 320));
                    break;
                case 5:
                    await Task.Run(() => MouseClick(500, 350));
                    await Task.Run(() => DelInput(12));
                    await Task.Run(() => KeyInput(_setpassword));
                    break;
                case 6:
                    await Task.Run(() => MouseClick(725, 550));
                    break;
                case 7:
                    await Task.Run(() => MouseClick(500, 540));
                    break;
            }
        }
        public void MouseClick(int x, int y)
        {
            _browser.GetBrowser().GetHost().SendMouseClickEvent(x, y, MouseButtonType.Left, false, 1, CefEventFlags.None);
            System.Threading.Thread.Sleep(10);
            _browser.GetBrowser().GetHost().SendMouseClickEvent(x, y, MouseButtonType.Left, true, 1, CefEventFlags.None);
        }

        public void KeyInput(string keys)
        {
            var a = keys.ToCharArray();
            foreach (var t in a)
            {
                SendKeys.SendWait($"{t}");
                SendKeys.Flush();
            }
        }
        public void DelInput(int count)
        {
            for (var i = 0; i<count;i++)
            {
                SendKeys.SendWait("{BS}");
                SendKeys.Flush();
            }
        }
    }
}
