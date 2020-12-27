using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefTest
{
    public class Steps
    {
        private int _step;
        private readonly ChromiumWebBrowser _browser;
        private readonly Label _stepLabel;
        private readonly Label _posLabel;
        private readonly string _login;
        private readonly string _password;

        public Steps(int step, ChromiumWebBrowser browser, Label stepLabel, Label posLabel, string login, string password)
        {
            _step = step;
            _browser = browser;
            _stepLabel = stepLabel;
            _posLabel = posLabel;
            _login = login;
            _password = password;
        }
        public void MakeStep(int step)
        {
            switch (step)
            {
                case 0:
                    _stepLabel.Text = $@"Step {step} done";
                    MouseClick(450, 310);
                    _browser.Focus();
                    string s = "admin";
                    char[] a = s.ToCharArray();
                    for (int i = 0; i < a.Length; i++)
                    {
                        SendKeys.Send($"{a[i]}");
                        System.Threading.Thread.Sleep(10);
                    }
                    //         RunScript($@"
                    // document.getElementById('userName').value = '{_login}';");
                    //         System.Threading.Thread.Sleep(10);
                    RunScript($@"
            document.getElementById('pc-login-password').value = '{_password}';
            document.getElementById('pc-login-btn').click();");
                    
                    _step = 1;
                    break;
                case 1:
                    _stepLabel.Text = $@"Step {step} done";
                    RunScript($@"document.getElementById('advanced').click();");
                    _step = 2;
                    break;
                case 2:
                    _stepLabel.Text = $@"Step {step} done";
                    MouseClick(50, 300);
                    _step = 3;
                    break;
                case 3:
                    _stepLabel.Text = $@"Step {step} done";
                    MouseClick(50, 170);
                    _step = 4;
                    break;
                case 4:
                    _stepLabel.Text = $@"Step {_step} done";
                    MouseClick(730, 220);
                    _browser.Focus();
                    KeyInput("Hello");
                    // for (int i = 0; i < 9; i++)
                    // {
                    //     SendKeys.Send("{BS}");
                    //     System.Threading.Thread.Sleep(10);
                    // }
                    _step = 5;
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
            char[] input = keys.ToCharArray();
            var i = 0;
            while (i<input.Length)
            {
                System.Threading.Thread.Sleep(100);
                SendKeys.Send($"{input[i].ToString()}");
                i++;
            }
        }
        public void RunScript(string script)
        {
            _browser.ExecuteScriptAsyncWhenPageLoaded(script);
        }
    }
}
