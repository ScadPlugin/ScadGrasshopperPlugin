using System.Collections.Generic;
using ScadGrasshopperPlugin.ScadType;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ScadGrasshopperPlugin.Helpers
{
    /// <summary>
    /// Класс запуска экспорта
    /// </summary>
    public class ScadCreator:IScadCreator
    {
        private MainScad _scad;

        public ScadCreator(MainScad scad)
        {
            _scad = scad;
        }


        #region Public

        public void Run()
        {
            string path = @"C:\ProgramData\SCAD Soft\Plugins\PreProcessor\gJson.json";
            JsonWorker json = new JsonWorker();

            json.SaveToJson(path, _scad);
        }

        #endregion


        #region Private

        /// <summary>
        /// Перенумерация элементов
        /// </summary>
        private void RenumberElements()
        {

        }

        #endregion

    }
}
