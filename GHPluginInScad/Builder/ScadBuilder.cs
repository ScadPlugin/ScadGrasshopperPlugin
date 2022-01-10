using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Builder.Interfaces;
using GHPlugin.Scad.Builder.ScadProcess;
using GHPlugin.Scad.Core.Entities;

namespace GHPlugin.Scad.Builder
{
    internal class ScadBuilder : IScadBuilder
    {
        
        private dynamic _engine;
        private MainScad _scad;
        private ElementCreator _elementCreator;

        public ScadBuilder( dynamic engine, MainScad scad)
        {
            _engine = engine;
            _scad = scad;
            Reset();
        }


        #region Public

        public void Reset()
        {
            _elementCreator = new ElementCreator(_engine, _scad);
        }

        public void BuildElements()
        {
          _elementCreator.CreateElementScheme();

        }

        #endregion


        #region Private



        #endregion
    }
}
