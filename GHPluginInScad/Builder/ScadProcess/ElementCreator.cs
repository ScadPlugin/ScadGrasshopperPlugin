using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Core.Entities;
using GHPlugin.Scad.Core.Entities.Elements;
using GHPlugin.Scad.Core.Entities.Elements.Base;
using GHPlugin.Scad.FEMFactory;
using ScadPluginLibrary.SCADClasses;
using ScadPluginLibrary.SCADClasses.EditorObj;
using ScadPluginLibrary.SCADClasses.EditorObj.Object;

namespace GHPlugin.Scad.Builder.ScadProcess
{
    /// <summary>
    /// Класс создания элементов в SCAD
    /// </summary>
    internal class ElementCreator
    {
        private readonly MainScad _scad;
        private readonly Engine _engine;
        private readonly Editor _editor;

        /// <summary>
        /// Создание элементов в SCAD
        /// </summary>
        /// <param name="scad">Класс SCAD из GH</param>
        /// <param name="engine">Объект SCAD</param>
        public ElementCreator(dynamic engine, MainScad scad )
        {
            _scad = scad;
            _engine = new Engine(engine);
            _editor = _engine.GetEditor();
        }

        #region Public

        /// <summary>
        /// Создание элементов
        /// </summary>

        public void CreateElementScheme()
        {
            _ = _editor.NodeAdd((uint) _scad.LastNodeNumber);
            _ = _editor.ElemAdd((uint) _scad.LastElemNumber);
            
            foreach (var element in _scad.ScadElements)
            {
                foreach (var node in element.ScadNodes)
                {
                    BuildNode(node);
                }

                BuildElement(element);
            }
        }

        #endregion


        #region Private

        /// <summary>
        /// Создание элемента
        /// </summary>

        private void BuildElement(Element element)
        {
            
            ElementFactory elementFactory = new ElementFactory();
            elementFactory.CreateFEMEelement(element, _editor);

        }

        /// <summary>
        /// Создание узла
        /// </summary>

        private void BuildNode(ScadNode nodeScad)
        {
            NodeEditor node = new NodeEditor(){x = nodeScad.X, y = nodeScad.Y, z = nodeScad.Z};
            _editor.NodeUpdate((uint)nodeScad.Number, node);
        }

        #endregion
    }
}
