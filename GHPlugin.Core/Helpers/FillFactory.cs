using System.Collections.Generic;
using GHPlugin.Core.Entities;
using GHPlugin.Core.Entities.Elements.Base;

namespace GHPlugin.Core.Helpers
{
    /// <summary>
    /// Фабрика по заполнению класса для инпорта
    /// </summary>
    public class FillFactory
    {
        private MainScad _mainScad;

        public FillFactory(List<Element> scadElement)
        {
            _mainScad = new MainScad();

            AddElements(scadElement);
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
        /// <param name="scadElements">Список элементов приходящих с GH</param>
        private void AddElements(List<Element>  scadElements)
        {
            if (scadElements == null || scadElements.Count == 0)
            {
                return;
            }

            _mainScad.ScadElements.AddRange(scadElements);
          
        }

        #endregion

    }
}
