using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Core.Entities.Elements;
using Grasshopper.Kernel;
using ScadGrasshopperPlugin.Components.GHParameters;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements;

namespace ScadGrasshopperPlugin.Components.Elements
{
    public class GetScadNodesFromLine : GH_Component
    {
        public GetScadNodesFromLine():base("GetScadNodesFromLine", "GetNodes",
                "Get nodes from a line",
            "SCAD", "Helper")
        {
            
        }
        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddParameter(new ScadLineParameter(), "ScadLine", "S_L", "SCAD line element",
                GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddParameter(new ScadNodeParameter(), "ScadNodes", "S_N", "nodes for SCAD",
                GH_ParamAccess.list);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            ScadLineType scadLine = new ScadLineType();
            if (!DA.GetData(0, ref scadLine)) return;

            ScadNodeType nodeTypeStart = new ScadNodeType(scadLine.Value.StartNode);
            ScadNodeType nodeTypeEnd = new ScadNodeType(scadLine.Value.EndNode);

            List<ScadNodeType> nodes = new List<ScadNodeType>(){nodeTypeStart, nodeTypeEnd};
            
            DA.SetDataList(0, nodes);
        }
        
        public override Guid ComponentGuid  => new Guid("E4CCAD19-EE86-49BD-8ECE-0221FC89223F");
    }
}
