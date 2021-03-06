using System;
using Grasshopper.Kernel;
using Rhino.Geometry;
using ScadGrasshopperPlugin.Components.GHParameters;

namespace ScadGrasshopperPlugin.Components.Elements
{
    public class ScadLineComponent : GH_Component
    {
        public ScadLineComponent()
            : base("ScadGrasshopperPlugin", "SCADLine",
                "Convert GH line to SCAD++ line",
                "SCAD", "Element")
        {
        }


        #region Public

        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddLineParameter("Line", "L", "GH Line", GH_ParamAccess.item);

        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddParameter(new ScadLineParameter(), "ScadLine", "S_L", "SCAD line element",
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