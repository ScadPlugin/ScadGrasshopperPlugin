using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Core.Entities;
using GHPlugin.Scad.Builder.Interfaces;
using GHPlugin.Scad.Builder.ScadProcess;

namespace GHPlugin.Scad.Builder
{
    public class ScadBuilder : IScadBuilder
    {
        private dynamic _engine;
        private MainScad _scad;
        private ElementCreator _elementCreator = new ElementCreator();

        public ScadBuilder(MainScad scad, dynamic engine)
        {
            _scad = scad;
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

        #endregion

        #region Private

        

        #endregion
    }
}
