using System.Runtime.InteropServices;
using GHPlugin.Scad.Builder;
using GHPlugin.Scad.Core.Entities;
using GHPlugin.Scad.Core.Helpers;
using ScadPluginLibrary.Helpers;
using ScadPluginLibrary.SCADClasses;

namespace GHPlugin.Scad
{
    [ProgId("ScadGHPlugin")]
    //Create a new GUID
    [Guid("2C1E51AD-0349-4689-84A7-FF2C93F18D01")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class ScadPluginClass : IScadPlugin
    {

        public void Run(dynamic engine)
        {
            try
            {

                Engine engineSCAD = new Engine(engine);
       
                //TO DO
                JsonWorker jsonWorker = new JsonWorker();

                MainScad scad =
                    jsonWorker.DeserializeFile<MainScad>(@"C:\ProgramData\SCAD Soft\Plugins\PreProcessor\gJson.json");
                
                var director = new ScadBuilderDirector();
                var builder = new ScadBuilder(engine, scad);

                director.ScadBuilder = builder;
                director.BuildOnlyElements();
                
            }
            finally
            {

                Marshal.ReleaseComObject(engine);

            }

        }

    }


    //Create a new GUID
    [Guid("476CC1DA-C052-4B59-B110-DFD6F402F4EA")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisible(true)]
    public interface IScadPlugin
    {
        [DispId(1)]
        void Run(dynamic engine);

    }

}
