using System;
using System.Collections.Generic;
using GHPlugin.Scad.Core.Entities.ElementProperties.Interfaces;
using GHPlugin.Scad.Core.Entities.Elements.Interface;

namespace GHPlugin.Scad.Core.Entities.Elements.Base
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
