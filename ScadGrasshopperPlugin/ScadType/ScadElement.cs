using System.Collections.Generic;

namespace ScadGrasshopperPlugin.ScadType.Interface
{
    public sealed class ScadElement : IScadElement
    {
        public int Number { get; set; }
        public List<IScadNode> ScadNodes { get; set; }
        public IScadElementProperties ScadElementProperties { get; set; }
    }
}