namespace ScadGrasshopperPlugin.ScadType.Interface
{
    public sealed class ScadNode : IScadNode
    {
        public int Number { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}