using System;
using GHPlugin.Scad.Core.Entities.Elements;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Data;
using Rhino.Geometry;
using ScadGrasshopperPlugin.Components.GHParameters;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.ElementProperties;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements;
using ScadGrasshopperPlugin.Helpers;

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
           
            pManager.AddParameter(new ScadPropertiesParameter(), "ScadProp", "S_Pr", "Properties for SCAD element",
                GH_ParamAccess.item);
            

        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddParameter(new ScadLineParameter(), "ScadLine", "S_L", "SCAD line element",
                GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Line line = new Line();
            ScadPropertiesType scadProperties = new ScadPropertiesType();
            if (!DA.GetData(0, ref line)) return;
            DA.GetData(1, ref scadProperties);
            
            ScadLineType scadLine = new ScadLineType(ConvertGhLineToScadLine(line));
            scadLine.Value.ScadElementProperties = scadProperties.Value;

            DA.SetData(0, scadLine);
        }

        protected override System.Drawing.Bitmap Icon => null;


        public override Guid ComponentGuid => new Guid("D3A0A006-D211-4342-8E58-B355658E5242");

        #endregion


        #region Private

        private ScadLineElement ConvertGhLineToScadLine(Line ghLine)
        {
            if (ghLine == null)
            {
                throw new ArgumentNullException("Empty object");
            }

            ScadLineElement scadLine = new ScadLineElement();

            if (ScadConvector.GHLineToScadElement(ghLine, ref scadLine))
            {
                return scadLine;
            }
            else
            {
                throw new ArgumentException("Error convert Line to SCAD line");
            }
        }

        #endregion
    }
}