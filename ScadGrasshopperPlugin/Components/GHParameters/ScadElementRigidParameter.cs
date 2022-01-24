using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grasshopper.Kernel;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.ElementProperties;

namespace ScadGrasshopperPlugin.Components.GHParameters
{
    public class ScadElementRigidParameter : GH_Param<ScadElementRigidType>
    {
        public ScadElementRigidParameter():base(
            "ScadElemRigid", 
            "S_ER", 
            "SCAD a element rigid", 
            "SCAD", 
            "Primitive", 
            GH_ParamAccess.item)
        {
            
        }
        
        public override Guid ComponentGuid { get => new Guid("C85307EA-2A60-4CCF-9DC2-046AE6AE23BF"); }
    }
}
