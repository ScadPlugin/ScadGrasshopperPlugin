using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Core.Entities.ElementProperties;
using Grasshopper.GUI;
using Grasshopper.Kernel;
using ScadGrasshopperPlugin.Components.GHParameters;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.ElementProperties;

namespace ScadGrasshopperPlugin.Components.Properties.Rigids
{
    public class RectangleRigidComponent : GH_Component
    {
        public RectangleRigidComponent() : base("ElementRigid",
            "ElemRigid",
            "SCAD a element rigid ",
            "SCAD",
            "Rigid")
        {
        }

        #region Public

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            //TEST PARAM
            pManager.AddTextParameter("TxtName", "TN", "Just txt", GH_ParamAccess.item);
            pManager.AddTextParameter("TxtRigidCode", "TRC", "Just txt", GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddParameter(
                new ScadElementRigidParameter(),
                "ElementRigid",
                "S_ER",
                "SCAD Element rigid",
                GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            string name = String.Empty;
            string rigidCode = String.Empty;

            if (!DA.GetData(0, ref name)) return;
            if (!DA.GetData(1, ref rigidCode)) return;

            ElementRigid elementRigid = new ElementRigid() {Name = name, RigidCode = rigidCode};
            ScadElementRigidType elementRigidType = new ScadElementRigidType(elementRigid);

            DA.SetData(0, elementRigidType);
        }

        public override Guid ComponentGuid
        {
            get => new Guid("52512776-7F9E-46AC-B8E1-4615156700EF");
        }

        #endregion


        #region Private

        

        #endregion
    }
}