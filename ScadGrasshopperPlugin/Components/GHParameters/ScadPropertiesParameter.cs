using Grasshopper.Kernel;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements;
using System;
using System.Collections.Generic;
using GHPlugin.Scad.Core.Entities.Elements;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.ElementProperties;

namespace ScadGrasshopperPlugin.Components.GHParameters
{
    public class ScadPropertiesParameter : GH_PersistentParam<ScadPropertiesType>
    {
        
        public ScadPropertiesParameter() : base(
            "ScadProperties", 
            "S_Pr", 
            "Properties for SCAD elements",
            "SCAD",  
            "Primitive")
        {
            SetPersistentData(new ScadPropertiesType());
        }

        public override Guid ComponentGuid { get => new Guid("42F7359C-535D-418B-A84E-ADBB92D955A2"); }


        protected override GH_GetterResult Prompt_Singular(ref ScadPropertiesType value)
        {
            return GH_GetterResult.accept;
        }

        protected override GH_GetterResult Prompt_Plural(ref List<ScadPropertiesType> values)
        {
            return GH_GetterResult.accept;
        }
    }
}
