using System;
using ScadGrasshopperPlugin.ScadType.Interface;

namespace ScadGrasshopperPlugin.ScadType
{
    public sealed class ScadNode : IScadNode
    {
        public ScadNode()
        {
            Id = Guid.NewGuid().ToString("N");
        }
        public int Number { get; set; }
        public string Id { get; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}