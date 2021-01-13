using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CefTest
{
    class JsonMake
    {
        internal Model model;
        public string _file;
        public string LastChangeResult { get; set; }

        public JsonMake(string file)
        {
            _file = file;
        }

        public async Task MakeJson(string name,string route)
        {
            const string jsonString = "{'name': 'exmpl name','route': 'exmpl route', 'steps': { 'login': [], 'wifi': [], 'apn': [], 'remote': [] } }";
            var restoredsteps = JsonConvert.DeserializeObject<Model>(jsonString);
            model = restoredsteps;

            model.name = name;
            model.route = route;
            //model.steps.login.Clear();
            //model.steps.wifi.Clear();
            //model.steps.apn.Clear();
            //model.steps.remote.Clear();
            LastChangeResult += $"Создан {model.name}\n";
            

            var output = await Task.Run(() => JsonConvert.SerializeObject(model, Formatting.Indented));
            File.WriteAllText("test.json", output);
        }
    }
}
