using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScadGrasshopperPlugin.ScadType.Interface;

namespace ScadGrasshopperPlugin.ScadType.Base
{
    public class Element
    {
        public Element()
        {

            Id = Guid.NewGuid().ToString("N");
        }

        public string Id { get; }
        public int Number { get; set; }
        public List<ScadNode> ScadNodes { get; set; }
        public IScadElementProperties ScadElementProperties { get; set; }
    }
}
