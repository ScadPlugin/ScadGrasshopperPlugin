using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScadGrasshopperPlugin.ScadType.Base;

namespace ScadGrasshopperPlugin.ScadType
{
    /// <summary>
    /// Класс экспорта в SCAD
    /// </summary>
    public class MainScad
    {
        private readonly List<Element> _elements;
        public MainScad()
        {
            _elements = new List<Element>();
        }
        /// <summary>
        /// Список элементов 
        /// </summary>
        public List<Element> ScadElements { get => _elements; }
    }
}
