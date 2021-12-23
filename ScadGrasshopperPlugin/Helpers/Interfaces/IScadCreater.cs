using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScadGrasshopperPlugin.Helpers
{
    public interface IScadCreator
    {

        /// <summary>
        /// Запуск перевода создания основного файла экспорта
        /// </summary>
        void Run();
    }
}
