using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json;

namespace CefTest
{
    public class JsonSteps
    {
        private string _name;
        private string _route;
        private int _delay;
        public Model _steps;
        public string _file;
        private readonly ChromiumWebBrowser _browser;
        private readonly string _login;
        private readonly string _password;
        private readonly string _setlogin;
        private readonly string _setpassword;

        public JsonSteps(ChromiumWebBrowser browser, string login, string password, string setLogin, string setPassword,string file)
        {
            _delay = 1000;
            _browser = browser;
            _login = login;
            _password = password;
            _setlogin = setLogin;
            _setpassword = setPassword;
            _file = file;
            ParseJson();
        }

        public JsonSteps(string file)
        {
            _delay = 1000;
            _file = file;
            ParseJson();
        }

        public string GetName() { return _name; }
        public string GetRoute() { return _route; }

        public void SetDelay(int delay) { _delay = delay; }
        private void ParseJson()
        {
            var jsonString = System.IO.File.ReadAllText(_file);
            var restoredsteps = JsonConvert.DeserializeObject<Model>(jsonString);
            _steps = restoredsteps;
            _name = restoredsteps.name;
            _route = restoredsteps.route;
        }

        public async Task MakeLogin(bool onJsonDelay)
        {
            foreach (var t in _steps.steps.login)
            {
                var delay = onJsonDelay ? t.del : _delay;
                switch (t.@do)
                {
                    case "click":
                        await Task.Run(() => MakeClick(t.x, t.y));
                        await Task.Delay(delay);
                        break;
                    case "input":
                        var text = t.text;
                        if (text == "_login")
                            text = _login;

                        if (text == "_pass")
                            text = _password;
                        await Task.Run(() => MakeInput(text));
                        await Task.Delay(delay);
                        break;
                }
            }
        }

        public async Task MakeWifi(bool onJsonDelay)
        {
            foreach (var t in _steps.steps.wifi)
            {
                var delay = onJsonDelay ? t.del : _delay;
                switch (t.@do)
                {
                    case "click":
                        await Task.Run(() => MakeClick(t.x, t.y));
                        await Task.Delay(delay);
                        break;
                    case "input":
                        var text = t.text;
                        if (text == "_setlogin")
                            text = _setlogin;

                        if (text == "_setpass")
                            text = _setpassword;
                        await Task.Run(() => MakeInput(text));
                        await Task.Delay(delay);
                        break;
                    case "delete":
                        await Task.Run(() => MakeDelete(t.count));
                        await Task.Delay(delay);
                        break;
                }
            }
        }

        public async Task MakeApn(bool onJsonDelay)
        {
            foreach (var t in _steps.steps.apn)
            {
                var delay = onJsonDelay ? t.del : _delay;
                switch (t.@do)
                {
                    case "click":
                        await Task.Run(() => MakeClick(t.x, t.y));
                        await Task.Delay(_delay);
                        break;
                    case "input":
                        var text = t.text;
                        if (text == "_login")
                            text = _setlogin;

                        if (text == "_pass")
                            text = _setpassword;
                        await Task.Run(() => MakeInput(text));
                        await Task.Delay(delay);
                        break;
                    case "delete":
                        await Task.Run(() => MakeDelete(t.count));
                        await Task.Delay(delay);
                        break;
                }
            }
        }
        public async Task MakeRemote(bool onJsonDelay)
        {
            foreach (var t in _steps.steps.remote)
            {
                var delay = onJsonDelay ? t.del : _delay;
                switch (t.@do)
                {
                    case "click":
                        await Task.Run(() => MakeClick(t.x, t.y));
                        await Task.Delay(_delay);
                        break;
                    case "input":
                        var text = t.text;
                        if (text == "_login")
                            text = _setlogin;

                        if (text == "_pass")
                            text = _setpassword;
                        await Task.Run(() => MakeInput(text));
                        await Task.Delay(delay);
                        break;
                    case "delete":
                        await Task.Run(() => MakeDelete(t.count));
                        await Task.Delay(delay);
                        break;
                }
            }
        }

        public void MakeClick(int x, int y)
        {
            _browser.GetBrowser().GetHost().SendMouseClickEvent(x, y, MouseButtonType.Left, false, 1, CefEventFlags.None);
            System.Threading.Thread.Sleep(10);
            _browser.GetBrowser().GetHost().SendMouseClickEvent(x, y, MouseButtonType.Left, true, 1, CefEventFlags.None);
        }
        public void MakeInput(string keys)
        {
            var a = keys.ToCharArray();
            foreach (var t in a)
            {
                SendKeys.SendWait($"{t}");
                SendKeys.Flush();
            }
        }
        public void MakeDelete(int? cout)
        {
            for (var i = 0; i < cout; i++)
            {
                SendKeys.SendWait("{BS}");
                SendKeys.Flush();
            }
        }
    }
}
