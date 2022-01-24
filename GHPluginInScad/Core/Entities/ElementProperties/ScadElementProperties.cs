using GHPlugin.Scad.Core.Entities.ElementProperties.Interfaces;

namespace GHPlugin.Scad.Core.Entities.ElementProperties
{
    public sealed class ScadElementProperties : IScadElementProperties
    {
        public IElementRigid ElementRigid { get; set; }
    }
}