using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grasshopper.Kernel;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements;

namespace ScadGrasshopperPlugin.Components.GHParameters
{
    public class ScadNodeParameter : GH_Param<ScadNodeType>
    {
        public ScadNodeParameter() : base(
            "ScadNode", 
            "S_N", 
            "Node for SCAD", 
            "SCAD", 
            "Primitive", 
            GH_ParamAccess.item)
        {
        }
        
        public override Guid ComponentGuid { get => new Guid("46DFF342-B2B1-4772-83F6-134885A7BB2E"); }
    }
}