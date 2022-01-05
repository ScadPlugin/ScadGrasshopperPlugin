using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Core.Entities;
using GHPlugin.Core.Helpers;
using GHPlugin.Scad.Builder.Interfaces;
using GHPlugin.Scad.Builder.ScadProcess;

namespace GHPlugin.Scad.Builder
{
    public class ScadBuilder : IScadBuilder
    {
        private const string PATH = @"C:\ProgramData\SCAD Soft\Plugins\PreProcessor\gJson.json";
        private dynamic _engine;
        private MainScad _scad;
        private ElementCreator _elementCreator = new ElementCreator();

        public ScadBuilder( dynamic engine)
        {
            
            _engine = engine;
            this.Reset();
        }


        #region Public

        public void Reset()
        {
            this._elementCreator = new ElementCreator();
        }

        public void BuildElements()
        {

        }

        public void LoadScadSetting()
        {
            JsonWorker jsonWorker = new JsonWorker();
            _scad = jsonWorker.DeserializeFile<MainScad>(PATH);
        }
        #endregion

        #region Private

        

        #endregion
    }
}
