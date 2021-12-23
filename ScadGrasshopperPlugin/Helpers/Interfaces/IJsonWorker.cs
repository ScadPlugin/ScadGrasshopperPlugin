using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScadGrasshopperPlugin.ScadType;

namespace ScadGrasshopperPlugin.Helpers.Interfaces
{
    /// <summary>
    /// фывфыв
    /// </summary>
    public interface IJsonWorker
    {
        /// <summary>
        /// Сохраниение в JSON файл
        /// </summary>
        /// <param name="path">Путь сохранения</param>
        /// <param name="scad">класс экспорта</param>
        void SaveToJson(string path, MainScad scad);
    }
}
