using GHPlugin.Scad.Core.Entities.Elements.Base;

namespace GHPlugin.Scad.Core.Entities.Elements
{
    public sealed class ScadLineElement: Element
    {

        public ScadNode StartNode { get; set; }
        public ScadNode EndNode { get; set; }

    }
}