using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Builder.Interfaces;

namespace GHPlugin.Scad.Builder
{
    internal class ScadBuilderDirector
    {
        private IScadBuilder _builder;
        public IScadBuilder ScadBuilder
        {
            set { _builder = value; }
        }

        public void BuildOnlyElements()
        {
            _builder.BuildElements();
        }
    }
}
