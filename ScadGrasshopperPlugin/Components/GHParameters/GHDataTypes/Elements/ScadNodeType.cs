using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GHPlugin.Scad.Core.Entities.Elements;
using Grasshopper.Kernel.Types;

namespace ScadGrasshopperPlugin.Components.GHParameters.GHDataTypes.Elements
{
    public class ScadNodeType : GH_Goo<ScadNode>
    {
        private readonly ScadNode _scadNode;
        public ScadNodeType()
        {
        }

        public ScadNodeType( ScadNode node)
        {
            _scadNode = node;
            Value = _scadNode;
        }

        public ScadNodeType( ScadNodeType scadNodeType)
        {
            Value = scadNodeType.Value;
        }
        public override IGH_Goo Duplicate()
        {
            return new ScadNodeType(this);
        }

        public override string ToString()
        {
            return $"S_Node: [{Value.X}, {Value.Y}, {Value.Z}]";
           
        }

        public override bool IsValid
        {
            get
            {
                if (_scadNode == null)
                {
                    return false;
                }

                return true;
            }
        }

        public override string TypeName { get => "ScadNode"; }
        public override string TypeDescription { get => "Node for SCAD"; }
    }
}