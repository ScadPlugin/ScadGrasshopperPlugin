using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grasshopper.Kernel.Types;
using ScadGrasshopperPlugin.ScadType.Interface;

namespace ScadGrasshopperPlugin.GHDataTypes.Elements
{
    public class ScadLineType : GH_Goo<ScadElement>
    {
        private readonly ScadElement _scadElement;

        public ScadLineType()
        {
        }

        public ScadLineType(ScadElement scadElement)
        {
            _scadElement = scadElement;
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
            return $"";
        }

        public override bool IsValid
        {
            get
            {
                if (_scadElement == null)
                {
                    return false;
                }

                return true;
            }
        }

        public override string TypeName { get => "LineElement"; }
        public override string TypeDescription { get => "Scad line element"; }
    }
}