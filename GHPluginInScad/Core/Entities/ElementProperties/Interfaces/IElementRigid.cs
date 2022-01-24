using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GHPlugin.Scad.Core.Entities.ElementProperties.Interfaces
{
    public interface IElementRigid
    {
        string Name { get; set; }
        string RigidCode { get; set; }

    }
}
