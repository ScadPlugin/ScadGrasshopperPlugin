using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grasshopper.Kernel;
using ScadGrasshopperPlugin.GHDataTypes.Elements;

namespace ScadGrasshopperPlugin.GHParameters
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