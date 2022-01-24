using GHPlugin.Scad.Core.Entities.ElementProperties.Interfaces;

namespace GHPlugin.Scad.Core.Entities.ElementProperties
{
    public  sealed  class ElementRigid : IElementRigid
    {
        public string Name { get; set; }
        public string RigidCode { get; set; }
    }
}