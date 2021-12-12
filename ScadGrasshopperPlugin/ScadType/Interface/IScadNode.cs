namespace ScadGrasshopperPlugin.ScadType.Interface
{
    public interface IScadNode
    {
        int Number { get; set; }
        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }
    }
}