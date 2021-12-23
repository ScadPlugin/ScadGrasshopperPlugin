using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ScadGrasshopperPlugin.Helpers.Interfaces;
using ScadGrasshopperPlugin.ScadType;

namespace ScadGrasshopperPlugin.Helpers
{
    /// <summary>
    /// Класс экспорта в JSON файл 
    /// </summary>
    public class JsonWorker:IJsonWorker
    {
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
    }
}
