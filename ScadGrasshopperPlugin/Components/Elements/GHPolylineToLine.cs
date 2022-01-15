using System;
using System.Collections.Generic;
using Grasshopper.Kernel;
using Rhino.Geometry;
using ScadGrasshopperPlugin.Components.GHParameters;

namespace ScadGrasshopperPlugin.Components.Elements
{
    public class GHPolylineToLine : GH_Component
    {
        public GHPolylineToLine()
            : base("GHPolylineToLine", "TT",
                "Convert GH polyline to list lines",
                "SCAD", "Helper")
        {
        }


        #region Public

        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddCurveParameter("Polyline", "Pl", "GH Polyline", GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddLineParameter("Line", "L", "Convert Polyliine to Line",
                GH_ParamAccess.list);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Curve curve = null;
            if (!DA.GetData(0, ref curve))
                return;

            List<Line> lines = new List<Line>();

            if (curve.IsPolyline())
            {
                if (curve.TryGetPolyline(out Polyline polyline))
                {
                    lines = CreateListLine(polyline);
                }
            }
            else
            {
                throw new Exception("It is not Polyline");
            }

            DA.SetDataList(0, lines);
        }

        protected override System.Drawing.Bitmap Icon => null;


        public override Guid ComponentGuid => new Guid("B2E2BE0F-FBE1-498D-995A-6D31E9439430");

        #endregion


        #region Private

        /// <summary>
        /// Создает список линий из полилинии
        /// </summary>
        /// <param name="polyline">Полилиния</param>
        /// <returns></returns>
        private List<Line> CreateListLine(Polyline polyline)
        {
            List<Line> lines = new List<Line>();

            for (int i = 1; i < polyline.Count; i++)
            {
                Point3d poinFrom = polyline[i - 1];
                Point3d poinTo = polyline[i];

                lines.Add(CreateLine(poinFrom, poinTo));
            }

            return lines;
        }

        /// <summary>
        /// Создание GH линии
        /// </summary>
        /// <param name="from">точка начала линии</param>
        /// <param name="to">Точка окончания линии</param>
        /// <returns>GH линия</returns>
        private Line CreateLine(Point3d from, Point3d to)
        {
            Line line = new Line(from, to);

            return line;
        }

        #endregion
    }
}