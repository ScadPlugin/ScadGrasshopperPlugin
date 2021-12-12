using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScadGrasshopperPlugin.ScadType.Interface
{
    public interface IScadElement
    {
        int Number { get; set; }
        List<IScadNode> ScadNodes { get; set; }

        IScadElementProperties ScadElementProperties { get; set; }
    }
}