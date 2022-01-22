using GHPlugin.Scad.Core.Entities.Elements.Interface;
using Grasshopper.Kernel.Types;

namespace ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements
{
    public class ScadPropertiesType : GH_Goo<IScadElementProperties>
   {

       private readonly IScadElementProperties _scadElementProperties;
        public ScadPropertiesType()
        {
            
        }

        public ScadPropertiesType(IScadElementProperties properties)
        {
            _scadElementProperties = properties;
            Value = _scadElementProperties;
        }

        public ScadPropertiesType(ScadPropertiesType scadPropertiesType)
        {
            Value = scadPropertiesType.Value;
        }
        public override IGH_Goo Duplicate()
        {
            return new ScadPropertiesType(this);
        }

        public override string ToString()
        {
            return $"S_Properties:\n  -Rigid: {_scadElementProperties.RigidCode}";
        }

        public override bool IsValid
        {
            get
            {
                if (_scadElementProperties == null)
                {
                    return false;
                }

                return true;
            }
        }
        public override string TypeName { get => "S_Properties"; }
        public override string TypeDescription { get => "Properties for SCAD elements"; }
    }
}
