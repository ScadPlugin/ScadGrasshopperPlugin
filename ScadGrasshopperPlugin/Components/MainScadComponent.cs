using Grasshopper.Kernel;
using ScadGrasshopperPlugin.Components.GHParameters;
using ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements;
using System;
using System.Collections.Generic;
using GHPlugin.Core;
using GHPlugin.Core.Entities;
using GHPlugin.Core.Entities.Elements.Base;
using GHPlugin.Core.Helpers;

namespace ScadGrasshopperPlugin
{
    public class MainScadComponent : GH_Component
    {
   
        /// <summary>
        /// Initializes a new instance of the MyComponent1 class.
        /// </summary>
        public MainScadComponent()
          : base("MyComponent1", "Nickname",
              "Description",
              "SCAD", "Main")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddParameter(new ScadLineParameter(), "ScadLine", "S_L", "SCAD line element",
                GH_ParamAccess.list);
            pManager.AddBooleanParameter("Export", "E", "Export in SCAD", GH_ParamAccess.item, false);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            List<ScadLineType> scadLineList = new List<ScadLineType>();
            bool isSaveJson = false;
            if (!DA.GetDataList(0, scadLineList)) return;
            if (!DA.GetData(1, ref isSaveJson)) return;

            if (isSaveJson)
            {
                
                FillFactory factory = new FillFactory(CreateScadElemList(scadLineList));
                MainScad mainScad = factory.GetMainScad;

                ScadCreator scad = new ScadCreator(mainScad);
                scad.Run();

            }
            
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("8A8983B6-BC61-4B24-8489-4CD345E34AD1"); }
        }

        #region Private

        /// <summary>
        /// Заполняет список элементов SCAD из входящего списка данных GH
        /// </summary>
        /// <param name="scadLineList">Данные GH</param>
        /// <returns></returns>
        private List<Element> CreateScadElemList(List<ScadLineType> scadLineList)
        {
            List<Element> listScadElements = new List<Element>();

            foreach (var scadLineType in scadLineList)
            {
                listScadElements.Add(scadLineType.Value);
            }

            return listScadElements;
        }

        #endregion
    }
}