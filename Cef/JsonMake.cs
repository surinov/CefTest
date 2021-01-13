using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public async Task MakeJson(string name,string route)
        {
            const string jsonString = "{'name':'exmpl name','route':'exmpl route','steps':{'login':[],'wifi':[],'apn':[],'remote':[]}}";
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
            File.Delete($"{_path}{name}");
        }
    }
}
