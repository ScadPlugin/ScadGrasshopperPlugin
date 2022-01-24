using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Core.Entities.ElementProperties.Interfaces;
using Grasshopper.Kernel.Types;

namespace ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.ElementProperties
{
    public class ScadElementRigidType : GH_Goo<IElementRigid>
    {
        private readonly IElementRigid _scadElementRigid;

        public ScadElementRigidType()
        {
        }

        public ScadElementRigidType(IElementRigid elementRigid)
        {
            _scadElementRigid = elementRigid;
            Value = _scadElementRigid;
        }

        public ScadElementRigidType(ScadElementRigidType scadElementRigidType)
        {
            Value = scadElementRigidType.Value;
        }

        public override IGH_Goo Duplicate()
        {
            return new ScadElementRigidType(this);
        }

        public override string ToString()
        {
            return $"Rigid: {_scadElementRigid.Name}";
        }

        public override bool IsValid
        {
            get
            {
                if (_scadElementRigid == null)
                {
                    return false;
                }
                return true;
            }
        }
        public override string TypeName { get => "S_Rigid"; }
        public override string TypeDescription { get => "Element rigid"; }
    }
}