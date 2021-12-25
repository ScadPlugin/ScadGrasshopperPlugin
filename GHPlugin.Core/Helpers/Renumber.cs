using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Core.Entities;

namespace GHPlugin.Core.Helpers
{
    /// <summary>
    /// Класс перенумирации элементов в экспортируемом файле
    /// </summary>
    public static class Renumber
    {

        #region Public

        /// <summary>
        /// Перенумерация элементов и узлов
        /// </summary>
        public static void RenumberElements(ref MainScad scad)
        {
            int elemNumberCounter = 1;
            int nodeNumberCounter = 1;

            foreach (var element in scad.ScadElements)
            {
                element.Number = elemNumberCounter++;

                foreach (var node in element.ScadNodes)
                {
                    node.Number = nodeNumberCounter++;
                }
            }
            SetLastNumbers(ref scad);

        }
        
        #endregion


        #region Private

        /// <summary>
        /// Заполняет номера максимальные номера элементов и узлов перечеслением всего массива данных
        /// </summary>
        private static void SetLastNumbersEnumeration(ref MainScad scad)
        {

            scad.LastElemNumber = scad.ScadElements.Max(e => e.Number);
            scad.LastNodeNumber = scad.ScadElements.Max(e => e.ScadNodes.Max(n => n.Number));
        }

        /// <summary>
        /// Заполняет номера максимальные номера элементов и узлов исходя из последнего элемента в списке
        /// </summary>
        private static void SetLastNumbers(ref MainScad scad)
        {
            int lastIndex = scad.ScadElements.Count - 1;
            scad.LastElemNumber = scad.ScadElements[lastIndex].Number;

            int lastNodeIndex = scad.ScadElements[lastIndex].ScadNodes.Count - 1;
            scad.LastNodeNumber = scad.ScadElements[lastIndex].ScadNodes[lastNodeIndex].Number;
        }

        #endregion

    }
}
