using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.FEMFactory.Elements.Interfaces;
using ScadPluginLibrary.SCADClasses.EditorObj;

namespace GHPlugin.Scad.FEMFactory.Creator.Base
{
    internal abstract class BaseFEMCreator
    {
        public abstract IFEMElement FactoryMethod();

        public void CreateElement()
        {
            var femElement = FactoryMethod();
            femElement.Create();
        }
    }
}