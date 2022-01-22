using GHPlugin.Scad.Core.Entities.Elements;
using Grasshopper.Kernel.Types;
using ScadGrasshopperPlugin.Helpers;

namespace ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements
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
            Value = _scadLineElement;
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

            ScadLineElement scadLine = new ScadLineElement();

            if (ScadConvector.GHLineToScadElement(source, ref scadLine))
            {
                Value = scadLine;
                return true;
            }

            return false;
        }
    }
}