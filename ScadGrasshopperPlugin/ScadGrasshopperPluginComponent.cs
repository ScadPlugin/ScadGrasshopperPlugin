using Grasshopper;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using ScadGrasshopperPlugin.GHDataTypes.Elements;
using ScadGrasshopperPlugin.GHParameters;
using ScadGrasshopperPlugin.ScadType.Interface;

namespace ScadGrasshopperPlugin
{
    public class ScadGrasshopperPluginComponent : GH_Component
    {
        public ScadGrasshopperPluginComponent()
            : base("ScadGrasshopperPlugin", "TT",
                "TEST TEST",
                "SCAD", "TEST")
        {
        }


        #region Public

        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddLineParameter("Simple Line", "L", "Just line", GH_ParamAccess.item);

        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddParameter(new ScadLineParameter(), "ScadLine", "S_L", "SCAD a line element",
                GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Line line = new Line();
            if (!DA.GetData(0, ref line)) return;

            DA.SetData(0, line);
        }

        protected override System.Drawing.Bitmap Icon => null;


        public override Guid ComponentGuid => new Guid("D3A0A006-D211-4342-8E58-B355658E5242");

        #endregion


        #region Private

        #endregion
    }
}