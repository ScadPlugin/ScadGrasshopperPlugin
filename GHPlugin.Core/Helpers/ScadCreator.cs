using System.Linq;
using GHPlugin.Core.Entities;
using GHPlugin.Core.Helpers.Interfaces;

namespace GHPlugin.Core.Helpers
{

    /// <summary>
    /// Класс запуска экспорта
    /// </summary>
    public class ScadCreator:IScadCreator
    {
        private MainScad _scad;
        private const string PATH = @"C:\ProgramData\SCAD Soft\Plugins\PreProcessor\gJson.json";

        public ScadCreator(MainScad scad)
        {
            _scad = scad;
        }


        #region Public

        public void Run()
        {
            Renumber.RenumberElements(ref _scad);
            
            JsonWorker json = new JsonWorker();

            json.SaveToJson(PATH, _scad);
        }

        #endregion


        #region Private

     

        #endregion

    }
}
