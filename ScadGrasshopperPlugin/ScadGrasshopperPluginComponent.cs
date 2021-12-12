using Grasshopper;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using ScadGrasshopperPlugin.GHParameters;

namespace ScadGrasshopperPlugin
{
    public class ScadGrasshopperPluginComponent : GH_Component
    {
        
        public ScadGrasshopperPluginComponent()
          : base("ScadGrasshopperPlugin", "BBF",
            "Construct an Archimedean, or arithmetic, spiral given its radii and number of turns.",
            "SCAD", "Elem")
        {
        }


        #region Public

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            //pManager.AddLineParameter("Simple Line", "L", "Just line", GH_ParamAccess.item);
            pManager.AddParameter(new TriStateParameter(),"Custom param", "CP", "TEST TEST", GH_ParamAccess.item);
           
        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
        }

        protected override System.Drawing.Bitmap Icon => null;


        public override Guid ComponentGuid => new Guid("D3A0A006-D211-4342-8E58-B355658E5242");

        #endregion


        #region Private



        #endregion
    }
}