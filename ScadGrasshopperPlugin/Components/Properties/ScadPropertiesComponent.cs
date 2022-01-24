using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Core.Entities.ElementProperties;
using GHPlugin.Scad.Core.Entities.Elements;
using Grasshopper.Kernel;
using ScadGrasshopperPlugin.Components.GHParameters;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.ElementProperties;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements;

namespace ScadGrasshopperPlugin.Components.Properties
{
    public class ScadPropertiesComponent : GH_Component
    {
        public ScadPropertiesComponent() : base(
            "ScadProperties",
            "ScadProp",
            "Properties for SCAD element",
            "SCAD",
            "Properties")
        {
        }


        #region Public

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddParameter(new ScadElementRigidParameter(),
                "ElementRigid",
                "S_ER",
                "SCAD Element rigid",
                GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddParameter(new ScadPropertiesParameter(), "ScadProp", "S_Pr", "Properties for SCAD element",
                GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            ScadElementRigidType elementRigid = new ScadElementRigidType();
            if (!DA.GetData(0, ref elementRigid)) return;

            ScadElementProperties elementProperties = new ScadElementProperties(){ElementRigid = elementRigid.Value};
            ScadPropertiesType scadProperties = new ScadPropertiesType(elementProperties);

            DA.SetData(0, scadProperties);
        }

        public override Guid ComponentGuid
        {
            get => new Guid("D754AB4A-4761-4890-81BE-35489B370DE5");
        }

        #endregion


        #region Private


        #endregion
    }
}