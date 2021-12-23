using ScadPluginLibrary.Helpers;
using ScadPluginLibrary.SCADClasses;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GHPluginInScad
{
    [ProgId("PluginName")]
    //Create a new GUID
    [Guid("00000000-0000-0000-0000-000000000000")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class ScadPluginClass : IScadPlugin
    {

        public void Run(dynamic engine)
        {
            try
            {
                Engine engineSCAD = new Engine(engine);
                //Editor editor = engineSCAD.GetEditor();
                //Model model = engineSCAD.GetModel();
                //Result result = engineSCAD.GetResult();

                //TO DO

                ScadDebug.MessageShow("Hello SCAD");
            }
            finally
            {

                Marshal.ReleaseComObject(engine);

            }

        }

    }


    //Create a new GUID
    [Guid("00000000-0000-0000-0000-000000000000")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisible(true)]
    public interface IScadPlugin
    {
        [DispId(1)]
        void Run(dynamic engine);

    }

}
