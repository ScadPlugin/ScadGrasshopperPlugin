using System;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;

namespace ScadGrasshopperPlugin.GHDataTypes.Elements
{
    public class TriStateType : GH_Goo<int>
    {
        // Default Constructor, sets the state to Unknown.
        public TriStateType()
        {
            this.Value = -1;
        }

        // Constructor with initial value
        public TriStateType(int tristateValue)
        {
            this.Value = tristateValue;
        }

        // Copy Constructor
        public TriStateType(TriStateType tristateSource)
        {
            this.Value = tristateSource.Value;
        }

        public override IGH_Goo Duplicate()
        {
            return new TriStateType(this);
        }

        public override string ToString()
        {
            if (this.Value == 0)
            {
                return "False";
            }

            if (this.Value > 0)
            {
                return "True";
            }

            return "Unknown";
        }

        public override bool IsValid { get => true; }

        public override string TypeName
        {
            get => "TriState";
        }

        public override string TypeDescription
        {
            get => "A TriState Value (True, False or Unknown)";
        }


        // Override the Value property to strip non-sensical states.
        public override int Value
        {
            get { return base.Value; }
            set
            {
                if (value < -1)
                {
                    value = -1;
                }

                if (value > +1)
                {
                    value = +1;
                }

                base.Value = value;
            }
        }

        // Serialize this instance to a Grasshopper writer object.
        public override bool Write(GH_IO.Serialization.GH_IWriter writer)
        {
            
            writer.SetInt32("tri", this.Value);
            return true;
        }

        // Deserialize this instance from a Grasshopper reader object.
        public override bool Read(GH_IO.Serialization.GH_IReader reader)
        {
            this.Value = reader.GetInt32("tri");
            return true;
        }
        // Return the Integer we use to represent the TriState flag.
        public override object ScriptVariable()
        {
            return this.Value;
        }

        // This function is called when Grasshopper needs to convert this 
        // instance of TriStateType into some other type Q.
        public override bool CastTo<Q>(ref Q target)
        {
            //First, see if Q is similar to the Integer primitive.
            if (typeof(Q).IsAssignableFrom(typeof(int)))
            {
                object ptr = this.Value;
                target = (Q)ptr;
                return true;
            }

            //Then, see if Q is similar to the GH_Integer type.
            if (typeof(Q).IsAssignableFrom(typeof(GH_Integer)))
            {
                object ptr = new GH_Integer(this.Value);
                target = (Q)ptr;
                return true;
            }

            //We could choose to also handle casts to Boolean, GH_Boolean, 
            //Double and GH_Number, but this is left as an exercise for the reader.
            return false;
        }

        // This function is called when Grasshopper needs to convert other data 
        // into TriStateType.
        public override bool CastFrom(object source)
        {
            //Abort immediately on bogus data.
            if (source == null) { return false; }

            //Use the Grasshopper Integer converter. By specifying GH_Conversion.Both 
            //we will get both exact and fuzzy results. You should always try to use the
            //methods available through GH_Convert as they are extensive and consistent.
            int val;
            if (GH_Convert.ToInt32(source, out val, GH_Conversion.Both))
            {
                this.Value = val;
                return true;
            }

            //If the integer conversion failed, we can still try to parse Strings.
            //If possible, you should ensure that your data type can 'deserialize' itself 
            //from the output of the ToString() method.
            string str = null;
            if (GH_Convert.ToString(source, out str, GH_Conversion.Both))
            {
                switch (str.ToUpperInvariant())
                {
                    case "FALSE":
                    case "F":
                    case "NO":
                    case "N":
                        this.Value = 0;
                        return true;

                    case "TRUE":
                    case "T":
                    case "YES":
                    case "Y":
                        this.Value = +1;
                        return true;

                    case "UNKNOWN":
                    case "UNSET":
                    case "MAYBE":
                    case "DUNNO":
                    case "?":
                        this.Value = -1;
                        return true;
                }
            }

            //We've exhausted the possible conversions, it seems that source
            //cannot be converted into a TriStateType after all.
            return false;
        }
    }
}