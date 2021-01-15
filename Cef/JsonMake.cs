using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace CefTest
{
    class JsonMake
    {
        internal Model model;
        public string _path;
        public string LastChangeResult { get; set; }

        public JsonMake(string path)
        {
            _path = path;
        }

        public async Task MakeJson(string name, string route,string defLogin,string defPass)
        {
            const string jsonString = "{'name':'exmpl name','defLogin':'admin','defPass':'admin','route':'exmpl route','steps':{'login':[],'wifi':[],'apn':[],'remote':[]}}";
            var restoredsteps = JsonConvert.DeserializeObject<Model>(jsonString);
            model = restoredsteps;

            model.name = name;
            model.route = route;
            model.defLogin = defLogin;
            model.defPass = defPass;
            LastChangeResult += $"Создан {model.name}\n";

            var output = await Task.Run(() => JsonConvert.SerializeObject(model, Formatting.Indented));
            File.WriteAllText($"{_path}{model.name}.json", output);
        }

        //Без логина и пароля по умолчанию
        public async Task MakeJson(string name, string route) 
        {
            const string jsonString = "{'name':'exmpl name','defLogin':'admin','defPass':'admin','route':'exmpl route','steps':{'login':[],'wifi':[],'apn':[],'remote':[]}}";
            var restoredsteps = JsonConvert.DeserializeObject<Model>(jsonString);
            model = restoredsteps;

            model.name = name;
            model.route = route;
            LastChangeResult += $"Создан {model.name}\n";

            var output = await Task.Run(() => JsonConvert.SerializeObject(model, Formatting.Indented));
            File.WriteAllText($"{_path}{model.name}.json", output);
        }

        public void DeleteJson(string name)
        {
            File.Delete($"{name}");
            LastChangeResult += $"Удалён {name}\n";
        }
    }
}
