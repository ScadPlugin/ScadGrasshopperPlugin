using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Core.Entities.Elements.Base;
using GHPlugin.Scad.FEMFactory.Creator.Base;
using GHPlugin.Scad.FEMFactory.Elements;
using GHPlugin.Scad.FEMFactory.Elements.Interfaces;
using ScadPluginLibrary.SCADClasses.EditorObj;

namespace GHPlugin.Scad.FEMFactory.Creator
{
    /// <summary>
    /// Создатель 2х узлового элемента
    /// </summary>
    internal class BeamFEMCreator: BaseFEMCreator
    {
        private readonly Editor _editor;
        private readonly Element _scadElem;

        public BeamFEMCreator(Editor editor, Element scadElem)
        {
            _editor = editor;
            _scadElem = scadElem;
        }

        public override IFEMElement FactoryMethod()
        {
            return new BeamFEMElement(_editor, _scadElem);
        }


    }
}
