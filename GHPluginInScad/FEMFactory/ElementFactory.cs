using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Core.Entities.Elements.Base;
using GHPlugin.Scad.FEMFactory.Creator;
using ScadPluginLibrary.SCADClasses.EditorObj;

namespace GHPlugin.Scad.FEMFactory
{
    internal class ElementFactory
    {
        #region Public

        public void CreateFEMEelement(Element element, Editor editor)
        {
            int nodeCount = element.ScadNodes.Count;

            switch (nodeCount)
            {
                case 1:
                    throw new NotImplementedException();
                    break;
                case 2:
                    BeamFEMCreator beam = new BeamFEMCreator(editor, element);
                    beam.CreateElement();
                    break;
                case 3:
                    throw new NotImplementedException();
                    break;
                case 4:
                    throw new NotImplementedException();
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }


        }

        #endregion


        #region Private

        

        #endregion
    }
}
