using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using Rhino.Geometry;
using ScadGrasshopperPlugin.Helpers;
using ScadGrasshopperPlugin.ScadType;
using ScadGrasshopperPlugin.ScadType.Interface;

namespace ScadGrasshopperPlugin.GHDataTypes.Elements
{
    public class ScadLineType : GH_Goo<ScadLineElement>
    {
        private readonly ScadLineElement _scadLineElement;

        public ScadLineType()
        {
        }

        public ScadLineType(ScadLineElement scadLineElement)
        {
            _scadLineElement = scadLineElement;
        }

        public ScadLineType(ScadLineType scadLineType)
        {
            Value = scadLineType.Value;
        }

        public override IGH_Goo Duplicate()
        {

            return new ScadLineType(this);
        }

        public override string ToString()
        {
            return $"ScadLine";
        }

        public override bool IsValid
        {
            get
            {
                if (_scadLineElement == null)
                {
                    return false;
                }

                return true;
            }
        }

        public override string TypeName { get => "LineElement"; }
        public override string TypeDescription { get => "Scad line element"; }

        public override bool CastFrom(object source)
        {
            if (source == null) { return false; }

            ScadLineElement scadLineLine = new ScadLineElement();

            if (ScadConvector.ToScadElement(source, scadLineLine))
            {
                Value = scadLineLine;
                return true;
            }

            return false;
        }
    }
}