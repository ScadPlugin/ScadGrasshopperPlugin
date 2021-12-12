using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace ScadGrasshopperPlugin
{
    public class ScadGrasshopperPluginInfo : GH_AssemblyInfo
    {
        public override string Name => "ScadGrasshopperPlugin";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("87D287FC-1EE0-41C1-8EBC-80C029683324");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}