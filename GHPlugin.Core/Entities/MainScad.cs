using System.Collections.Generic;
using System.Linq;
using GHPlugin.Core.Entities.Elements.Base;

namespace GHPlugin.Core.Entities
{
    /// <summary>
    /// Класс экспорта в SCAD
    /// </summary>
    public class MainScad
    {
        private readonly List<Element> _elements;
        private int _lastElemNumber;
        private int _lastNodeNumber;

        public MainScad()
        {
            _elements = new List<Element>();
        }


        #region Public

        /// <summary>
        /// Список элементов 
        /// </summary>
        public List<Element> ScadElements
        {
            get => _elements;
        }

        /// <summary>
        /// Последний номер элемента
        /// </summary>
        public int LastElemNumber
        {
            get => _lastElemNumber;
            set => _lastElemNumber = value;
        }

        /// <summary>
        /// Последний номер узлы
        /// </summary>
        public int LastNodeNumber
        {
            get => _lastNodeNumber;
            set => _lastNodeNumber = value;
        }

        #endregion

    }
}