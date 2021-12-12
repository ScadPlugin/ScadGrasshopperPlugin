using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grasshopper.Kernel;
using ScadGrasshopperPlugin.GHDataTypes.Elements;

namespace ScadGrasshopperPlugin.GHParameters
{
    public class TriStateParameter : GH_PersistentParam<TriStateType>
    {
        // We need to supply a constructor without arguments that calls the base class constructor.
        public TriStateParameter() :
            base("TriState", "Tri", "Represents a collection of TriState values", "SCAD", "Primitive")
        { }

        public override Guid ComponentGuid { get { return new Guid("8D32F460-1E9C-4973-8FA2-2B9286F55298"); } }
        protected override GH_GetterResult Prompt_Singular(ref TriStateType value)
        {

            Rhino.Input.Custom.GetOption go = new Rhino.Input.Custom.GetOption();
            go.SetCommandPrompt("TriState_value");
            go.AcceptNothing(true);
            go.AddOption("True");
            go.AddOption("False");
            go.AddOption("Unknown");

            switch (go.Get())
            {
                case Rhino.Input.GetResult.Option:
                    if (go.Option().EnglishName == "True") { value = new TriStateType(1); }
                    if (go.Option().EnglishName == "False") { value = new TriStateType(0); }
                    if (go.Option().EnglishName == "Unknown") { value = new TriStateType(-1); }
                    return GH_GetterResult.success;

                case Rhino.Input.GetResult.Nothing:
                    return GH_GetterResult.accept;

                default:
                    return GH_GetterResult.cancel;
            }
        }

        protected override GH_GetterResult Prompt_Plural(ref List<TriStateType> values)
        {
            
            values = new List<TriStateType>();

            while (true)
            {
                TriStateType val = null;
                switch (Prompt_Singular(ref val))
                {
                    case GH_GetterResult.success:
                        values.Add(val);
                        break;

                    case GH_GetterResult.accept:
                        return GH_GetterResult.success;

                    case GH_GetterResult.cancel:
                        values = null;
                        return GH_GetterResult.cancel;
                }

            }

        }
        
    }
}
