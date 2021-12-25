using System;
using System.Collections.Generic;
using GHPlugin.Core.Entities.Elements.Interface;

namespace GHPlugin.Core.Entities.Elements.Base
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
