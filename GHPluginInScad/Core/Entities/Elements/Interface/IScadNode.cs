namespace GHPlugin.Scad.Core.Entities.Elements.Interface
{
    public interface IScadNode
    {
        int Number { get; set; }
        string Id { get; }
        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }
    }
}