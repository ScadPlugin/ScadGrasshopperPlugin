using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Core.Entities.Elements.Base;
using GHPlugin.Scad.FEMFactory.Elements.Interfaces;
using ScadPluginLibrary.SCADClasses.EditorObj;
using ScadPluginLibrary.SCADClasses.EditorObj.Object;

namespace GHPlugin.Scad.FEMFactory.Elements
{
    /// <summary>
    /// 2х узловой КЭ
    /// </summary>
    internal class BeamFEMElement : IFEMElement
    {
        private readonly Editor _editor;
        private readonly Element _scadElem; 

        public BeamFEMElement(Editor editor, Element scadElem)
        {
            _editor = editor;
            _scadElem = scadElem;
        }

        #region Public

        public void Create()
        {
            ElemEditor elem = new ElemEditor(){
                TypeElem = 5,
                ListNode = new object[]
                {
                    _scadElem.ScadNodes[0].Number,
                    _scadElem.ScadNodes[1].Number
                }

            };
            _editor.ElemUpdate((uint) _scadElem.Number, elem);
        }

        #endregion

    }
}