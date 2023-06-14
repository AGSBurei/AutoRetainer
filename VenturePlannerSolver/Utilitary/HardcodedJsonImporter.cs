using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VenturePlannerSolver.Internal.DefaultConfig;

namespace VenturePlannerSolver.Utilitary
{
    internal class HardcodedJsonImporter
    {
        private string defaultConfigPath = @"E:\\projet\\AutoRetainer\\VenturePlannerSolver\\ressources\\DefaultConfig.json";

        List<Retainer> retainerList = new List<Retainer>();
        User user;

        //string DefaultConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"\\XIVLauncher\\pluginConfigs\\AutoRetainer" + "DefaultConfig.json";
        public HardcodedJsonImporter()
        {
            JObject defaultConfigJson = JObject.Parse(File.ReadAllText(defaultConfigPath));
            if(defaultConfigJson != null )
            {
                try
                {
                    //Console.WriteLine("debug" + Environment.NewLine + defaultConfigJson);
                    Console.WriteLine(defaultConfigJson.SelectToken("OfflineData"));
                   //OfflineData = defaultConfigJson.SelectToken("OfflineData").ToArray();
                }
                catch(Exception ex) { 
                    Console.WriteLine(ex.ToString());
                }

            }
        }

        public IList<JToken> OfflineData { get => OfflineData; set => OfflineData = value; }
    }
}
