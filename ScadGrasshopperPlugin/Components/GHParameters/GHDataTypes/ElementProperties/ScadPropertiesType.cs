using System;
using GHPlugin.Scad.Core.Entities.ElementProperties;
using GHPlugin.Scad.Core.Entities.ElementProperties.Interfaces;
using Grasshopper.Kernel.Types;

namespace ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.ElementProperties
{
    public class ScadPropertiesType : GH_Goo<IScadElementProperties>
   {

       private readonly IScadElementProperties _scadElementProperties;
        public ScadPropertiesType()
        {
            _scadElementProperties = new ScadElementProperties()
            {
                RigidCode = null
            };
            Value = _scadElementProperties;
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
            if (_scadElementProperties.RigidCode == null)
            {
                return $"S_Properties:\n  -Rigid: NULL";
            }
            return $"S_Properties:\n  -Rigid: {_scadElementProperties.RigidCode.RigidCode}";
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
