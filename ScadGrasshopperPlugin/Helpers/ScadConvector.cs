using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;
using ScadGrasshopperPlugin.GHDataTypes.Elements;
using ScadGrasshopperPlugin.ScadType;
using ScadGrasshopperPlugin.ScadType.Interface;

namespace ScadGrasshopperPlugin.Helpers
{
    /// <summary>
    /// Класс конвектор из GH классов в SCAD классы
    /// </summary>
    public static class ScadConvector
    {
        #region Public

        /// <summary>
        /// Конвертация линий Rhino в 2х узловые элементы SCAD
        /// </summary>
        /// <param name="src">Rhino src</param>
        /// <param name="scadLineLine">Scad line</param>
        /// <returns>True - сонвертация успешна</returns>
        public static bool ToScadElement(object src, ScadLineElement scadLineLine)
        {
            if (src == null)
            {
                return false;
            }

            bool isLine = src is Line;
            if (!isLine)
            {
                return false;
            }

            scadLineLine.ScadNodes = CreateScadNodeLine((Line) src);
            scadLineLine.StartNode = scadLineLine.ScadNodes[0];
            scadLineLine.EndNode = scadLineLine.ScadNodes[1];
            return true;
        }

        #endregion


        #region Private

        /// <summary>
        /// Создание списка узлов из линии Rhino
        /// </summary>
        /// <param name="line">Rhino src</param>
        /// <returns>Список узлов SCAD</returns>
        private static List<ScadNode> CreateScadNodeLine(Line line)
        {
            List<ScadNode> nodes = new List<ScadNode>();

            ScadNode nodeStart = new ScadNode()
            {
                X = line.FromX,
                Y = line.FromY,
                Z = line.FromZ
            };
            nodes.Add(nodeStart);

            ScadNode nodeEnd = new ScadNode()
            {
                X = line.ToX,
                Y = line.ToY,
                Z = line.ToZ
            };
            nodes.Add(nodeEnd);

            return nodes;
        }

        #endregion
    }
}