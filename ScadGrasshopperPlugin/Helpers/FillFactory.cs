using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScadGrasshopperPlugin.GHDataTypes.Elements;
using ScadGrasshopperPlugin.ScadType;

namespace ScadGrasshopperPlugin.Helpers
{
    /// <summary>
    /// Фабрика по заполнению класса для инпорта
    /// </summary>
    public class FillFactory
    {
        private MainScad _mainScad;

        public FillFactory(List<ScadLineType> scadLineList)
        {
            _mainScad = new MainScad();

            AddElements(scadLineList);
        }


        #region Public

        /// <summary>
        /// Возвращение, объекта для инпорта
        /// </summary>
        public MainScad GetMainScad { get => _mainScad; }

        #endregion


        #region Private

        /// <summary>
        /// Добавление элементов в главный класс
        /// </summary>
        /// <param name="scadLineList">Список элементов приходящих с GH</param>
        private void AddElements(List<ScadLineType> scadLineList)
        {
            if (scadLineList == null || scadLineList.Count == 0)
            {
                return;
            }

            foreach (var scadLineType in scadLineList)
            {
                _mainScad.ScadElements.Add(scadLineType.Value);
            }
        }

        #endregion

    }
}
