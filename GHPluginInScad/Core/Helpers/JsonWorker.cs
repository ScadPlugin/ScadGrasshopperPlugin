using System.IO;
using GHPlugin.Scad.Core.Entities;
using GHPlugin.Scad.Core.Helpers.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GHPlugin.Scad.Core.Helpers
{
    /// <summary>
    /// Класс экспорта в JSON файл 
    /// </summary>
    public class JsonWorker:IJsonWorker
    {
        #region Public
        public void SaveToJson(string path, MainScad scad)
        {

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(file, scad);
            }
        }

        public T DeserializeFile<T>(string path)
        {

            T desObjOut = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));

            return desObjOut;
        }

        #endregion


        #region Private



        #endregion
    }
}
