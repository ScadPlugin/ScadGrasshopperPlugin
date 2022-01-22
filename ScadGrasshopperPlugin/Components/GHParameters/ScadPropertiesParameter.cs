using Grasshopper.Kernel;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements;
using System;

namespace ScadGrasshopperPlugin.Components.GHParameters
{
    public class ScadPropertiesParameter : GH_Param<ScadPropertiesType>
    {
        public ScadPropertiesParameter() : base(
            "ScadProperties", 
            "S_Pr", 
            "Properties for SCAD elements",
            "SCAD",  
            "Primitive", GH_ParamAccess.item)
        {
        }

        public override Guid ComponentGuid { get => new Guid("42F7359C-535D-418B-A84E-ADBB92D955A2"); }
    }
}
