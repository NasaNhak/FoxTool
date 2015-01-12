using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppTonemap
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxBool Enable { get; set; }
        public FoxFloat Threshold { get; set; }
        public FoxFloat Range { get; set; }
    }
}
