using System;
using Grasshopper.Kernel;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements;

namespace ScadGrasshopperPlugin.Components.GHParameters
{
    public class ScadLineParameter : GH_Param<ScadLineType>
    {
        public ScadLineParameter() : base("ScadLine", "S_L", "SCAD line element", "SCAD",
            "Primitive", GH_ParamAccess.item)
        {
        }

        public override Guid ComponentGuid
        {
            get => new Guid("B60A1C62-EC35-4FBE-ABBE-4170C88D65CB");
        }

    }
}