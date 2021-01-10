using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CefTest
{
    class JsonChange
    {
        internal Model Steps;
        public string LastChangeResult { get; set; }
        public JsonChange()
        {
            var js = new JsonSteps();
            Steps = js._steps;
        }
        public async Task AddStepLogin(string Do, int X, int Y, string Text, int Count, int Index, int Delay)
        {
            var login = Steps.steps.login;
            if (login.ElementAtOrDefault(Index) != null)
            {
                var t = login[Index];
                t.@do = Do;
                t.x = X;
                t.y = Y;
                t.count = Count;
                t.text = Text;
                t.del = Delay;
                LastChangeResult = $"Изменено {Index} шаг: do {t.@do}, x {t.x}, y {t.y}, text {t.text}, count {t.count}\n";
            }
            else
            {
                login.Add(new Login() { count = Count, del = Delay, @do = Do, text = Text, x = X, y = Y });
                LastChangeResult = $"Добавлен {login.Count} шаг: do {Do}, x {X}, y {Y}, text {Text}, count {Count}\n";
            }

            var output = await Task.Run(() => JsonConvert.SerializeObject(Steps, Formatting.Indented));
            File.WriteAllText("steps.json", output);
        }
        public async Task AddStepWifi(string Do, int X, int Y, string Text, int Count, int Index, int Delay)
        {
            var wifi = Steps.steps.wifi;
            if (wifi.ElementAtOrDefault(Index) != null)
            {
                var t = wifi[Index];
                t.@do = Do;
                t.x = X;
                t.y = Y;
                t.count = Count;
                t.text = Text;
                t.del = Delay;
                LastChangeResult = $"Изменено {Index} шаг: do {t.@do}, x {t.x}, y {t.y}, text {t.text}, count {t.count}\n";
            }
            else
            {
                wifi.Add(new Wifi() { count = Count, del = Delay, @do = Do, text = Text, x = X, y = Y });
                LastChangeResult = $"Добавлен {wifi.Count} шаг: do {Do}, x {X}, y {Y}, text {Text}, count {Count}\n";
            }

            var output = await Task.Run(() => JsonConvert.SerializeObject(Steps, Formatting.Indented));
            File.WriteAllText("steps.json", output);
        }
        public async Task AddStepApn(string Do, int X, int Y, string Text, int Count, int Index, int Delay)
        {
            var apn = Steps.steps.apn;
            if (apn.ElementAtOrDefault(Index) != null)
            {
                var t = apn[Index];
                t.@do = Do;
                t.x = X;
                t.y = Y;
                t.count = Count;
                t.text = Text;
                t.del = Delay;
                LastChangeResult = $"Изменено {Index} шаг: do {t.@do}, x {t.x}, y {t.y}, text {t.text}, count {t.count}\n";
            }
            else
            {
                apn.Add(new Apn() { count = Count, del = Delay, @do = Do, text = Text, x = X, y = Y });
                LastChangeResult = $"Добавлен {apn.Count} шаг: do {Do}, x {X}, y {Y}, text {Text}, count {Count}\n";
            }

            var output = await Task.Run(() => JsonConvert.SerializeObject(Steps, Formatting.Indented));
            File.WriteAllText("steps.json", output);
        }
        public async Task AddStepRemote(string Do, int X, int Y, string Text, int Count, int Index, int Delay)
        {
            var remote = Steps.steps.remote;
            if (remote.ElementAtOrDefault(Index) != null)
            {
                var t = remote[Index];
                t.@do = Do;
                t.x = X;
                t.y = Y;
                t.count = Count;
                t.text = Text;
                t.del = Delay;
                LastChangeResult = $"Изменено {Index} шаг: do {t.@do}, x {t.x}, y {t.y}, text {t.text}, count {t.count}\n";
            }
            else
            {
                remote.Add(new Remote() { count = Count, del = Delay, @do = Do, text = Text, x = X, y = Y });
                LastChangeResult = $"Добавлен {remote.Count} шаг: do {Do}, x {X}, y {Y}, text {Text}, count {Count}\n";
            }

            var output = await Task.Run(() => JsonConvert.SerializeObject(Steps, Formatting.Indented));
            File.WriteAllText("steps.json", output);
        }
    }
}
