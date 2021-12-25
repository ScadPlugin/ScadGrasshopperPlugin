using GHPlugin.Core.Entities;

namespace GHPlugin.Core.Helpers.Interfaces
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

        /// <summary>
        /// Десиарилизация JSON из файла
        /// </summary>
        /// <param name="path"></param>
        T DeserializeFile<T>(string path, T deserializeType);

    }
}
