using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json;

namespace CefTest
{
    public class Model
    {
        public string name { get; set; }
        public Steps steps { get; set; }
    }

    public class Login
    {
        public string @do { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string text { get; set; }
    }

    public class Wifi
    {
        public string @do { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int? count { get; set; }
        public string text { get; set; }
    }

    public class Apn
    {
        public string @do { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int? count { get; set; }
        public string text { get; set; }
    }

    public class Steps
    {
        public List<Login> login { get; set; }
        public List<Wifi> wifi { get; set; }
        public List<Apn> apn { get; set; }
    }

    public class JsonSteps
    {
        private string _name;
        private int _delay;
        private Model _steps;
        private readonly ChromiumWebBrowser _browser;
        private readonly string _login;
        private readonly string _password;
        private readonly string _setlogin;
        private readonly string _setpassword;

        public JsonSteps(ChromiumWebBrowser browser, string login, string password, string setLogin, string setPassword)
        {
            ParseJson();
            _delay = 1000;
            _browser = browser;
            _login = login;
            _password = password;
            _setlogin = setLogin;
            _setpassword = setPassword;
        }

        public string GetName() { return _name; }

        public void SetDelay(int delay) { _delay = delay; }
        private void ParseJson()
        {
            var jsonString = File.ReadAllText("steps.json");
            var restoredsteps = JsonConvert.DeserializeObject<Model>(jsonString);
            _steps = restoredsteps;
            _name = restoredsteps.name;
        }

        public async Task MakeLogin()
        {
            for (var i = 0; i < _steps.steps.login.Count; i++)
            {
                switch (_steps.steps.login[i].@do)
                {
                    case "click":
                        await Task.Run(() => MakeClick(_steps.steps.login[i].x, _steps.steps.login[i].y));
                        await Task.Delay(_delay);
                        break;
                    case "input":
                        var text = _steps.steps.login[i].text;
                        if (text == "_login")
                        {
                            text = _login;
                        }

                        if (text == "_pass")
                        {
                            text = _password;
                        }
                        await Task.Run(() => MakeInput(text));
                        await Task.Delay(_delay);
                        break;
                }
            }
        }

        public async Task MakeWifi()
        {
            for (var i = 0; i < _steps.steps.wifi.Count; i++)
            {
                switch (_steps.steps.wifi[i].@do)
                {
                    case "click":
                        await Task.Run(() => MakeClick(_steps.steps.wifi[i].x, _steps.steps.wifi[i].y));
                        await Task.Delay(_delay);
                        break;
                    case "input":
                        var text = _steps.steps.wifi[i].text;
                        if (text == "_setlogin")
                        {
                            text = _setlogin;
                        }

                        if (text == "_setpass")
                        {
                            text = _setpassword;
                        }
                        await Task.Run(() => MakeInput(text));
                        await Task.Delay(_delay);
                        break;
                    case "delete":
                        await Task.Run(() => MakeDelete(_steps.steps.wifi[i].count));
                        await Task.Delay(_delay);
                        break;
                }
            }
        }

        public async Task MakeApn()
        {
            for (var i = 0; i < _steps.steps.apn.Count; i++)
            {
                switch (_steps.steps.apn[i].@do)
                {
                    case "click":
                        await Task.Run(() => MakeClick(_steps.steps.apn[i].x, _steps.steps.apn[i].y));
                        await Task.Delay(_delay);
                        break;
                    case "input":
                        var text = _steps.steps.apn[i].text;
                        if (text == "_login")
                        {
                            text = _setlogin;
                        }

                        if (text == "_pass")
                        {
                            text = _setpassword;
                        }
                        await Task.Run(() => MakeInput(text));
                        await Task.Delay(_delay);
                        break;
                    case "delete":
                        await Task.Run(() => MakeDelete(_steps.steps.apn[i].count));
                        await Task.Delay(_delay);
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
