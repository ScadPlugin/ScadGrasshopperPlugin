using ScadGrasshopperPlugin.ScadType.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using ScadGrasshopperPlugin.ScadType.Base;

namespace ScadGrasshopperPlugin.ScadType
{
    public sealed class ScadLineElement: Element
    {

        public ScadNode StartNode { get; set; }
        public ScadNode EndNode { get; set; }

    }
}